namespace AlgorithmLab.Vista
{
    partial class UCRecord
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstHistorialRegistros = new System.Windows.Forms.ListBox();
            this.dgvDetallesRegistro = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLimpiarHistorial = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.05808F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.75577F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.01876F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.16739F));
            this.tableLayoutPanel1.Controls.Add(this.lstHistorialRegistros, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDetallesRegistro, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExportar, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLimpiarHistorial, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1532, 620);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lstHistorialRegistros
            // 
            this.lstHistorialRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHistorialRegistros.FormattingEnabled = true;
            this.lstHistorialRegistros.ItemHeight = 16;
            this.lstHistorialRegistros.Location = new System.Drawing.Point(347, 134);
            this.lstHistorialRegistros.Margin = new System.Windows.Forms.Padding(10);
            this.lstHistorialRegistros.Name = "lstHistorialRegistros";
            this.tableLayoutPanel1.SetRowSpan(this.lstHistorialRegistros, 3);
            this.lstHistorialRegistros.Size = new System.Drawing.Size(221, 352);
            this.lstHistorialRegistros.TabIndex = 52;
            // 
            // dgvDetallesRegistro
            // 
            this.dgvDetallesRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetallesRegistro.Location = new System.Drawing.Point(588, 134);
            this.dgvDetallesRegistro.Margin = new System.Windows.Forms.Padding(10);
            this.dgvDetallesRegistro.Name = "dgvDetallesRegistro";
            this.dgvDetallesRegistro.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dgvDetallesRegistro, 3);
            this.dgvDetallesRegistro.RowTemplate.Height = 24;
            this.dgvDetallesRegistro.Size = new System.Drawing.Size(623, 352);
            this.dgvDetallesRegistro.TabIndex = 53;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(1286, 158);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(180, 56);
            this.btnExportar.TabIndex = 54;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarHistorial
            // 
            this.btnLimpiarHistorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.btnLimpiarHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarHistorial.FlatAppearance.BorderSize = 0;
            this.btnLimpiarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarHistorial.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.btnLimpiarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarHistorial.Location = new System.Drawing.Point(1286, 282);
            this.btnLimpiarHistorial.Name = "btnLimpiarHistorial";
            this.btnLimpiarHistorial.Size = new System.Drawing.Size(180, 56);
            this.btnLimpiarHistorial.TabIndex = 55;
            this.btnLimpiarHistorial.Text = "Limpiar Historial";
            this.btnLimpiarHistorial.UseVisualStyleBackColor = false;
            // 
            // UCRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(78)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCRecord";
            this.Size = new System.Drawing.Size(1532, 620);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lstHistorialRegistros;
        private System.Windows.Forms.DataGridView dgvDetallesRegistro;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnLimpiarHistorial;
    }
}
