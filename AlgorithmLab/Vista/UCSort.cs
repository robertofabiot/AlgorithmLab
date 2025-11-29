using AlgorithmLab.Controlador;
using AlgorithmLab.Modelo;
using ScottPlot; // Necesario para ScottPlot 5
using System;
using System.Collections.Generic;
using System.Diagnostics; // Para Stopwatch
using System.Linq; // Para métodos de listas
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmLab.Vista
{
    public partial class UCSort : UserControl
    {
        private OrdenamientoController _controller;

        // Herramientas de Monitoreo
        private System.Windows.Forms.Timer _timerMonitor;
        private Stopwatch _cronometroVisual;

        // Listas para los datos del gráfico (Tiempo vs Memoria)
        private List<double> _tiempoX_Selection = new List<double>();
        private List<double> _memoriaY_Selection = new List<double>();

        private List<double> _tiempoX_Merge = new List<double>();
        private List<double> _memoriaY_Merge = new List<double>();

        // Variables de estado
        private bool _midiendoSelection = false;
        private bool _midiendoMerge = false;

        public UCSort()
        {
            InitializeComponent();
            _controller = new OrdenamientoController();

            ConfigurarGrafico();
            ConfigurarTimer();

            // Lógica de CheckBox único (Solo permite marcar uno a la vez en Modo)
            clbModoEjecucion.ItemCheck += (s, e) => {
                if (e.NewValue == CheckState.Checked)
                    for (int i = 0; i < clbModoEjecucion.Items.Count; i++)
                        if (i != e.Index) clbModoEjecucion.SetItemChecked(i, false);
            };
        }

        private void ConfigurarGrafico()
        {
            formsPlotOrdenamiento.Plot.Title("Perfil de Memoria en Tiempo Real");
            formsPlotOrdenamiento.Plot.Axes.Bottom.Label.Text = "Tiempo (s)";
            formsPlotOrdenamiento.Plot.Axes.Left.Label.Text = "RAM (MB)";

            // --- CORRECCIÓN DE ESTILO PARA SCOTTPLOT 5 ---
            // ScottPlot 5 no tiene .Style(), se hace manualmente así para modo oscuro:

            // Fondo del control y del gráfico
            ScottPlot.Color colorFondo = ScottPlot.Color.FromHex("#464E47"); // Tu gris oscuro
            formsPlotOrdenamiento.Plot.FigureBackground.Color = colorFondo;
            formsPlotOrdenamiento.Plot.DataBackground.Color = colorFondo;

            // Colores de los ejes y rejillas
            ScottPlot.Color colorTexto = ScottPlot.Color.FromHex("#F1FFFA"); // Tu blanco menta
            formsPlotOrdenamiento.Plot.Axes.Color(colorTexto);
            formsPlotOrdenamiento.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#606060");

            formsPlotOrdenamiento.Refresh();
        }

        private void ConfigurarTimer()
        {
            _timerMonitor = new System.Windows.Forms.Timer();
            _timerMonitor.Interval = 100; // Muestrear cada 100ms (0.1 seg)
            _timerMonitor.Tick += TimerMonitor_Tick;
            _cronometroVisual = new Stopwatch();
        }

        // Este evento se dispara 10 veces por segundo para actualizar el gráfico
        private void TimerMonitor_Tick(object sender, EventArgs e)
        {
            // 1. Medir Memoria Actual
            long bytes = Process.GetCurrentProcess().PrivateMemorySize64;
            double megabytes = bytes / 1024.0 / 1024.0;
            double segundos = _cronometroVisual.Elapsed.TotalSeconds;

            // 2. Guardar en la lista correspondiente
            if (_midiendoSelection)
            {
                _tiempoX_Selection.Add(segundos);
                _memoriaY_Selection.Add(megabytes);
            }
            else if (_midiendoMerge)
            {
                _tiempoX_Merge.Add(segundos);
                _memoriaY_Merge.Add(megabytes);
            }

            // 3. Actualizar Gráfico "En Vivo"
            ActualizarDibujoGrafico();
        }

        private void ActualizarDibujoGrafico()
        {
            // Limpiamos los "Plottables" (líneas) anteriores para no dibujar encima infinitamente
            formsPlotOrdenamiento.Plot.Clear();

            // --- DIBUJAR LÍNEA ROJA (SELECTION) ---
            if (_tiempoX_Selection.Count > 0)
            {
                var lineaSel = formsPlotOrdenamiento.Plot.Add.Scatter(_tiempoX_Selection.ToArray(), _memoriaY_Selection.ToArray());

                // CORRECCIÓN DE COLOR (Ambigüedad): Usamos ScottPlot.Color explícitamente
                lineaSel.Color = ScottPlot.Color.FromHex("#FF5733");

                // CORRECCIÓN DE OBSOLETO: .Label ahora es .LegendText
                lineaSel.LegendText = "Selection Sort";
                lineaSel.LineWidth = 2;
            }

            // --- DIBUJAR LÍNEA VERDE (MERGE) ---
            if (_tiempoX_Merge.Count > 0)
            {
                var lineaMerge = formsPlotOrdenamiento.Plot.Add.Scatter(_tiempoX_Merge.ToArray(), _memoriaY_Merge.ToArray());

                lineaMerge.Color = ScottPlot.Color.FromHex("#33FF57");
                lineaMerge.LegendText = "Merge Sort";
                lineaMerge.LineWidth = 2;
            }

            formsPlotOrdenamiento.Plot.ShowLegend(); // Mostrar leyenda si hay datos
            formsPlotOrdenamiento.Plot.Axes.AutoScale(); // Ajustar zoom
            formsPlotOrdenamiento.Refresh();
        }

        private async void btnIniciarBenchmark_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
            if (ContextoGlobal.DatosActuales == null) { MessageBox.Show("No hay datos. Ve a Configuración."); return; }

            bool usarSelection = clbAlgoritmos.GetItemChecked(0);
            bool usarMerge = clbAlgoritmos.GetItemChecked(1);
            bool modoGrafico = clbModoEjecucion.GetItemChecked(0);

            if (!usarSelection && !usarMerge) { MessageBox.Show("Selecciona al menos un algoritmo."); return; }

            // 2. Reset UI
            btnIniciarBenchmark.Enabled = false;
            btnAbortar.Enabled = true;
            _tiempoX_Selection.Clear(); _memoriaY_Selection.Clear();
            _tiempoX_Merge.Clear(); _memoriaY_Merge.Clear();

            formsPlotOrdenamiento.Plot.Clear();
            formsPlotOrdenamiento.Refresh();
            LimpiarLabels();

            try
            {
                // --- EJECUCIÓN SELECTION SORT ---
                if (usarSelection)
                {
                    _midiendoSelection = true;
                    _cronometroVisual.Restart();

                    if (modoGrafico) _timerMonitor.Start(); // Solo monitorear si es gráfico en vivo

                    // Ejecutar algoritmo
                    var resultadoSel = await _controller.EjecutarSelectionSort(ContextoGlobal.DatosActuales.Datos);

                    _timerMonitor.Stop();
                    _midiendoSelection = false;

                    // Si no fue modo gráfico, al menos graficamos el punto final o una barra
                    if (!modoGrafico) GraficarBarra(0, resultadoSel.TiempoMilisegundos, "Selection", "#FF5733");

                    MostrarResultadosSelection(resultadoSel);
                }

                // Pausa para limpiar memoria
                await Task.Delay(500);

                // --- EJECUCIÓN MERGE SORT ---
                if (usarMerge)
                {
                    _midiendoMerge = true;
                    _cronometroVisual.Restart();

                    if (modoGrafico) _timerMonitor.Start();

                    var resultadoMerge = await _controller.EjecutarMergeSort(ContextoGlobal.DatosActuales.Datos);

                    _timerMonitor.Stop();
                    _midiendoMerge = false;

                    if (!modoGrafico) GraficarBarra(1, resultadoMerge.TiempoMilisegundos, "Merge", "#33FF57");

                    MostrarResultadosMerge(resultadoMerge);
                }

                _controller.GuardarCambios();
                MessageBox.Show("Proceso terminado.");
            }
            catch (Exception ex)
            {
                _timerMonitor.Stop();
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                btnIniciarBenchmark.Enabled = true;
                btnAbortar.Enabled = false;
            }
        }

        private void GraficarBarra(int pos, double valor, string nombre, string hexColor)
        {
            // Método auxiliar para cuando NO es gráfico en vivo (Modo Benchmark)
            var bar = formsPlotOrdenamiento.Plot.Add.Bar(position: pos, value: valor);
            bar.LegendText = nombre; // Nota: En Barras a veces sigue siendo Label o LegendText dependiendo de la subversión, prueba LegendText si falla
            bar.Color = ScottPlot.Color.FromHex(hexColor);
            formsPlotOrdenamiento.Plot.Axes.AutoScale();
            formsPlotOrdenamiento.Refresh();
        }

        private void MostrarResultadosSelection(RegistroBenchmark r)
        {
            lblSelection.Text = $"Tiempo: {r.TiempoEjecucion}\n" +
                                $"Memoria Pico: {r.MemoriaPicoBytes / 1024.0 / 1024.0:F2} MB\n" +
                                $"Intercambios: {r.Iteraciones:N0}";
            pbProgresoSelection.Value = 100;
        }

        private void MostrarResultadosMerge(RegistroBenchmark r)
        {
            lblMerge.Text = $"Tiempo: {r.TiempoEjecucion}\n" +
                            $"Memoria Pico: {r.MemoriaPicoBytes / 1024.0 / 1024.0:F2} MB\n" +
                            $"Iteraciones: {r.Iteraciones:N0}";
            pbProgresoMerge.Value = 100;
        }

        private void LimpiarLabels()
        {
            lblSelection.Text = "Pendiente...";
            lblMerge.Text = "Pendiente...";
            pbProgresoSelection.Value = 0;
            pbProgresoMerge.Value = 0;
        }

        private void btnAbortar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para cancelar operaciones en curso, por seguridad de memoria, reinicia la aplicación.");
        }
    }
}