using AlgorithmLab.Algoritmos;
using AlgorithmLab.Modelo;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AlgorithmLab.Controlador
{
    public class BusquedaController
    {
        public async Task<RegistroBenchmark> EjecutarBusqueda(string algoritmo, string valorBuscadoStr, bool incluirOrdenamiento)
        {
            if (ContextoGlobal.DatosActuales == null)
                throw new Exception("No hay datos cargados.");

            var datos = ContextoGlobal.DatosActuales.Datos; // Referencia directa si solo es lectura
            bool estabaOrdenado = ContextoGlobal.DatosActuales.EstaOrdenado;

            // Preparamos el valor a buscar (Parsing genérico simple)
            IComparable valorBuscado = ParsearValor(valorBuscadoStr, ContextoGlobal.DatosActuales.TipoDato);

            Stopwatch sw = new Stopwatch();
            long iteraciones = 0;
            int indiceEncontrado = -1;
            long memoriaInicial = Process.GetCurrentProcess().PrivateMemorySize64;

            sw.Start();

            // --- FASE 1: ORDENAMIENTO (Si es necesario) ---
            // Jump e Interpolation requieren orden. Si no está ordenado, hay que ordenar.
            bool seOrdenoAhora = false;

            if (!estabaOrdenado)
            {
                // Si el usuario pidió medirlo todo junto o es obligatorio para el algoritmo
                if (incluirOrdenamiento)
                {
                    // Trabajamos sobre una copia para no afectar el global si es solo una prueba
                    // Ojo: En búsqueda real, ordenamos el global. Aquí asumiremos copia para benchmark seguro.
                    datos = (IComparable[])datos.Clone();
                    await Task.Run(() => LogicaOrdenamiento.MergeSort(datos));
                    seOrdenoAhora = true;
                }
                else
                {
                    sw.Stop();
                    throw new Exception("Este algoritmo requiere datos ordenados. Ordénalos en la pestaña anterior o marca 'Incluir tiempo de ordenamiento'.");
                }
            }

            // --- FASE 2: BÚSQUEDA ---

            if (algoritmo == "Jump Search")
            {
                await Task.Run(() =>
                {
                    indiceEncontrado = LogicaBusqueda.JumpSearch(datos, valorBuscado);
                });
                iteraciones = LogicaBusqueda.PasosRealizados;
            }
            else if (algoritmo == "Búsqueda Interpolada")
            {
                // Interpolation solo funciona bien con números (Int/Double)
                if (ContextoGlobal.DatosActuales.TipoDato == "Texto")
                {
                    sw.Stop();
                    throw new Exception("La Búsqueda Interpolada no se puede aplicar a Texto (String).");
                }

                // Necesitamos convertir a double[] para la fórmula matemática de interpolación
                double[] datosNumericos = ConvertirADouble(datos);
                double valorNum = Convert.ToDouble(valorBuscado);

                await Task.Run(() =>
                {
                    indiceEncontrado = LogicaBusqueda.InterpolationSearch(datosNumericos, valorNum);
                });
                iteraciones = LogicaBusqueda.PasosRealizados;
            }

            sw.Stop();
            long memoriaFinal = Process.GetCurrentProcess().PrivateMemorySize64;

            // Crear Registro
            var registro = new RegistroBenchmark
            {
                TipoOperacion = "Búsqueda",
                Algoritmo = algoritmo,
                ValorBuscado = valorBuscadoStr,
                IndiceEncontrado = indiceEncontrado,
                SeOrdenoPreviamente = seOrdenoAhora,
                TamanoMuestra = datos.Length,
                TipoDato = ContextoGlobal.DatosActuales.TipoDato,
                TiempoEjecucion = sw.Elapsed.ToString(@"hh\:mm\:ss\.fff"),
                TiempoMilisegundos = sw.Elapsed.TotalMilliseconds,
                MemoriaPicoBytes = Math.Max(0, memoriaFinal - memoriaInicial),
                Iteraciones = iteraciones,
                Fecha = DateTime.Now
            };

            ContextoGlobal.HistorialRegistros.Add(registro);
            ContextoGlobal.GuardarRegistrosEnDisco();

            return registro;
        }

        // Helpers privados
        private IComparable ParsearValor(string val, string tipo)
        {
            if (tipo == "Entero") return int.Parse(val);
            if (tipo == "Decimal") return double.Parse(val);
            return val; // Texto
        }

        private double[] ConvertirADouble(IComparable[] datos)
        {
            // Método costoso pero necesario para Interpolation Search genérico
            double[] nums = new double[datos.Length];
            for (int i = 0; i < datos.Length; i++)
                nums[i] = Convert.ToDouble(datos[i]);
            return nums;
        }
    }
}