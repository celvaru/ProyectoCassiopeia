namespace CeluCenter.Vistas
{
    partial class Reportes_form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.volver_btn = new System.Windows.Forms.Button();
            this.imprimir_btn = new System.Windows.Forms.Button();
            this.reporte_tabla = new System.Windows.Forms.DataGridView();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganancias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.celuCenterDataSetVentas = new CeluCenter.CeluCenterDataSetVentas();
            this.celuCenterDataSetVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masvendidos_tabla = new System.Windows.Forms.DataGridView();
            this.celuCenterDataSet1 = new CeluCenter.CeluCenterDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSetVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSetVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masvendidos_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERADOR DE REPORTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha reporte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Intervalo\r\nde datos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 128);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Semanal",
            "Mensual"});
            this.comboBox1.Location = new System.Drawing.Point(598, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 29);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Seleccione";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(374, 128);
            this.dateTimePicker2.MaxDate = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 26);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(183, 81);
            this.dateTimePicker3.MaxDate = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            this.dateTimePicker3.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(111, 26);
            this.dateTimePicker3.TabIndex = 9;
            this.dateTimePicker3.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // volver_btn
            // 
            this.volver_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volver_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.volver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volver_btn.Image = ((System.Drawing.Image)(resources.GetObject("volver_btn.Image")));
            this.volver_btn.Location = new System.Drawing.Point(507, 484);
            this.volver_btn.Name = "volver_btn";
            this.volver_btn.Size = new System.Drawing.Size(136, 47);
            this.volver_btn.TabIndex = 11;
            this.volver_btn.Text = "  Volver";
            this.volver_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.volver_btn.UseVisualStyleBackColor = true;
            this.volver_btn.Click += new System.EventHandler(this.volver_btn_Click);
            // 
            // imprimir_btn
            // 
            this.imprimir_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imprimir_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.imprimir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimir_btn.Image = ((System.Drawing.Image)(resources.GetObject("imprimir_btn.Image")));
            this.imprimir_btn.Location = new System.Drawing.Point(75, 484);
            this.imprimir_btn.Name = "imprimir_btn";
            this.imprimir_btn.Size = new System.Drawing.Size(203, 47);
            this.imprimir_btn.TabIndex = 10;
            this.imprimir_btn.Text = "Imprimir reporte";
            this.imprimir_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imprimir_btn.UseVisualStyleBackColor = true;
            // 
            // reporte_tabla
            // 
            this.reporte_tabla.AllowUserToAddRows = false;
            this.reporte_tabla.AllowUserToDeleteRows = false;
            this.reporte_tabla.AllowUserToOrderColumns = true;
            this.reporte_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reporte_tabla.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reporte_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reporte_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporte_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodo,
            this.ingresos,
            this.egresos,
            this.ganancias});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reporte_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.reporte_tabla.Location = new System.Drawing.Point(16, 194);
            this.reporte_tabla.Name = "reporte_tabla";
            this.reporte_tabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reporte_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.reporte_tabla.Size = new System.Drawing.Size(368, 273);
            this.reporte_tabla.TabIndex = 12;
            // 
            // periodo
            // 
            this.periodo.HeaderText = "Semana/Mes";
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            // 
            // ingresos
            // 
            this.ingresos.HeaderText = "Ingresos";
            this.ingresos.Name = "ingresos";
            this.ingresos.ReadOnly = true;
            // 
            // egresos
            // 
            this.egresos.HeaderText = "Egresos";
            this.egresos.Name = "egresos";
            this.egresos.ReadOnly = true;
            // 
            // ganancias
            // 
            this.ganancias.HeaderText = "Ganancias";
            this.ganancias.Name = "ganancias";
            this.ganancias.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.masvendidos_tabla);
            this.groupBox1.Location = new System.Drawing.Point(406, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 273);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Celulares más vendidos";
            // 
            // celuCenterDataSetVentas
            // 
            this.celuCenterDataSetVentas.DataSetName = "CeluCenterDataSetVentas";
            this.celuCenterDataSetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celuCenterDataSetVentasBindingSource
            // 
            this.celuCenterDataSetVentasBindingSource.DataSource = this.celuCenterDataSetVentas;
            this.celuCenterDataSetVentasBindingSource.Position = 0;
            // 
            // masvendidos_tabla
            // 
            this.masvendidos_tabla.AllowUserToAddRows = false;
            this.masvendidos_tabla.AllowUserToDeleteRows = false;
            this.masvendidos_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masvendidos_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.masvendidos_tabla.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masvendidos_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.masvendidos_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.masvendidos_tabla.DefaultCellStyle = dataGridViewCellStyle5;
            this.masvendidos_tabla.Location = new System.Drawing.Point(17, 29);
            this.masvendidos_tabla.Name = "masvendidos_tabla";
            this.masvendidos_tabla.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masvendidos_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.masvendidos_tabla.Size = new System.Drawing.Size(272, 221);
            this.masvendidos_tabla.TabIndex = 0;
            // 
            // celuCenterDataSet1
            // 
            this.celuCenterDataSet1.DataSetName = "CeluCenterDataSet";
            this.celuCenterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reportes_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reporte_tabla);
            this.Controls.Add(this.volver_btn);
            this.Controls.Add(this.imprimir_btn);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "Reportes_form";
            this.Text = "CELUCENTER - Generador de reportes";
            ((System.ComponentModel.ISupportInitialize)(this.reporte_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSetVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSetVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masvendidos_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button imprimir_btn;
        private System.Windows.Forms.Button volver_btn;
        private System.Windows.Forms.DataGridView reporte_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn egresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancias;
        private System.Windows.Forms.BindingSource celuCenterDataSetVentasBindingSource;
        private CeluCenterDataSetVentas celuCenterDataSetVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView masvendidos_tabla;
        private CeluCenterDataSet celuCenterDataSet1;
    }
}