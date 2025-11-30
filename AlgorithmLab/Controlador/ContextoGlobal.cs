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

        // Usamos ruta absoluta para evitar que se guarde en system32 u otros lados raros
        private static string RutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registros.json");

        // CONSTRUCTOR ESTÁTICO: Se ejecuta una sola vez al iniciar la app
        static ContextoGlobal()
        {
            CargarRegistrosDesdeDisco();
        }

        public static void GuardarRegistrosEnDisco()
        {
            try
            {
                string json = JsonConvert.SerializeObject(HistorialRegistros, Formatting.Indented);
                File.WriteAllText(RutaArchivo, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar historial: {ex.Message}");
            }
        }

        public static void CargarRegistrosDesdeDisco()
        {
            try
            {
                if (File.Exists(RutaArchivo))
                {
                    string json = File.ReadAllText(RutaArchivo);
                    HistorialRegistros = JsonConvert.DeserializeObject<List<RegistroBenchmark>>(json) ?? new List<RegistroBenchmark>();
                }
            }
            catch
            {
                // Si falla, iniciamos lista limpia para no crashear
                HistorialRegistros = new List<RegistroBenchmark>();
            }
        }
    }
}