using AlgorithmLab.Controlador;
using AlgorithmLab.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AlgorithmLab.Vista
{
    public partial class UCRecord : UserControl
    {
        public UCRecord()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            // Configuración visual para que se vea profesional
            dgvDetallesRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesRegistro.ReadOnly = true;
            dgvDetallesRegistro.AllowUserToAddRows = false;
            dgvDetallesRegistro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void RefrescarLista()
        {
            lstHistorialRegistros.DisplayMember = "";

            lstHistorialRegistros.DataSource = null;
            lstHistorialRegistros.DataSource = ContextoGlobal.HistorialRegistros;
        }

        private void lstHistorialRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccionado = lstHistorialRegistros.SelectedItem as RegistroBenchmark;
            if (seleccionado != null)
            {
                // Configurar Grid para modo "Clave-Valor"
                dgvDetallesRegistro.DataSource = null;
                dgvDetallesRegistro.Columns.Clear();
                dgvDetallesRegistro.Columns.Add("Campo", "Parámetro");
                dgvDetallesRegistro.Columns.Add("Valor", "Valor");

                // Llenar manualmente las filas
                dgvDetallesRegistro.Rows.Add("ID", seleccionado.Id);
                dgvDetallesRegistro.Rows.Add("Fecha", seleccionado.Fecha);
                dgvDetallesRegistro.Rows.Add("Tipo Operación", seleccionado.TipoOperacion);
                dgvDetallesRegistro.Rows.Add("Algoritmo", seleccionado.Algoritmo);
                dgvDetallesRegistro.Rows.Add("Tamaño Muestra", seleccionado.TamanoMuestra);
                dgvDetallesRegistro.Rows.Add("Tipo Dato", seleccionado.TipoDato);
                dgvDetallesRegistro.Rows.Add("Tiempo", seleccionado.TiempoEjecucion);
                dgvDetallesRegistro.Rows.Add("Memoria Pico", $"{seleccionado.MemoriaPicoBytes / 1024.0 / 1024.0:F2} MB");

                if (seleccionado.TipoOperacion == "Ordenamiento")
                {
                    dgvDetallesRegistro.Rows.Add("Intercambios", seleccionado.Iteraciones);
                }
                else // Búsqueda
                {
                    dgvDetallesRegistro.Rows.Add("Valor Buscado", seleccionado.ValorBuscado);
                    dgvDetallesRegistro.Rows.Add("Encontrado en Índice", seleccionado.IndiceEncontrado);
                    dgvDetallesRegistro.Rows.Add("Iteraciones/Saltos", seleccionado.Iteraciones);
                    dgvDetallesRegistro.Rows.Add("Incluyó Ordenamiento", seleccionado.SeOrdenoPreviamente ? "Sí" : "No");
                }

                // Estilo para que se vea bien
                dgvDetallesRegistro.AutoResizeColumns();
                dgvDetallesRegistro.ClearSelection();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvDetallesRegistro.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File|*.csv";
            sfd.FileName = $"Reporte_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder csv = new StringBuilder();

                    // 1. Encabezados
                    for (int i = 0; i < dgvDetallesRegistro.Columns.Count; i++)
                    {
                        csv.Append(dgvDetallesRegistro.Columns[i].HeaderText + ";");
                    }
                    csv.AppendLine();

                    // 2. Datos (Iteramos las filas del DataGrid)
                    foreach (DataGridViewRow row in dgvDetallesRegistro.Rows)
                    {
                        for (int i = 0; i < dgvDetallesRegistro.Columns.Count; i++)
                        {
                            // Manejo de nulos y comas en el texto
                            string valor = row.Cells[i].Value?.ToString() ?? "";
                            valor = valor.Replace(",", ";"); // Evitar romper el CSV
                            csv.Append(valor + ";");
                        }
                        csv.AppendLine();
                    }

                    File.WriteAllText(sfd.FileName, csv.ToString(), Encoding.UTF8);
                    MessageBox.Show("Archivo CSV generado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message);
                }
            }
        }

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("¿Estás seguro de borrar todo el historial de forma permanente?",
                                       "Confirmar Borrado",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                ContextoGlobal.HistorialRegistros.Clear();
                ContextoGlobal.GuardarRegistrosEnDisco(); // Guardar lista vacía limpia el archivo
                RefrescarLista();
                dgvDetallesRegistro.DataSource = null;
            }
            dgvDetallesRegistro.DataSource = null;
            this.Refresh();
        }

        private void UCRecord_Load(object sender, EventArgs e)
        {
            ContextoGlobal.CargarRegistrosDesdeDisco();

            lstHistorialRegistros.DataSource = null; // Limpiar enlace anterior
            lstHistorialRegistros.DataSource = ContextoGlobal.HistorialRegistros;
        }

        private void dgvDetallesRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}