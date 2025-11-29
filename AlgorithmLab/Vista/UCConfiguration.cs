using System;
using System.Windows.Forms;
using AlgorithmLab.Controlador;
using AlgorithmLab.Modelo;

namespace AlgorithmLab.Vista
{
    public partial class UCConfiguration : UserControl
    {
        private GeneradorController _generador;

        public UCConfiguration()
        {
            InitializeComponent();
            _generador = new GeneradorController();

            // Configuración de Combos (Valores por defecto)
            // Nota: Asegúrate de que los Items estén llenos (ya sea por Designer o aquí)
            if (cmbTamanoMuestra.Items.Count > 0) cmbTamanoMuestra.SelectedIndex = 0;
            if (cmbTipoDato.Items.Count > 0) cmbTipoDato.SelectedIndex = 0;
            if (cmbDistribucion.Items.Count > 0) cmbDistribucion.SelectedIndex = 0;

            // --- CORRECCIÓN AQUÍ ---
            // Al abrir esta vista, verificamos si ya existen datos en la memoria global.
            // Si existen, le decimos al DataGridView que se pinte.
            if (ContextoGlobal.DatosActuales != null && ContextoGlobal.DatosActuales.Datos != null)
            {
                // Restauramos la cantidad de filas para que el Modo Virtual funcione
                dgvVistaPrevia.RowCount = ContextoGlobal.DatosActuales.Datos.Length;

                // Opcional: Restaurar los valores de los combobox para que coincidan con los datos actuales
                // (Esto es puramente visual para que el usuario sepa qué tiene cargado)
                cmbTipoDato.SelectedItem = ContextoGlobal.DatosActuales.TipoDato;
                if (ContextoGlobal.DatosActuales.EstaOrdenado) cmbDistribucion.Text = "Ordenado";
            }
        }

        private void btnGenerarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación básica
                if (string.IsNullOrEmpty(cmbTamanoMuestra.Text)) return;

                int cantidad = int.Parse(cmbTamanoMuestra.Text);
                string tipo = cmbTipoDato.Text;
                string dist = cmbDistribucion.Text;

                Cursor = Cursors.WaitCursor;

                // Generamos y guardamos en el ContextoGlobal
                _generador.GenerarDatos(cantidad, tipo, dist);

                // Actualizar Grid Virtual
                dgvVistaPrevia.RowCount = 0; // Reset necesario para refrescar si cambia el tamaño
                dgvVistaPrevia.RowCount = cantidad; // Esto dispara el evento CellValueNeeded
                dgvVistaPrevia.Invalidate(); // Fuerza el repintado

                MessageBox.Show($"¡Éxito! {cantidad} datos generados en memoria RAM.");
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
        // Este evento se dispara automáticamente cuando la grilla necesita pintar una celda
        private void DgvVistaPrevia_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            // Protección contra nulos y rangos fuera de límite
            if (ContextoGlobal.DatosActuales != null &&
                ContextoGlobal.DatosActuales.Datos != null &&
                e.RowIndex < ContextoGlobal.DatosActuales.Datos.Length)
            {
                e.Value = ContextoGlobal.DatosActuales.Datos[e.RowIndex];
            }
        }
    }
}