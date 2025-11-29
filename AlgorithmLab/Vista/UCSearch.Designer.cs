namespace AlgorithmLab.Vista
{
    partial class UCSearch
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbValorBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbAlgoritmosBusqueda = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clbModoEjecucion = new System.Windows.Forms.CheckedListBox();
            this.btnIniciarBusqueda = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJump = new System.Windows.Forms.Label();
            this.pbProgresoJump = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pbProgresoInterpolada = new System.Windows.Forms.ProgressBar();
            this.formsPlotBusqueda = new ScottPlot.WinForms.FormsPlot();
            this.btnAbortar = new System.Windows.Forms.Button();
            this.lblInterpolada = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1532, 620);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.tbValorBusqueda);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.clbAlgoritmosBusqueda);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.clbModoEjecucion);
            this.flowLayoutPanel1.Controls.Add(this.btnIniciarBusqueda);
            this.flowLayoutPanel1.Controls.Add(this.btnAbortar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(453, 614);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 34);
            this.label7.TabIndex = 58;
            this.label7.Text = "Valor a buscar:";
            // 
            // tbValorBusqueda
            // 
            this.tbValorBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.tbValorBusqueda.Location = new System.Drawing.Point(10, 64);
            this.tbValorBusqueda.Margin = new System.Windows.Forms.Padding(10);
            this.tbValorBusqueda.Name = "tbValorBusqueda";
            this.tbValorBusqueda.Size = new System.Drawing.Size(380, 40);
            this.tbValorBusqueda.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(10, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 34);
            this.label1.TabIndex = 53;
            this.label1.Text = "Comparativa de búsqueda:";
            // 
            // clbAlgoritmosBusqueda
            // 
            this.clbAlgoritmosBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(78)))), ((int)(((byte)(71)))));
            this.clbAlgoritmosBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbAlgoritmosBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.clbAlgoritmosBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.clbAlgoritmosBusqueda.FormattingEnabled = true;
            this.clbAlgoritmosBusqueda.Items.AddRange(new object[] {
            "Jump Search",
            "Búsqueda Interpolada"});
            this.clbAlgoritmosBusqueda.Location = new System.Drawing.Point(10, 178);
            this.clbAlgoritmosBusqueda.Margin = new System.Windows.Forms.Padding(10);
            this.clbAlgoritmosBusqueda.Name = "clbAlgoritmosBusqueda";
            this.clbAlgoritmosBusqueda.Size = new System.Drawing.Size(252, 70);
            this.clbAlgoritmosBusqueda.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(10, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 34);
            this.label2.TabIndex = 55;
            this.label2.Text = "Modo:";
            // 
            // clbModoEjecucion
            // 
            this.clbModoEjecucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(78)))), ((int)(((byte)(71)))));
            this.clbModoEjecucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbModoEjecucion.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.clbModoEjecucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.clbModoEjecucion.FormattingEnabled = true;
            this.clbModoEjecucion.Items.AddRange(new object[] {
            "Gráfico en Vivo (más lento)",
            "Benchmark (máxima velocidad)"});
            this.clbModoEjecucion.Location = new System.Drawing.Point(10, 322);
            this.clbModoEjecucion.Margin = new System.Windows.Forms.Padding(10);
            this.clbModoEjecucion.Name = "clbModoEjecucion";
            this.clbModoEjecucion.Size = new System.Drawing.Size(334, 70);
            this.clbModoEjecucion.TabIndex = 56;
            // 
            // btnIniciarBusqueda
            // 
            this.btnIniciarBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.btnIniciarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnIniciarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.btnIniciarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnIniciarBusqueda.Location = new System.Drawing.Point(110, 412);
            this.btnIniciarBusqueda.Margin = new System.Windows.Forms.Padding(10);
            this.btnIniciarBusqueda.Name = "btnIniciarBusqueda";
            this.btnIniciarBusqueda.Size = new System.Drawing.Size(180, 56);
            this.btnIniciarBusqueda.TabIndex = 60;
            this.btnIniciarBusqueda.Text = "Iniciar";
            this.btnIniciarBusqueda.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.formsPlotBusqueda, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(462, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 614);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.lblJump);
            this.flowLayoutPanel2.Controls.Add(this.pbProgresoJump);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 371);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(527, 240);
            this.flowLayoutPanel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 34);
            this.label3.TabIndex = 35;
            this.label3.Text = "Jump Search";
            // 
            // lblJump
            // 
            this.lblJump.AutoSize = true;
            this.lblJump.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblJump.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJump.ForeColor = System.Drawing.Color.Lime;
            this.lblJump.Location = new System.Drawing.Point(10, 64);
            this.lblJump.Margin = new System.Windows.Forms.Padding(10);
            this.lblJump.Name = "lblJump";
            this.lblJump.Size = new System.Drawing.Size(405, 108);
            this.lblJump.TabIndex = 54;
            this.lblJump.Text = "Tiempo exacto (00:02:15.450)\r\nMemoria Pico: aaa\r\nSaltos realizados: aaa\r\nÍndice e" +
    "ncontrado: aa";
            // 
            // pbProgresoJump
            // 
            this.pbProgresoJump.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProgresoJump.Location = new System.Drawing.Point(10, 192);
            this.pbProgresoJump.Margin = new System.Windows.Forms.Padding(10);
            this.pbProgresoJump.Name = "pbProgresoJump";
            this.pbProgresoJump.Size = new System.Drawing.Size(405, 23);
            this.pbProgresoJump.TabIndex = 55;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.lblInterpolada);
            this.flowLayoutPanel3.Controls.Add(this.pbProgresoInterpolada);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(536, 371);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(528, 240);
            this.flowLayoutPanel3.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 34);
            this.label4.TabIndex = 35;
            this.label4.Text = "Búsqueda Interpolada";
            // 
            // pbProgresoInterpolada
            // 
            this.pbProgresoInterpolada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProgresoInterpolada.Location = new System.Drawing.Point(10, 192);
            this.pbProgresoInterpolada.Margin = new System.Windows.Forms.Padding(10);
            this.pbProgresoInterpolada.Name = "pbProgresoInterpolada";
            this.pbProgresoInterpolada.Size = new System.Drawing.Size(405, 23);
            this.pbProgresoInterpolada.TabIndex = 55;
            // 
            // formsPlotBusqueda
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.formsPlotBusqueda, 2);
            this.formsPlotBusqueda.DisplayScale = 0F;
            this.formsPlotBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotBusqueda.Location = new System.Drawing.Point(3, 3);
            this.formsPlotBusqueda.Name = "formsPlotBusqueda";
            this.formsPlotBusqueda.Size = new System.Drawing.Size(1061, 362);
            this.formsPlotBusqueda.TabIndex = 56;
            // 
            // btnAbortar
            // 
            this.btnAbortar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbortar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.btnAbortar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbortar.FlatAppearance.BorderSize = 0;
            this.btnAbortar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbortar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.btnAbortar.ForeColor = System.Drawing.Color.White;
            this.btnAbortar.Location = new System.Drawing.Point(110, 488);
            this.btnAbortar.Margin = new System.Windows.Forms.Padding(10);
            this.btnAbortar.Name = "btnAbortar";
            this.btnAbortar.Size = new System.Drawing.Size(180, 56);
            this.btnAbortar.TabIndex = 61;
            this.btnAbortar.Text = "Abortar";
            this.btnAbortar.UseVisualStyleBackColor = false;
            // 
            // lblInterpolada
            // 
            this.lblInterpolada.AutoSize = true;
            this.lblInterpolada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInterpolada.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterpolada.ForeColor = System.Drawing.Color.Lime;
            this.lblInterpolada.Location = new System.Drawing.Point(10, 64);
            this.lblInterpolada.Margin = new System.Windows.Forms.Padding(10);
            this.lblInterpolada.Name = "lblInterpolada";
            this.lblInterpolada.Size = new System.Drawing.Size(405, 108);
            this.lblInterpolada.TabIndex = 56;
            this.lblInterpolada.Text = "Tiempo exacto (00:02:15.450)\r\nMemoria Pico: aaa\r\nSaltos realizados: aaa\r\nÍndice e" +
    "ncontrado: aa";
            // 
            // UCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(78)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCSearch";
            this.Size = new System.Drawing.Size(1532, 620);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbValorBusqueda;
        private System.Windows.Forms.CheckedListBox clbModoEjecucion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbAlgoritmosBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarBusqueda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJump;
        private System.Windows.Forms.ProgressBar pbProgresoJump;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbProgresoInterpolada;
        private ScottPlot.WinForms.FormsPlot formsPlotBusqueda;
        private System.Windows.Forms.Button btnAbortar;
        private System.Windows.Forms.Label lblInterpolada;
    }
}
