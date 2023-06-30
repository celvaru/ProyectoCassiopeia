namespace CeluCenter.Vistas
{
    partial class Inventario_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario_form));
            this.hventas_btn = new System.Windows.Forms.Button();
            this.inventario_btn = new System.Windows.Forms.Button();
            this.gusuario_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inventario_tabla = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDispDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celuInventario = new CeluCenter.CeluInventario();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.garantia_txt = new System.Windows.Forms.TextBox();
            this.marca_txt = new System.Windows.Forms.TextBox();
            this.ram_txt = new System.Windows.Forms.TextBox();
            this.color_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bateria_txt = new System.Windows.Forms.TextBox();
            this.camara_txt = new System.Windows.Forms.TextBox();
            this.modelo_txt = new System.Windows.Forms.TextBox();
            this.codigo_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hcompras_btn = new System.Windows.Forms.Button();
            this.celuCenterInventario = new CeluCenter.CeluCenterInventario();
            this.celuCenterInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celuCenterInventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoesTableAdapter = new CeluCenter.CeluInventarioTableAdapters.ProductoesTableAdapter();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.limpiar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.nuevo_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.Button();
            this.cerrarsesion_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterInventarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // hventas_btn
            // 
            this.hventas_btn.AutoSize = true;
            this.hventas_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.hventas_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hventas_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hventas_btn.FlatAppearance.BorderSize = 0;
            this.hventas_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.hventas_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.hventas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hventas_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hventas_btn.Location = new System.Drawing.Point(7, 74);
            this.hventas_btn.Name = "hventas_btn";
            this.hventas_btn.Size = new System.Drawing.Size(205, 43);
            this.hventas_btn.TabIndex = 40;
            this.hventas_btn.Text = "Historial de ventas";
            this.hventas_btn.UseVisualStyleBackColor = false;
            this.hventas_btn.Click += new System.EventHandler(this.hventas_btn_Click);
            // 
            // inventario_btn
            // 
            this.inventario_btn.AutoSize = true;
            this.inventario_btn.BackColor = System.Drawing.Color.Gold;
            this.inventario_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventario_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventario_btn.FlatAppearance.BorderSize = 0;
            this.inventario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.inventario_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.inventario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventario_btn.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventario_btn.Location = new System.Drawing.Point(7, 123);
            this.inventario_btn.Name = "inventario_btn";
            this.inventario_btn.Size = new System.Drawing.Size(205, 43);
            this.inventario_btn.TabIndex = 37;
            this.inventario_btn.Text = "Inventario";
            this.inventario_btn.UseVisualStyleBackColor = false;
            // 
            // gusuario_btn
            // 
            this.gusuario_btn.AutoSize = true;
            this.gusuario_btn.BackColor = System.Drawing.Color.LightGreen;
            this.gusuario_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gusuario_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gusuario_btn.FlatAppearance.BorderSize = 0;
            this.gusuario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.gusuario_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.gusuario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gusuario_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gusuario_btn.Location = new System.Drawing.Point(7, 172);
            this.gusuario_btn.Name = "gusuario_btn";
            this.gusuario_btn.Size = new System.Drawing.Size(205, 43);
            this.gusuario_btn.TabIndex = 36;
            this.gusuario_btn.Text = "Gestionar usuarios";
            this.gusuario_btn.UseVisualStyleBackColor = false;
            this.gusuario_btn.Click += new System.EventHandler(this.gusuario_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(209, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 537);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.inventario_tabla);
            this.panel2.Controls.Add(this.eliminar_btn);
            this.panel2.Controls.Add(this.limpiar_btn);
            this.panel2.Controls.Add(this.modificar_btn);
            this.panel2.Controls.Add(this.nuevo_btn);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.garantia_txt);
            this.panel2.Controls.Add(this.marca_txt);
            this.panel2.Controls.Add(this.ram_txt);
            this.panel2.Controls.Add(this.color_txt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.bateria_txt);
            this.panel2.Controls.Add(this.camara_txt);
            this.panel2.Controls.Add(this.modelo_txt);
            this.panel2.Controls.Add(this.codigo_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buscar_btn);
            this.panel2.Controls.Add(this.buscar_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(31, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 512);
            this.panel2.TabIndex = 0;
            // 
            // inventario_tabla
            // 
            this.inventario_tabla.AllowUserToAddRows = false;
            this.inventario_tabla.AllowUserToDeleteRows = false;
            this.inventario_tabla.AllowUserToOrderColumns = true;
            this.inventario_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventario_tabla.AutoGenerateColumns = false;
            this.inventario_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.inventario_tabla.BackgroundColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventario_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventario_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventario_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.bateriaDataGridViewTextBoxColumn,
            this.camaraDataGridViewTextBoxColumn,
            this.cantidadDispDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.dimensionesDataGridViewTextBoxColumn,
            this.garantiaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.memoriaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.ramDataGridViewTextBoxColumn});
            this.inventario_tabla.DataSource = this.productoesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventario_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.inventario_tabla.Location = new System.Drawing.Point(20, 300);
            this.inventario_tabla.Name = "inventario_tabla";
            this.inventario_tabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventario_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inventario_tabla.Size = new System.Drawing.Size(835, 195);
            this.inventario_tabla.TabIndex = 37;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 101;
            // 
            // bateriaDataGridViewTextBoxColumn
            // 
            this.bateriaDataGridViewTextBoxColumn.DataPropertyName = "Bateria";
            this.bateriaDataGridViewTextBoxColumn.HeaderText = "Batería";
            this.bateriaDataGridViewTextBoxColumn.Name = "bateriaDataGridViewTextBoxColumn";
            this.bateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.bateriaDataGridViewTextBoxColumn.Width = 97;
            // 
            // camaraDataGridViewTextBoxColumn
            // 
            this.camaraDataGridViewTextBoxColumn.DataPropertyName = "Camara";
            this.camaraDataGridViewTextBoxColumn.HeaderText = "Cámara";
            this.camaraDataGridViewTextBoxColumn.Name = "camaraDataGridViewTextBoxColumn";
            this.camaraDataGridViewTextBoxColumn.ReadOnly = true;
            this.camaraDataGridViewTextBoxColumn.Width = 103;
            // 
            // cantidadDispDataGridViewTextBoxColumn
            // 
            this.cantidadDispDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Disp";
            this.cantidadDispDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDispDataGridViewTextBoxColumn.Name = "cantidadDispDataGridViewTextBoxColumn";
            this.cantidadDispDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDispDataGridViewTextBoxColumn.Width = 116;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 85;
            // 
            // dimensionesDataGridViewTextBoxColumn
            // 
            this.dimensionesDataGridViewTextBoxColumn.DataPropertyName = "Dimensiones";
            this.dimensionesDataGridViewTextBoxColumn.HeaderText = "Dimensión";
            this.dimensionesDataGridViewTextBoxColumn.Name = "dimensionesDataGridViewTextBoxColumn";
            this.dimensionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.dimensionesDataGridViewTextBoxColumn.Width = 130;
            // 
            // garantiaDataGridViewTextBoxColumn
            // 
            this.garantiaDataGridViewTextBoxColumn.DataPropertyName = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.HeaderText = "Garantía";
            this.garantiaDataGridViewTextBoxColumn.Name = "garantiaDataGridViewTextBoxColumn";
            this.garantiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.garantiaDataGridViewTextBoxColumn.Width = 111;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 90;
            // 
            // memoriaDataGridViewTextBoxColumn
            // 
            this.memoriaDataGridViewTextBoxColumn.DataPropertyName = "Memoria";
            this.memoriaDataGridViewTextBoxColumn.HeaderText = "Memoria";
            this.memoriaDataGridViewTextBoxColumn.Name = "memoriaDataGridViewTextBoxColumn";
            this.memoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoriaDataGridViewTextBoxColumn.Width = 114;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 103;
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "Precio_Compra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "Precio compra";
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            this.precioCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioCompraDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "Precio venta";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioVentaDataGridViewTextBoxColumn.Width = 133;
            // 
            // ramDataGridViewTextBoxColumn
            // 
            this.ramDataGridViewTextBoxColumn.DataPropertyName = "Ram";
            this.ramDataGridViewTextBoxColumn.HeaderText = "RAM";
            this.ramDataGridViewTextBoxColumn.Name = "ramDataGridViewTextBoxColumn";
            this.ramDataGridViewTextBoxColumn.ReadOnly = true;
            this.ramDataGridViewTextBoxColumn.Width = 76;
            // 
            // productoesBindingSource
            // 
            this.productoesBindingSource.DataMember = "Productoes";
            this.productoesBindingSource.DataSource = this.celuInventario;
            // 
            // celuInventario
            // 
            this.celuInventario.DataSetName = "CeluInventario";
            this.celuInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(590, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 30);
            this.textBox5.TabIndex = 32;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(590, 251);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(117, 30);
            this.textBox6.TabIndex = 31;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(590, 172);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(117, 30);
            this.textBox7.TabIndex = 30;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(590, 132);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(117, 30);
            this.textBox8.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Dimensiones:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Precio venta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Precio compra:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "Memoria:";
            // 
            // garantia_txt
            // 
            this.garantia_txt.Location = new System.Drawing.Point(322, 211);
            this.garantia_txt.Name = "garantia_txt";
            this.garantia_txt.Size = new System.Drawing.Size(117, 30);
            this.garantia_txt.TabIndex = 24;
            // 
            // marca_txt
            // 
            this.marca_txt.Location = new System.Drawing.Point(322, 251);
            this.marca_txt.Name = "marca_txt";
            this.marca_txt.Size = new System.Drawing.Size(117, 30);
            this.marca_txt.TabIndex = 23;
            // 
            // ram_txt
            // 
            this.ram_txt.Location = new System.Drawing.Point(322, 172);
            this.ram_txt.Name = "ram_txt";
            this.ram_txt.Size = new System.Drawing.Size(117, 30);
            this.ram_txt.TabIndex = 22;
            // 
            // color_txt
            // 
            this.color_txt.Location = new System.Drawing.Point(322, 132);
            this.color_txt.Name = "color_txt";
            this.color_txt.Size = new System.Drawing.Size(117, 30);
            this.color_txt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Marca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Garantía:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "RAM:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Color:";
            // 
            // bateria_txt
            // 
            this.bateria_txt.Location = new System.Drawing.Point(100, 211);
            this.bateria_txt.Name = "bateria_txt";
            this.bateria_txt.Size = new System.Drawing.Size(117, 30);
            this.bateria_txt.TabIndex = 16;
            // 
            // camara_txt
            // 
            this.camara_txt.Location = new System.Drawing.Point(100, 251);
            this.camara_txt.Name = "camara_txt";
            this.camara_txt.Size = new System.Drawing.Size(117, 30);
            this.camara_txt.TabIndex = 15;
            // 
            // modelo_txt
            // 
            this.modelo_txt.Location = new System.Drawing.Point(100, 172);
            this.modelo_txt.Name = "modelo_txt";
            this.modelo_txt.Size = new System.Drawing.Size(117, 30);
            this.modelo_txt.TabIndex = 14;
            // 
            // codigo_txt
            // 
            this.codigo_txt.Location = new System.Drawing.Point(100, 132);
            this.codigo_txt.Name = "codigo_txt";
            this.codigo_txt.Size = new System.Drawing.Size(117, 30);
            this.codigo_txt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cámara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Batería:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código:";
            // 
            // buscar_btn
            // 
            this.buscar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_btn.Location = new System.Drawing.Point(445, 83);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(101, 30);
            this.buscar_btn.TabIndex = 8;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            // 
            // buscar_txt
            // 
            this.buscar_txt.Location = new System.Drawing.Point(100, 85);
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(339, 30);
            this.buscar_txt.TabIndex = 7;
            this.buscar_txt.TextChanged += new System.EventHandler(this.buscar_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "INVENTARIO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hcompras_btn
            // 
            this.hcompras_btn.AutoSize = true;
            this.hcompras_btn.BackColor = System.Drawing.Color.LightPink;
            this.hcompras_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hcompras_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hcompras_btn.FlatAppearance.BorderSize = 0;
            this.hcompras_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.hcompras_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.hcompras_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hcompras_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hcompras_btn.Location = new System.Drawing.Point(7, 25);
            this.hcompras_btn.Name = "hcompras_btn";
            this.hcompras_btn.Size = new System.Drawing.Size(205, 43);
            this.hcompras_btn.TabIndex = 41;
            this.hcompras_btn.Text = "Historial de compras";
            this.hcompras_btn.UseVisualStyleBackColor = false;
            this.hcompras_btn.Click += new System.EventHandler(this.hcompras_btn_Click);
            // 
            // celuCenterInventario
            // 
            this.celuCenterInventario.DataSetName = "CeluCenterInventario";
            this.celuCenterInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celuCenterInventarioBindingSource
            // 
            this.celuCenterInventarioBindingSource.DataSource = this.celuCenterInventario;
            this.celuCenterInventarioBindingSource.Position = 0;
            // 
            // celuCenterInventarioBindingSource1
            // 
            this.celuCenterInventarioBindingSource1.DataSource = this.celuCenterInventario;
            this.celuCenterInventarioBindingSource1.Position = 0;
            // 
            // productoesTableAdapter
            // 
            this.productoesTableAdapter.ClearBeforeFill = true;
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_btn.Image = ((System.Drawing.Image)(resources.GetObject("eliminar_btn.Image")));
            this.eliminar_btn.Location = new System.Drawing.Point(724, 237);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(131, 42);
            this.eliminar_btn.TabIndex = 36;
            this.eliminar_btn.Text = " Eliminar";
            this.eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // limpiar_btn
            // 
            this.limpiar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.limpiar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar_btn.Image = ((System.Drawing.Image)(resources.GetObject("limpiar_btn.Image")));
            this.limpiar_btn.Location = new System.Drawing.Point(724, 180);
            this.limpiar_btn.Name = "limpiar_btn";
            this.limpiar_btn.Size = new System.Drawing.Size(131, 42);
            this.limpiar_btn.TabIndex = 35;
            this.limpiar_btn.Text = "Limpiar";
            this.limpiar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.limpiar_btn.UseVisualStyleBackColor = true;
            // 
            // modificar_btn
            // 
            this.modificar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.modificar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_btn.Image = ((System.Drawing.Image)(resources.GetObject("modificar_btn.Image")));
            this.modificar_btn.Location = new System.Drawing.Point(724, 124);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(131, 42);
            this.modificar_btn.TabIndex = 34;
            this.modificar_btn.Text = " Modificar";
            this.modificar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modificar_btn.UseVisualStyleBackColor = true;
            // 
            // nuevo_btn
            // 
            this.nuevo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevo_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.nuevo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo_btn.Image = ((System.Drawing.Image)(resources.GetObject("nuevo_btn.Image")));
            this.nuevo_btn.Location = new System.Drawing.Point(724, 71);
            this.nuevo_btn.Name = "nuevo_btn";
            this.nuevo_btn.Size = new System.Drawing.Size(131, 42);
            this.nuevo_btn.TabIndex = 33;
            this.nuevo_btn.Text = "  Nuevo";
            this.nuevo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevo_btn.UseVisualStyleBackColor = true;
            // 
            // menu_btn
            // 
            this.menu_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menu_btn.BackColor = System.Drawing.Color.Linen;
            this.menu_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_btn.BackgroundImage")));
            this.menu_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_btn.FlatAppearance.BorderSize = 0;
            this.menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn.Location = new System.Drawing.Point(47, 392);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(110, 110);
            this.menu_btn.TabIndex = 39;
            this.menu_btn.UseVisualStyleBackColor = false;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // cerrarsesion_btn
            // 
            this.cerrarsesion_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cerrarsesion_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarsesion_btn.FlatAppearance.BorderSize = 0;
            this.cerrarsesion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarsesion_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarsesion_btn.Image = ((System.Drawing.Image)(resources.GetObject("cerrarsesion_btn.Image")));
            this.cerrarsesion_btn.Location = new System.Drawing.Point(17, 508);
            this.cerrarsesion_btn.Name = "cerrarsesion_btn";
            this.cerrarsesion_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cerrarsesion_btn.Size = new System.Drawing.Size(166, 41);
            this.cerrarsesion_btn.TabIndex = 38;
            this.cerrarsesion_btn.Text = "Cerrar Sesión";
            this.cerrarsesion_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarsesion_btn.UseVisualStyleBackColor = true;
            this.cerrarsesion_btn.Click += new System.EventHandler(this.cerrarsesion_btn_Click);
            // 
            // Inventario_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.hcompras_btn);
            this.Controls.Add(this.hventas_btn);
            this.Controls.Add(this.inventario_btn);
            this.Controls.Add(this.gusuario_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.cerrarsesion_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Inventario_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CELUCENTER - Inventario";
            this.Load += new System.EventHandler(this.Inventario_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterInventarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hventas_btn;
        private System.Windows.Forms.Button inventario_btn;
        private System.Windows.Forms.Button gusuario_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.TextBox buscar_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button cerrarsesion_btn;
        private System.Windows.Forms.Button hcompras_btn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox garantia_txt;
        private System.Windows.Forms.TextBox marca_txt;
        private System.Windows.Forms.TextBox ram_txt;
        private System.Windows.Forms.TextBox color_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bateria_txt;
        private System.Windows.Forms.TextBox camara_txt;
        private System.Windows.Forms.TextBox modelo_txt;
        private System.Windows.Forms.TextBox codigo_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button limpiar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.Button nuevo_btn;
        private System.Windows.Forms.DataGridView inventario_tabla;
        private CeluCenterInventario celuCenterInventario;
        private System.Windows.Forms.BindingSource celuCenterInventarioBindingSource;
        private System.Windows.Forms.BindingSource celuCenterInventarioBindingSource1;
        private CeluInventario celuInventario;
        private System.Windows.Forms.BindingSource productoesBindingSource;
        private CeluInventarioTableAdapters.ProductoesTableAdapter productoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDispDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramDataGridViewTextBoxColumn;
    }
}