using System;

namespace AlgorithmLab.Modelo
{
    public class MuestraDatos
    {
        // Soporta int, float y string
        public IComparable[] Datos { get; set; }
        public string TipoDato { get; set; } // "Entero", "Decimal", "Texto"
        public bool EstaOrdenado { get; set; } = false;
    }
}