namespace CeluCenter.Vistas
{
    partial class Nuevaventa_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevaventa_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.ci_txt = new System.Windows.Forms.TextBox();
            this.nventa_txt = new System.Windows.Forms.TextBox();
            this.totalventa_txt = new System.Windows.Forms.TextBox();
            this.subtotal_txt = new System.Windows.Forms.TextBox();
            this.punitario_txt = new System.Windows.Forms.TextBox();
            this.cantidad_txt = new System.Windows.Forms.TextBox();
            this.producto_combo = new System.Windows.Forms.ComboBox();
            this.ncliente_btn = new System.Windows.Forms.Button();
            this.anadir_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.imprimir_btn = new System.Windows.Forms.Button();
            this.aceptar_btn = new System.Windows.Forms.Button();
            this.detalle_tabla = new System.Windows.Forms.DataGridView();
            this.celuCenterDetalle = new CeluCenter.CeluCenterDetalle();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalle_VentaTableAdapter = new CeluCenter.CeluCenterDetalleTableAdapters.Detalle_VentaTableAdapter();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.cancelar_btn);
            this.splitContainer1.Panel1.Controls.Add(this.totalventa_txt);
            this.splitContainer1.Panel1.Controls.Add(this.nventa_txt);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detalle_tabla);
            this.splitContainer1.Panel2.Controls.Add(this.imprimir_btn);
            this.splitContainer1.Panel2.Controls.Add(this.aceptar_btn);
            this.splitContainer1.Panel2.Controls.Add(this.anadir_btn);
            this.splitContainer1.Panel2.Controls.Add(this.producto_combo);
            this.splitContainer1.Panel2.Controls.Add(this.cantidad_txt);
            this.splitContainer1.Panel2.Controls.Add(this.punitario_txt);
            this.splitContainer1.Panel2.Controls.Add(this.subtotal_txt);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(984, 561);
            this.splitContainer1.SplitterDistance = 338;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DE\r\nLA VENTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "DETALLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ncliente_btn);
            this.groupBox1.Controls.Add(this.ci_txt);
            this.groupBox1.Controls.Add(this.nombre_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "CI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nro. venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha venta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cantidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "P/Unitario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Subtotal:";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(114, 39);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(167, 30);
            this.nombre_txt.TabIndex = 2;
            // 
            // ci_txt
            // 
            this.ci_txt.Enabled = false;
            this.ci_txt.Location = new System.Drawing.Point(114, 77);
            this.ci_txt.Name = "ci_txt";
            this.ci_txt.Size = new System.Drawing.Size(167, 30);
            this.ci_txt.TabIndex = 3;
            // 
            // nventa_txt
            // 
            this.nventa_txt.Enabled = false;
            this.nventa_txt.Location = new System.Drawing.Point(148, 345);
            this.nventa_txt.Name = "nventa_txt";
            this.nventa_txt.Size = new System.Drawing.Size(167, 30);
            this.nventa_txt.TabIndex = 4;
            // 
            // totalventa_txt
            // 
            this.totalventa_txt.Enabled = false;
            this.totalventa_txt.Location = new System.Drawing.Point(148, 437);
            this.totalventa_txt.Name = "totalventa_txt";
            this.totalventa_txt.Size = new System.Drawing.Size(167, 30);
            this.totalventa_txt.TabIndex = 6;
            // 
            // subtotal_txt
            // 
            this.subtotal_txt.Enabled = false;
            this.subtotal_txt.Location = new System.Drawing.Point(385, 176);
            this.subtotal_txt.Name = "subtotal_txt";
            this.subtotal_txt.Size = new System.Drawing.Size(125, 30);
            this.subtotal_txt.TabIndex = 9;
            // 
            // punitario_txt
            // 
            this.punitario_txt.Enabled = false;
            this.punitario_txt.Location = new System.Drawing.Point(385, 120);
            this.punitario_txt.Name = "punitario_txt";
            this.punitario_txt.Size = new System.Drawing.Size(125, 30);
            this.punitario_txt.TabIndex = 10;
            // 
            // cantidad_txt
            // 
            this.cantidad_txt.Location = new System.Drawing.Point(124, 176);
            this.cantidad_txt.Name = "cantidad_txt";
            this.cantidad_txt.Size = new System.Drawing.Size(125, 30);
            this.cantidad_txt.TabIndex = 11;
            // 
            // producto_combo
            // 
            this.producto_combo.FormattingEnabled = true;
            this.producto_combo.Location = new System.Drawing.Point(124, 120);
            this.producto_combo.Name = "producto_combo";
            this.producto_combo.Size = new System.Drawing.Size(125, 29);
            this.producto_combo.TabIndex = 12;
            // 
            // ncliente_btn
            // 
            this.ncliente_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ncliente_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.ncliente_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ncliente_btn.Location = new System.Drawing.Point(76, 126);
            this.ncliente_btn.Name = "ncliente_btn";
            this.ncliente_btn.Size = new System.Drawing.Size(147, 45);
            this.ncliente_btn.TabIndex = 13;
            this.ncliente_btn.Text = "Nuevo cliente";
            this.ncliente_btn.UseVisualStyleBackColor = true;
            this.ncliente_btn.Click += new System.EventHandler(this.ncliente_btn_Click);
            // 
            // anadir_btn
            // 
            this.anadir_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anadir_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.anadir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anadir_btn.Location = new System.Drawing.Point(523, 137);
            this.anadir_btn.Name = "anadir_btn";
            this.anadir_btn.Size = new System.Drawing.Size(98, 54);
            this.anadir_btn.TabIndex = 15;
            this.anadir_btn.Text = "Añadir";
            this.anadir_btn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 391);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 30);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_btn.Image = ((System.Drawing.Image)(resources.GetObject("cancelar_btn.Image")));
            this.cancelar_btn.Location = new System.Drawing.Point(88, 494);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(147, 44);
            this.cancelar_btn.TabIndex = 14;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // imprimir_btn
            // 
            this.imprimir_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imprimir_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.imprimir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimir_btn.Image = ((System.Drawing.Image)(resources.GetObject("imprimir_btn.Image")));
            this.imprimir_btn.Location = new System.Drawing.Point(385, 494);
            this.imprimir_btn.Name = "imprimir_btn";
            this.imprimir_btn.Size = new System.Drawing.Size(191, 44);
            this.imprimir_btn.TabIndex = 16;
            this.imprimir_btn.Text = "Imprimir recibo";
            this.imprimir_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imprimir_btn.UseVisualStyleBackColor = true;
            // 
            // aceptar_btn
            // 
            this.aceptar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aceptar_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.aceptar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar_btn.Image = ((System.Drawing.Image)(resources.GetObject("aceptar_btn.Image")));
            this.aceptar_btn.Location = new System.Drawing.Point(94, 494);
            this.aceptar_btn.Name = "aceptar_btn";
            this.aceptar_btn.Size = new System.Drawing.Size(176, 44);
            this.aceptar_btn.TabIndex = 15;
            this.aceptar_btn.Text = " Aceptar venta";
            this.aceptar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aceptar_btn.UseVisualStyleBackColor = true;
            // 
            // detalle_tabla
            // 
            this.detalle_tabla.AllowUserToAddRows = false;
            this.detalle_tabla.AllowUserToDeleteRows = false;
            this.detalle_tabla.AllowUserToOrderColumns = true;
            this.detalle_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalle_tabla.AutoGenerateColumns = false;
            this.detalle_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detalle_tabla.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detalle_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalle_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subTotalDataGridViewTextBoxColumn,
            this.cantidadVentaDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.productoCodigoDataGridViewTextBoxColumn});
            this.detalle_tabla.DataSource = this.detalleVentaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detalle_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.detalle_tabla.Location = new System.Drawing.Point(25, 237);
            this.detalle_tabla.Name = "detalle_tabla";
            this.detalle_tabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detalle_tabla.Size = new System.Drawing.Size(596, 230);
            this.detalle_tabla.TabIndex = 17;
            // 
            // celuCenterDetalle
            // 
            this.celuCenterDetalle.DataSetName = "CeluCenterDetalle";
            this.celuCenterDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "Detalle_Venta";
            this.detalleVentaBindingSource.DataSource = this.celuCenterDetalle;
            // 
            // detalle_VentaTableAdapter
            // 
            this.detalle_VentaTableAdapter.ClearBeforeFill = true;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "Sub_Total";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "Sub Total";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadVentaDataGridViewTextBoxColumn
            // 
            this.cantidadVentaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Venta";
            this.cantidadVentaDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadVentaDataGridViewTextBoxColumn.Name = "cantidadVentaDataGridViewTextBoxColumn";
            this.cantidadVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoCodigoDataGridViewTextBoxColumn
            // 
            this.productoCodigoDataGridViewTextBoxColumn.DataPropertyName = "Producto_Codigo";
            this.productoCodigoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoCodigoDataGridViewTextBoxColumn.Name = "productoCodigoDataGridViewTextBoxColumn";
            this.productoCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nuevaventa_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Nuevaventa_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CELUCENTER - Nueva venta";
            this.Load += new System.EventHandler(this.Nuevaventa_form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.TextBox totalventa_txt;
        private System.Windows.Forms.TextBox nventa_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ncliente_btn;
        private System.Windows.Forms.TextBox ci_txt;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button anadir_btn;
        private System.Windows.Forms.ComboBox producto_combo;
        private System.Windows.Forms.TextBox cantidad_txt;
        private System.Windows.Forms.TextBox punitario_txt;
        private System.Windows.Forms.TextBox subtotal_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button imprimir_btn;
        private System.Windows.Forms.Button aceptar_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView detalle_tabla;
        private CeluCenterDetalle celuCenterDetalle;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private CeluCenterDetalleTableAdapters.Detalle_VentaTableAdapter detalle_VentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoCodigoDataGridViewTextBoxColumn;
    }
}