using AlgorithmLab.Algoritmos;
using AlgorithmLab.Modelo;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AlgorithmLab.Controlador
{
    public class OrdenamientoController
    {
        // Métodos granulares para control total desde la Vista

        public async Task<RegistroBenchmark> EjecutarSelectionSort(IComparable[] datos)
        {
            return await EjecutarAlgoritmo("Selection Sort", datos, LogicaOrdenamiento.SelectionSort);
        }

        public async Task<RegistroBenchmark> EjecutarMergeSort(IComparable[] datos)
        {
            return await EjecutarAlgoritmo("Merge Sort", datos, LogicaOrdenamiento.MergeSort);
        }

        // Método genérico privado para no repetir código
        private async Task<RegistroBenchmark> EjecutarAlgoritmo(string nombre, IComparable[] datosOriginales, Action<IComparable[]> algoritmo)
        {
            // 1. Limpieza agresiva antes de empezar
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long memoriaInicial = Process.GetCurrentProcess().PrivateMemorySize64;

            // 2. Clonar datos (El clon consume RAM, eso se reflejará en el gráfico, ¡es correcto!)
            IComparable[] copia = (IComparable[])datosOriginales.Clone();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // 3. Ejecutar (La Vista estará monitoreando la RAM mientras esto ocurre en otro hilo)
            await Task.Run(() => algoritmo(copia));

            sw.Stop();

            long memoriaFinal = Process.GetCurrentProcess().PrivateMemorySize64;
            long pico = Math.Max(0, memoriaFinal - memoriaInicial);

            // 4. Crear Registro
            var registro = new RegistroBenchmark
            {
                TipoOperacion = "Ordenamiento",
                Algoritmo = nombre,
                TamanoMuestra = datosOriginales.Length,
                TipoDato = ContextoGlobal.DatosActuales.TipoDato,
                TiempoEjecucion = sw.Elapsed.ToString(@"hh\:mm\:ss\.fff"),
                TiempoMilisegundos = sw.Elapsed.TotalMilliseconds,
                MemoriaPicoBytes = pico,
                Iteraciones = LogicaOrdenamiento.ContadorIntercambios,
                Fecha = DateTime.Now
            };

            // Guardar en historial
            ContextoGlobal.HistorialRegistros.Add(registro);

            return registro;
        }

        public void GuardarCambios()
        {
            ContextoGlobal.GuardarRegistrosEnDisco();
        }
    }
}