using AlgorithmLab.Algoritmos;
using AlgorithmLab.Modelo;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms; // Para el MessageBox si es necesario, o mejor lanzar excepciones

namespace AlgorithmLab.Controlador
{
    public class BusquedaController
    {
        public async Task<RegistroBenchmark> EjecutarBusqueda(string algoritmo, string valorBuscadoStr, bool incluirTiempoOrdenamiento)
        {
            // 1. Validaciones previas
            if (ContextoGlobal.DatosActuales == null)
                throw new Exception("No hay datos cargados.");

            // Detectamos si necesitamos ordenar
            bool requiereOrden = !ContextoGlobal.DatosActuales.EstaOrdenado;

            // Si requiere orden y NO se pidió incluirlo, detenemos (la Vista ya debió preguntar, esto es doble seguridad)
            if (requiereOrden && !incluirTiempoOrdenamiento)
            {
                throw new Exception("Los datos están desordenados. Debes ordenarlos primero o marcar la opción de incluir ordenamiento.");
            }

            // 2. Preparación de datos (Clonamos para no afectar el estado global en una búsqueda destructiva, aunque búsqueda suele ser lectura)
            // En este caso, si vamos a ordenar para la prueba "combinada", trabajamos sobre una copia local para medir ese costo específico
            // sin "arreglar" el global mágicamente (o sí, dependiendo de la regla. Asumiremos que es un benchmark aislado).

            IComparable[] datosTrabajo = (IComparable[])ContextoGlobal.DatosActuales.Datos.Clone();
            string tipoDato = ContextoGlobal.DatosActuales.TipoDato;

            // Parsear el valor a buscar según el tipo de dato
            IComparable valorBuscado = ParsearValor(valorBuscadoStr, tipoDato);
            if (valorBuscado == null) throw new Exception($"El valor '{valorBuscadoStr}' no es válido para el tipo de dato {tipoDato}.");

            // 3. Limpieza de Memoria
            GC.Collect();
            GC.WaitForPendingFinalizers();
            long memoriaInicial = Process.GetCurrentProcess().PrivateMemorySize64;

            // 4. Ejecución y Medición
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // A) FASE DE ORDENAMIENTO (Si aplica)
            if (requiereOrden && incluirTiempoOrdenamiento)
            {
                // Usamos MergeSort por ser estable y eficiente para este propósito
                await Task.Run(() => LogicaOrdenamiento.MergeSort(datosTrabajo));
            }

            // B) FASE DE BÚSQUEDA
            int indice = -1;
            long iteraciones = 0;

            if (algoritmo == "Jump Search")
            {
                await Task.Run(() =>
                {
                    indice = LogicaBusqueda.JumpSearch(datosTrabajo, valorBuscado);
                });
                iteraciones = LogicaBusqueda.PasosRealizados;
            }
            else if (algoritmo == "Búsqueda Interpolada")
            {
                // Validación específica para Interpolada
                if (tipoDato == "Texto")
                    throw new Exception("La Búsqueda Interpolada requiere datos numéricos, no funciona con Texto.");

                // Conversión necesaria para la fórmula matemática
                double[] datosNumericos = ConvertirADouble(datosTrabajo);
                double valNum = Convert.ToDouble(valorBuscado);

                await Task.Run(() =>
                {
                    indice = LogicaBusqueda.InterpolationSearch(datosNumericos, valNum);
                });
                iteraciones = LogicaBusqueda.PasosRealizados;
            }

            sw.Stop();
            long memoriaFinal = Process.GetCurrentProcess().PrivateMemorySize64;
            long picoMemoria = Math.Max(0, memoriaFinal - memoriaInicial);

            // 5. Crear y Guardar Registro
            var registro = new RegistroBenchmark
            {
                TipoOperacion = "Búsqueda",
                Algoritmo = algoritmo,
                ValorBuscado = valorBuscadoStr,
                IndiceEncontrado = indice,
                // Importante: Saber si este tiempo incluye el ordenamiento
                SeOrdenoPreviamente = (requiereOrden && incluirTiempoOrdenamiento),

                TamanoMuestra = datosTrabajo.Length,
                TipoDato = tipoDato,
                TiempoEjecucion = sw.Elapsed.ToString(@"hh\:mm\:ss\.fff"),
                TiempoMilisegundos = sw.Elapsed.TotalMilliseconds,
                MemoriaPicoBytes = picoMemoria,
                Iteraciones = iteraciones,
                Fecha = DateTime.Now
            };

            ContextoGlobal.HistorialRegistros.Add(registro);

            // Si ordenamos el global permanentemente (opcional), actualizaríamos aquí. 
            // Por ahora, mantenemos el benchmark aislado.

            return registro;
        }

        public void GuardarCambios()
        {
            ContextoGlobal.GuardarRegistrosEnDisco();
        }

        private IComparable ParsearValor(string val, string tipo)
        {
            try
            {
                if (tipo == "Entero") return int.Parse(val);
                if (tipo == "Decimal") return double.Parse(val);
                return val;
            }
            catch { return null; }
        }

        private double[] ConvertirADouble(IComparable[] datos)
        {
            double[] nums = new double[datos.Length];
            for (int i = 0; i < datos.Length; i++) nums[i] = Convert.ToDouble(datos[i]);
            return nums;
        }
    }
}