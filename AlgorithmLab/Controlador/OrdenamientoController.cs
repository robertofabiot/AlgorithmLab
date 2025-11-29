using AlgorithmLab.Algoritmos;
using AlgorithmLab.Modelo;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AlgorithmLab.Controlador
{
    public class OrdenamientoController
    {
        // Añadimos el booleano 'actualizarContexto'
        public async Task<RegistroBenchmark> EjecutarSelectionSort(IComparable[] datos, bool actualizarContexto)
        {
            return await EjecutarAlgoritmo("Selection Sort", datos, LogicaOrdenamiento.SelectionSort, actualizarContexto);
        }

        public async Task<RegistroBenchmark> EjecutarMergeSort(IComparable[] datos, bool actualizarContexto)
        {
            return await EjecutarAlgoritmo("Merge Sort", datos, LogicaOrdenamiento.MergeSort, actualizarContexto);
        }

        private async Task<RegistroBenchmark> EjecutarAlgoritmo(string nombre, IComparable[] datosOriginales, Action<IComparable[]> algoritmo, bool actualizarContexto)
        {
            // 1. Limpieza de memoria
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long memoriaInicial = Process.GetCurrentProcess().PrivateMemorySize64;

            // 2. Clonar (Para medir sobre una copia limpia)
            IComparable[] copia = (IComparable[])datosOriginales.Clone();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // 3. Ejecutar Algoritmo
            await Task.Run(() => algoritmo(copia));

            sw.Stop();

            long memoriaFinal = Process.GetCurrentProcess().PrivateMemorySize64;
            long pico = Math.Max(0, memoriaFinal - memoriaInicial);

            // 4. ACTUALIZACIÓN DEL CONTEXTO (Aquí está la magia)
            if (actualizarContexto)
            {
                // Reemplazamos los datos globales desordenados por los ordenados
                ContextoGlobal.DatosActuales.Datos = copia;
                ContextoGlobal.DatosActuales.EstaOrdenado = true;

                // Opcional: Actualizar el tipo de distribución para que UCConfiguration lo sepa
                // No cambiamos "TipoDato", solo el estado.
            }

            // 5. Crear Registro
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

            ContextoGlobal.HistorialRegistros.Add(registro);
            return registro;
        }

        public void GuardarCambios()
        {
            ContextoGlobal.GuardarRegistrosEnDisco();
        }
    }
}