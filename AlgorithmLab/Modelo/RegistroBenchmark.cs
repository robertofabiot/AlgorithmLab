using System;

namespace AlgorithmLab.Modelo
{
    public class RegistroBenchmark
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string TipoOperacion { get; set; } // "Ordenamiento" o "Búsqueda"
        public string Algoritmo { get; set; }
        public string TiempoEjecucion { get; set; } // Formato 00:00:00.000
        public double TiempoMilisegundos { get; set; } // Para gráficas
        public long MemoriaPicoBytes { get; set; }
        public long Iteraciones { get; set; }
        public string TipoDato { get; set; }
        public int TamanoMuestra { get; set; }

        // Para búsqueda
        public bool SeOrdenoPreviamente { get; set; }
        public string ValorBuscado { get; set; }
        public int IndiceEncontrado { get; set; }
        public string NombreDescriptivo
        {
            get
            {
                // Formato: "Ordenamiento - Selection Sort (10:45:12)"
                return $"{TipoOperacion} - {Algoritmo} ({Fecha:HH:mm:ss})";
            }
        }
    }
}