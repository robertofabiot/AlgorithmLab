using AlgorithmLab.Controlador;
using AlgorithmLab.Modelo;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmLab.Vista
{
    public partial class UCSearch : UserControl
    {
        private BusquedaController _controller;

        public UCSearch()
        {
            InitializeComponent();
            _controller = new BusquedaController();
            ConfigurarGrafico();

            // Lógica de CheckBox Modo (Solo uno a la vez, igual que en Sort)
            clbModoEjecucion.ItemCheck += (s, e) => {
                if (e.NewValue == CheckState.Checked)
                    for (int i = 0; i < clbModoEjecucion.Items.Count; i++)
                        if (i != e.Index) clbModoEjecucion.SetItemChecked(i, false);
            };
        }

        private void ConfigurarGrafico()
        {
            // Usamos un gráfico de barras para comparar la eficiencia (Saltos/Pasos es la mejor métrica aquí)
            formsPlotBusqueda.Plot.Title("Comparativa de Eficiencia (Pasos/Saltos)");
            formsPlotBusqueda.Plot.Axes.Bottom.Label.Text = "Algoritmo";
            formsPlotBusqueda.Plot.Axes.Left.Label.Text = "Iteraciones";

            // Estilo Dark Industrial
            ScottPlot.Color colorFondo = ScottPlot.Color.FromHex("#464E47");
            formsPlotBusqueda.Plot.FigureBackground.Color = colorFondo;
            formsPlotBusqueda.Plot.DataBackground.Color = colorFondo;

            ScottPlot.Color colorTexto = ScottPlot.Color.FromHex("#F1FFFA");
            formsPlotBusqueda.Plot.Axes.Color(colorTexto);
            formsPlotBusqueda.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#606060");

            formsPlotBusqueda.Refresh();
        }

        private async void btnIniciarBusqueda_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
            if (string.IsNullOrWhiteSpace(tbValorBusqueda.Text))
            {
                MessageBox.Show("Ingresa un valor a buscar.");
                return;
            }
            if (ContextoGlobal.DatosActuales == null)
            {
                MessageBox.Show("No hay datos cargados.");
                return;
            }

            bool usarJump = clbAlgoritmosBusqueda.GetItemChecked(0);
            bool usarInter = clbAlgoritmosBusqueda.GetItemChecked(1);

            if (!usarJump && !usarInter)
            {
                MessageBox.Show("Selecciona al menos un algoritmo.");
                return;
            }

            // 2. Verificar Orden y Regla de Negocio
            bool incluirOrden = false;
            if (!ContextoGlobal.DatosActuales.EstaOrdenado)
            {
                var resp = MessageBox.Show(
                    "Los datos están DESORDENADOS.\n\n" +
                    "Estos algoritmos requieren orden.\n" +
                    "¿Deseas ejecutar 'Merge Sort' y sumar su tiempo a la búsqueda?\n\n" +
                    "Sí: Ordenar + Buscar (Benchmark completo)\n" +
                    "No: Cancelar",
                    "Requisito de Orden",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resp == DialogResult.No) return; // Cancelar
                incluirOrden = true;
            }

            // 3. Preparar UI
            btnIniciarBusqueda.Enabled = false;
            btnAbortar.Enabled = true;
            LimpiarResultados();
            formsPlotBusqueda.Plot.Clear();

            try
            {
                // --- JUMP SEARCH ---
                if (usarJump)
                {
                    pbProgresoJump.Style = ProgressBarStyle.Marquee;
                    var res = await _controller.EjecutarBusqueda("Jump Search", tbValorBusqueda.Text, incluirOrden);

                    MostrarResultadoJump(res);
                    GraficarBarra(0, res.Iteraciones, "Jump", "#FF5733"); // Rojo
                }

                // --- INTERPOLATION SEARCH ---
                if (usarInter)
                {
                    // Verificamos compatibilidad antes de intentar para no romper el flujo a la mitad
                    if (ContextoGlobal.DatosActuales.TipoDato == "Texto")
                    {
                        lblInterpolada.Text = "No aplicable a Texto.";
                    }
                    else
                    {
                        pbProgresoInterpolada.Style = ProgressBarStyle.Marquee;
                        var res = await _controller.EjecutarBusqueda("Búsqueda Interpolada", tbValorBusqueda.Text, incluirOrden);

                        MostrarResultadoInterpolada(res);
                        GraficarBarra(1, res.Iteraciones, "Interpolada", "#33FF57"); // Verde
                    }
                }

                _controller.GuardarCambios();
                formsPlotBusqueda.Refresh();
                MessageBox.Show("Búsqueda finalizada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                btnIniciarBusqueda.Enabled = true;
                btnAbortar.Enabled = false;
                pbProgresoJump.Style = ProgressBarStyle.Blocks;
                pbProgresoInterpolada.Style = ProgressBarStyle.Blocks;
            }
        }

        private void GraficarBarra(int pos, double valor, string nombre, string hexColor)
        {
            var bar = formsPlotBusqueda.Plot.Add.Bar(position: pos, value: valor);
            bar.LegendText = nombre;
            bar.Color = ScottPlot.Color.FromHex(hexColor);
            formsPlotBusqueda.Plot.Axes.AutoScale();
        }

        private void MostrarResultadoJump(RegistroBenchmark r)
        {
            pbProgresoJump.Style = ProgressBarStyle.Blocks;
            pbProgresoJump.Value = 100;
            string encontrado = r.IndiceEncontrado >= 0 ? $"SÍ (Idx {r.IndiceEncontrado})" : "NO";

            lblJump.Text = $"Encontrado: {encontrado}\n" +
                           $"Tiempo: {r.TiempoEjecucion}\n" +
                           $"Saltos: {r.Iteraciones:N0}";
        }

        private void MostrarResultadoInterpolada(RegistroBenchmark r)
        {
            pbProgresoInterpolada.Style = ProgressBarStyle.Blocks;
            pbProgresoInterpolada.Value = 100;
            string encontrado = r.IndiceEncontrado >= 0 ? $"SÍ (Idx {r.IndiceEncontrado})" : "NO";

            lblInterpolada.Text = $"Encontrado: {encontrado}\n" +
                                  $"Tiempo: {r.TiempoEjecucion}\n" +
                                  $"Iteraciones: {r.Iteraciones:N0}";
        }

        private void LimpiarResultados()
        {
            lblJump.Text = "...";
            lblInterpolada.Text = "...";
            pbProgresoJump.Value = 0;
            pbProgresoInterpolada.Value = 0;
        }

        private void btnAbortar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reinicia la aplicación para cancelar procesos seguros.");
        }
    }
}