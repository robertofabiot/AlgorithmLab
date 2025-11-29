namespace AlgorithmLab.Vista
{
    partial class UCSort
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.clbAlgoritmos = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clbModoEjecucion = new System.Windows.Forms.CheckedListBox();
            this.btnIniciarBenchmark = new System.Windows.Forms.Button();
            this.btnAbortar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMerge = new System.Windows.Forms.Label();
            this.pbProgresoMerge = new System.Windows.Forms.ProgressBar();
            this.formsPlotOrdenamiento = new ScottPlot.WinForms.FormsPlot();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.pbProgresoSelection = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1532, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.clbAlgoritmos);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.clbModoEjecucion);
            this.flowLayoutPanel1.Controls.Add(this.btnIniciarBenchmark);
            this.flowLayoutPanel1.Controls.Add(this.btnAbortar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(453, 614);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "Algoritmo:";
            // 
            // clbAlgoritmos
            // 
            this.clbAlgoritmos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(78)))), ((int)(((byte)(71)))));
            this.clbAlgoritmos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbAlgoritmos.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.clbAlgoritmos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.clbAlgoritmos.FormattingEnabled = true;
            this.clbAlgoritmos.Items.AddRange(new object[] {
            "Selection Sort",
            "Merge Sort"});
            this.clbAlgoritmos.Location = new System.Drawing.Point(10, 64);
            this.clbAlgoritmos.Margin = new System.Windows.Forms.Padding(10);
            this.clbAlgoritmos.Name = "clbAlgoritmos";
            this.clbAlgoritmos.Size = new System.Drawing.Size(251, 70);
            this.clbAlgoritmos.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(10, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 34);
            this.label2.TabIndex = 32;
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
            this.clbModoEjecucion.Location = new System.Drawing.Point(10, 208);
            this.clbModoEjecucion.Margin = new System.Windows.Forms.Padding(10);
            this.clbModoEjecucion.Name = "clbModoEjecucion";
            this.clbModoEjecucion.Size = new System.Drawing.Size(334, 70);
            this.clbModoEjecucion.TabIndex = 33;
            // 
            // btnIniciarBenchmark
            // 
            this.btnIniciarBenchmark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarBenchmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.btnIniciarBenchmark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarBenchmark.FlatAppearance.BorderSize = 0;
            this.btnIniciarBenchmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarBenchmark.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.btnIniciarBenchmark.ForeColor = System.Drawing.Color.White;
            this.btnIniciarBenchmark.Location = new System.Drawing.Point(87, 298);
            this.btnIniciarBenchmark.Margin = new System.Windows.Forms.Padding(10);
            this.btnIniciarBenchmark.Name = "btnIniciarBenchmark";
            this.btnIniciarBenchmark.Size = new System.Drawing.Size(180, 56);
            this.btnIniciarBenchmark.TabIndex = 34;
            this.btnIniciarBenchmark.Text = "Iniciar";
            this.btnIniciarBenchmark.UseVisualStyleBackColor = false;
            this.btnIniciarBenchmark.Click += new System.EventHandler(this.btnIniciarBenchmark_Click);
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
            this.btnAbortar.Location = new System.Drawing.Point(87, 374);
            this.btnAbortar.Margin = new System.Windows.Forms.Padding(10);
            this.btnAbortar.Name = "btnAbortar";
            this.btnAbortar.Size = new System.Drawing.Size(180, 56);
            this.btnAbortar.TabIndex = 35;
            this.btnAbortar.Text = "Abortar";
            this.btnAbortar.UseVisualStyleBackColor = false;
            this.btnAbortar.Click += new System.EventHandler(this.btnAbortar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.formsPlotOrdenamiento, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(462, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 614);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.lblMerge);
            this.flowLayoutPanel3.Controls.Add(this.pbProgresoMerge);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(536, 371);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(528, 240);
            this.flowLayoutPanel3.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 34);
            this.label8.TabIndex = 56;
            this.label8.Text = "Merge Sort";
            // 
            // lblMerge
            // 
            this.lblMerge.AutoSize = true;
            this.lblMerge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMerge.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerge.ForeColor = System.Drawing.Color.Lime;
            this.lblMerge.Location = new System.Drawing.Point(10, 64);
            this.lblMerge.Margin = new System.Windows.Forms.Padding(10);
            this.lblMerge.Name = "lblMerge";
            this.lblMerge.Size = new System.Drawing.Size(450, 99);
            this.lblMerge.TabIndex = 57;
            this.lblMerge.Text = "Tiempo exacto (00:02:15.450)\r\nMemoria Pico: aaa\r\nIntercambios realizados: aaaa";
            // 
            // pbProgresoMerge
            // 
            this.pbProgresoMerge.Location = new System.Drawing.Point(10, 183);
            this.pbProgresoMerge.Margin = new System.Windows.Forms.Padding(10);
            this.pbProgresoMerge.Name = "pbProgresoMerge";
            this.pbProgresoMerge.Size = new System.Drawing.Size(405, 23);
            this.pbProgresoMerge.TabIndex = 56;
            // 
            // formsPlotOrdenamiento
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.formsPlotOrdenamiento, 2);
            this.formsPlotOrdenamiento.DisplayScale = 0F;
            this.formsPlotOrdenamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotOrdenamiento.Location = new System.Drawing.Point(3, 3);
            this.formsPlotOrdenamiento.Name = "formsPlotOrdenamiento";
            this.formsPlotOrdenamiento.Size = new System.Drawing.Size(1061, 362);
            this.formsPlotOrdenamiento.TabIndex = 31;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.lblSelection);
            this.flowLayoutPanel2.Controls.Add(this.pbProgresoSelection);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 371);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(527, 240);
            this.flowLayoutPanel2.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 34);
            this.label7.TabIndex = 35;
            this.label7.Text = "Selection Sort";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSelection.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.ForeColor = System.Drawing.Color.Lime;
            this.lblSelection.Location = new System.Drawing.Point(10, 64);
            this.lblSelection.Margin = new System.Windows.Forms.Padding(10);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(450, 99);
            this.lblSelection.TabIndex = 54;
            this.lblSelection.Text = "Tiempo exacto (00:02:15.450)\r\nMemoria Pico: aaa\r\nIntercambios realizados: aaaa";
            // 
            // pbProgresoSelection
            // 
            this.pbProgresoSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProgresoSelection.Location = new System.Drawing.Point(32, 183);
            this.pbProgresoSelection.Margin = new System.Windows.Forms.Padding(10);
            this.pbProgresoSelection.Name = "pbProgresoSelection";
            this.pbProgresoSelection.Size = new System.Drawing.Size(405, 23);
            this.pbProgresoSelection.TabIndex = 55;
            // 
            // UCSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(78)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCSort";
            this.Size = new System.Drawing.Size(1532, 620);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbAlgoritmos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbModoEjecucion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ScottPlot.WinForms.FormsPlot formsPlotOrdenamiento;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ProgressBar pbProgresoSelection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblMerge;
        private System.Windows.Forms.ProgressBar pbProgresoMerge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIniciarBenchmark;
        private System.Windows.Forms.Button btnAbortar;
    }
}
