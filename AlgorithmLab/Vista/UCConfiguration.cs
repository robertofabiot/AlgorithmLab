using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using AlgorithmLab.Controlador;
using AlgorithmLab.Modelo;
using System.Windows.Forms;

namespace AlgorithmLab.Vista
{
    public partial class UCConfiguration : UserControl
    {
        private GeneradorController _generador;

        public UCConfiguration()
        {
            InitializeComponent();
            _generador = new GeneradorController();

            // Selecciones por defecto para evitar nulos
            cmbTamanoMuestra.SelectedIndex = 0;
            cmbTipoDato.SelectedIndex = 0;
            cmbDistribucion.SelectedIndex = 0;

        }

        private void btnGenerarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(cmbTamanoMuestra.Text); // Permite escribir valor manual
                string tipo = cmbTipoDato.Text;
                string dist = cmbDistribucion.Text;

                Cursor = Cursors.WaitCursor; // Feedback visual
                _generador.GenerarDatos(cantidad, tipo, dist);

                // Actualizar Grid Virtual
                dgvVistaPrevia.RowCount = 0; // Reset
                dgvVistaPrevia.RowCount = cantidad; // Esto dispara el modo virtual
                dgvVistaPrevia.Refresh();

                MessageBox.Show($"¡Éxito! {cantidad} datos generados en memoria RAM.");
                //MessageBox.Show($"DEBUG: dgvVistaPrevia.Rows.Count: {dgvVistaPrevia.Rows.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // EL TRUCO DE MAGIA: Solo pide el dato que se va a dibujar en pantalla
        private void DgvVistaPrevia_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (ContextoGlobal.DatosActuales != null && e.RowIndex < ContextoGlobal.DatosActuales.Datos.Length)
            {
                e.Value = ContextoGlobal.DatosActuales.Datos[e.RowIndex];
            }
        }
    }
}