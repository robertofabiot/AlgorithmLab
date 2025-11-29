using AlgorithmLab.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AlgorithmLab.Controlador
{
    public static class ContextoGlobal
    {
        public static MuestraDatos DatosActuales { get; set; }
        public static List<RegistroBenchmark> HistorialRegistros { get; set; } = new List<RegistroBenchmark>();

        private static string RutaArchivo = "registros.json";

        public static void GuardarRegistrosEnDisco()
        {
            try
            {
                string json = JsonConvert.SerializeObject(HistorialRegistros, Formatting.Indented);
                File.WriteAllText(RutaArchivo, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico al guardar los registros:\n{ex.Message}",
                                "Error de I/O",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public static void CargarRegistrosDesdeDisco()
        {
            try
            {
                if (File.Exists(RutaArchivo))
                {
                    string json = File.ReadAllText(RutaArchivo);

                    // Intentamos deserializar. Si falla (json corrupto), devuelve null, así que usamos ?? new List...
                    HistorialRegistros = JsonConvert.DeserializeObject<List<RegistroBenchmark>>(json) ?? new List<RegistroBenchmark>();
                }
                else
                {
                    // Si no existe el archivo, iniciamos una lista vacía (no es un error)
                    HistorialRegistros = new List<RegistroBenchmark>();
                }
            }
            catch (JsonException jsonEx)
            {
                // Error específico si el JSON está mal formado
                MessageBox.Show($"El archivo de registros está corrupto y no se pudo leer.\nSe iniciará una lista vacía.\n\nDetalle: {jsonEx.Message}",
                                "Error de Formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                // Reiniciamos la lista para evitar crashes posteriores
                HistorialRegistros = new List<RegistroBenchmark>();
            }
            catch (Exception ex)
            {
                // Error general (permisos, disco, etc.)
                MessageBox.Show($"No se pudieron cargar los registros históricos:\n{ex.Message}",
                                "Error de Carga",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                HistorialRegistros = new List<RegistroBenchmark>();
            }
        }
    }
}