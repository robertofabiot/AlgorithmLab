namespace AlgorithmLab.Vista
{
    partial class UCConfiguration
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoDato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTamanoMuestra = new System.Windows.Forms.ComboBox();
            this.btnGenerarDatos = new System.Windows.Forms.Button();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.cmbDistribucion = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoDato, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbTamanoMuestra, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerarDatos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvVistaPrevia, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbDistribucion, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1532, 620);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(202, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Distribución de datos:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(289, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo de datos:";
            // 
            // cmbTipoDato
            // 
            this.cmbTipoDato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoDato.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.cmbTipoDato.FormattingEnabled = true;
            this.cmbTipoDato.Items.AddRange(new object[] {
            "Entero",
            "Decimal",
            "Texto"});
            this.cmbTipoDato.Location = new System.Drawing.Point(462, 211);
            this.cmbTipoDato.Name = "cmbTipoDato";
            this.cmbTipoDato.Size = new System.Drawing.Size(453, 41);
            this.cmbTipoDato.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(190, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tamaño de la muestra:";
            // 
            // cmbTamanoMuestra
            // 
            this.cmbTamanoMuestra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTamanoMuestra.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.cmbTamanoMuestra.FormattingEnabled = true;
            this.cmbTamanoMuestra.Items.AddRange(new object[] {
            "500000",
            "1000000",
            "5000000"});
            this.cmbTamanoMuestra.Location = new System.Drawing.Point(462, 366);
            this.cmbTamanoMuestra.Name = "cmbTamanoMuestra";
            this.cmbTamanoMuestra.Size = new System.Drawing.Size(453, 41);
            this.cmbTamanoMuestra.TabIndex = 9;
            // 
            // btnGenerarDatos
            // 
            this.btnGenerarDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.btnGenerarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarDatos.FlatAppearance.BorderSize = 0;
            this.btnGenerarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarDatos.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.btnGenerarDatos.ForeColor = System.Drawing.Color.White;
            this.btnGenerarDatos.Location = new System.Drawing.Point(598, 514);
            this.btnGenerarDatos.Name = "btnGenerarDatos";
            this.btnGenerarDatos.Size = new System.Drawing.Size(180, 56);
            this.btnGenerarDatos.TabIndex = 14;
            this.btnGenerarDatos.Text = "Generar";
            this.btnGenerarDatos.UseVisualStyleBackColor = false;
            this.btnGenerarDatos.Click += new System.EventHandler(this.btnGenerarDatos_Click);
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(1000, 3);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dgvVistaPrevia, 3);
            this.dgvVistaPrevia.RowTemplate.Height = 24;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(449, 459);
            this.dgvVistaPrevia.TabIndex = 15;
            this.dgvVistaPrevia.VirtualMode = true;
            this.dgvVistaPrevia.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DgvVistaPrevia_CellValueNeeded);
            // 
            // cmbDistribucion
            // 
            this.cmbDistribucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDistribucion.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.cmbDistribucion.FormattingEnabled = true;
            this.cmbDistribucion.Items.AddRange(new object[] {
            "Aleatorio",
            "Ordenado",
            "Inverso"});
            this.cmbDistribucion.Location = new System.Drawing.Point(462, 56);
            this.cmbDistribucion.Name = "cmbDistribucion";
            this.cmbDistribucion.Size = new System.Drawing.Size(453, 41);
            this.cmbDistribucion.TabIndex = 13;
            // 
            // UCConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(78)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCConfiguration";
            this.Size = new System.Drawing.Size(1532, 620);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGenerarDatos;
        private System.Windows.Forms.ComboBox cmbDistribucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTamanoMuestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
    }
}
