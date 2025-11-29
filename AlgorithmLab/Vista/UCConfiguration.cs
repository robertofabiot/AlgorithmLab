using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmLab.Vista
{
    public partial class UCConfiguration : UserControl
    {
        public UCConfiguration()
        {
            InitializeComponent();
                  
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            //// Windows nos pide: "¿Qué pongo en la fila X, columna Y?"
            //if (e.RowIndex < misDatos.Count)
            //{
            //    // Solo buscamos ese dato específico en la memoria. ¡O(1)!
            //    e.Value = misDatos[e.RowIndex];
            //}
        }
    }
}
