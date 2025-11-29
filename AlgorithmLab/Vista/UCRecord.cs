using AlgorithmLab.Controlador;
using AlgorithmLab.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AlgorithmLab.Vista
{
    public partial class UCRecord : UserControl
    {
        public UCRecord()
        {
            InitializeComponent();
            // Configuración visual del DataGrid para que se vea bien
            dgvDetallesRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesRegistro.ReadOnly = true;
            dgvDetallesRegistro.AllowUserToAddRows = false;
        }

        // Se ejecuta cada vez que se muestra el control (si lo añades al Load en el Designer)
        // O puedes llamarlo desde el constructor si prefieres.
        private void UCRecord_Load(object sender, EventArgs e)
        {
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            ContextoGlobal.CargarRegistrosDesdeDisco();
            lstHistorialRegistros.DataSource = null; // Reset
            lstHistorialRegistros.DataSource = ContextoGlobal.HistorialRegistros;
            // Usamos el ToString() override de la clase, o definimos una propiedad Display
            // Pero como pusimos el override en el Modelo, se verá bonito automáticamente.
        }

        private void lstHistorialRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccionado = lstHistorialRegistros.SelectedItem as RegistroBenchmark;
            if (seleccionado != null)
            {
                // Mostramos todos los detalles en el Grid usando una lista de 1 elemento
                // Esto es un truco rápido para mostrar las propiedades del objeto en columnas
                dgvDetallesRegistro.DataSource = new List<RegistroBenchmark> { seleccionado };
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON File|*.json|Text File|*.txt";
            sfd.FileName = $"Reporte_AlgorithmLab_{DateTime.Now:yyyyMMdd}.json";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(ContextoGlobal.HistorialRegistros, Formatting.Indented);
                    File.WriteAllText(sfd.FileName, json);
                    MessageBox.Show("Historial exportado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message);
                }
            }
        }

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("¿Estás seguro de borrar todo el historial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                ContextoGlobal.HistorialRegistros.Clear();
                ContextoGlobal.GuardarRegistrosEnDisco();
                RefrescarLista();
                dgvDetallesRegistro.DataSource = null;
            }
        }

        // Para asegurarnos de que cargue al cambiar de pestaña en el Main
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible) RefrescarLista();
        }
    }
}