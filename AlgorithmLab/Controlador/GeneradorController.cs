using AlgorithmLab.Modelo;
using System;
using System.Linq;

namespace AlgorithmLab.Controlador
{
    public class GeneradorController
    {
        public void GenerarDatos(int cantidad, string tipoDato, string distribucion)
        {
            IComparable[] datosGenerados = new IComparable[cantidad];
            Random rnd = new Random();

            // 1. Generación según Tipo de Dato
            if (tipoDato == "Entero")
            {
                for (int i = 0; i < cantidad; i++) datosGenerados[i] = rnd.Next(0, 1000000);
            }
            else if (tipoDato == "Decimal")
            {
                for (int i = 0; i < cantidad; i++) datosGenerados[i] = Math.Round(rnd.NextDouble() * 10000, 2);
            }
            else // Texto
            {
                for (int i = 0; i < cantidad; i++) datosGenerados[i] = Guid.NewGuid().ToString().Substring(0, 8);
            }

            // 2. Aplicar Distribución (Ordenado, Inverso)
            if (distribucion == "Ordenado")
            {
                Array.Sort(datosGenerados);
            }
            else if (distribucion == "Inverso")
            {
                Array.Sort(datosGenerados);
                Array.Reverse(datosGenerados);
            }
            // Si es "Aleatorio", ya está listo.

            // 3. Guardar en Contexto Global
            ContextoGlobal.DatosActuales = new MuestraDatos
            {
                Datos = datosGenerados,
                TipoDato = tipoDato,
                EstaOrdenado = (distribucion == "Ordenado")
            };
        }
    }
}