namespace CeluCenter.Vistas
{
    partial class HistorialVentas_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialVentas_form));
            this.inventario_btn = new System.Windows.Forms.Button();
            this.gusuario_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ventas_tabla = new System.Windows.Forms.DataGridView();
            this.nroReciboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celuCenterDataSetVentas = new CeluCenter.CeluCenterDataSetVentas();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.buscarpor_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu_btn = new System.Windows.Forms.Button();
            this.cerrarsesion_btn = new System.Windows.Forms.Button();
            this.hcompras_btn = new System.Windows.Forms.Button();
            this.hventas_btn = new System.Windows.Forms.Button();
            this.celuCenterDataSet = new CeluCenter.CeluCenterDataSet();
            this.celuCenterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new CeluCenter.CeluCenterDataSetVentasTableAdapters.VentasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSetVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventario_btn
            // 
            this.inventario_btn.AutoSize = true;
            this.inventario_btn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.inventario_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventario_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventario_btn.FlatAppearance.BorderSize = 0;
            this.inventario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.inventario_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.inventario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventario_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventario_btn.Location = new System.Drawing.Point(7, 123);
            this.inventario_btn.Name = "inventario_btn";
            this.inventario_btn.Size = new System.Drawing.Size(205, 43);
            this.inventario_btn.TabIndex = 16;
            this.inventario_btn.Text = "Inventario";
            this.inventario_btn.UseVisualStyleBackColor = false;
            this.inventario_btn.Click += new System.EventHandler(this.inventario_btn_Click);
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
            this.gusuario_btn.TabIndex = 15;
            this.gusuario_btn.Text = "Gestionar usuarios";
            this.gusuario_btn.UseVisualStyleBackColor = false;
            this.gusuario_btn.Click += new System.EventHandler(this.gusuario_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(209, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 537);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.ventas_tabla);
            this.panel2.Controls.Add(this.buscar_btn);
            this.panel2.Controls.Add(this.buscar_txt);
            this.panel2.Controls.Add(this.buscarpor_combo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(31, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 512);
            this.panel2.TabIndex = 36;
            // 
            // ventas_tabla
            // 
            this.ventas_tabla.AllowUserToAddRows = false;
            this.ventas_tabla.AllowUserToDeleteRows = false;
            this.ventas_tabla.AllowUserToOrderColumns = true;
            this.ventas_tabla.AutoGenerateColumns = false;
            this.ventas_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ventas_tabla.BackgroundColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ventas_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ventas_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventas_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroReciboDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.clienteIdClienteDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.ventas_tabla.DataSource = this.ventasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ventas_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.ventas_tabla.Location = new System.Drawing.Point(40, 160);
            this.ventas_tabla.Name = "ventas_tabla";
            this.ventas_tabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ventas_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ventas_tabla.Size = new System.Drawing.Size(798, 317);
            this.ventas_tabla.TabIndex = 14;
            // 
            // nroReciboDataGridViewTextBoxColumn
            // 
            this.nroReciboDataGridViewTextBoxColumn.DataPropertyName = "Nro_Recibo";
            this.nroReciboDataGridViewTextBoxColumn.HeaderText = "Nro.Recibo";
            this.nroReciboDataGridViewTextBoxColumn.Name = "nroReciboDataGridViewTextBoxColumn";
            this.nroReciboDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteIdClienteDataGridViewTextBoxColumn
            // 
            this.clienteIdClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente_IdCliente";
            this.clienteIdClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteIdClienteDataGridViewTextBoxColumn.Name = "clienteIdClienteDataGridViewTextBoxColumn";
            this.clienteIdClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.celuCenterDataSetVentas;
            // 
            // celuCenterDataSetVentas
            // 
            this.celuCenterDataSetVentas.DataSetName = "CeluCenterDataSetVentas";
            this.celuCenterDataSetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscar_btn
            // 
            this.buscar_btn.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_btn.Location = new System.Drawing.Point(700, 88);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(90, 30);
            this.buscar_btn.TabIndex = 13;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            // 
            // buscar_txt
            // 
            this.buscar_txt.Location = new System.Drawing.Point(388, 88);
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(306, 30);
            this.buscar_txt.TabIndex = 12;
            // 
            // buscarpor_combo
            // 
            this.buscarpor_combo.FormattingEnabled = true;
            this.buscarpor_combo.Items.AddRange(new object[] {
            "Nro. Compra",
            "Fecha",
            "Producto"});
            this.buscarpor_combo.Location = new System.Drawing.Point(182, 88);
            this.buscarpor_combo.Name = "buscarpor_combo";
            this.buscarpor_combo.Size = new System.Drawing.Size(122, 29);
            this.buscarpor_combo.TabIndex = 10;
            this.buscarpor_combo.Text = "Seleccione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "HISTORIAL DE VENTAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_btn
            // 
            this.menu_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menu_btn.BackColor = System.Drawing.Color.Linen;
            this.menu_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_btn.BackgroundImage")));
            this.menu_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_btn.FlatAppearance.BorderSize = 0;
            this.menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn.Location = new System.Drawing.Point(47, 392);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(110, 110);
            this.menu_btn.TabIndex = 19;
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
            this.cerrarsesion_btn.TabIndex = 18;
            this.cerrarsesion_btn.Text = "Cerrar Sesión";
            this.cerrarsesion_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarsesion_btn.UseVisualStyleBackColor = true;
            this.cerrarsesion_btn.Click += new System.EventHandler(this.cerrarsesion_btn_Click);
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
            this.hcompras_btn.TabIndex = 33;
            this.hcompras_btn.Text = "Historial de compras";
            this.hcompras_btn.UseVisualStyleBackColor = false;
            this.hcompras_btn.Click += new System.EventHandler(this.hcompras_btn_Click);
            // 
            // hventas_btn
            // 
            this.hventas_btn.AutoSize = true;
            this.hventas_btn.BackColor = System.Drawing.Color.SandyBrown;
            this.hventas_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hventas_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hventas_btn.Enabled = false;
            this.hventas_btn.FlatAppearance.BorderSize = 0;
            this.hventas_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.hventas_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.hventas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hventas_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hventas_btn.Location = new System.Drawing.Point(7, 74);
            this.hventas_btn.Name = "hventas_btn";
            this.hventas_btn.Size = new System.Drawing.Size(205, 43);
            this.hventas_btn.TabIndex = 35;
            this.hventas_btn.Text = "Historial de ventas";
            this.hventas_btn.UseVisualStyleBackColor = false;
            // 
            // celuCenterDataSet
            // 
            this.celuCenterDataSet.DataSetName = "CeluCenterDataSet";
            this.celuCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celuCenterDataSetBindingSource
            // 
            this.celuCenterDataSetBindingSource.DataSource = this.celuCenterDataSet;
            this.celuCenterDataSetBindingSource.Position = 0;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.ventasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(638, 291);
            this.dataGridView1.TabIndex = 14;
            // 
            // HistorialVentas_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.hventas_btn);
            this.Controls.Add(this.hcompras_btn);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.cerrarsesion_btn);
            this.Controls.Add(this.inventario_btn);
            this.Controls.Add(this.gusuario_btn);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "HistorialVentas_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CELUCENTER - Historial de ventas";
            this.Load += new System.EventHandler(this.HistorialVentas_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSetVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button cerrarsesion_btn;
        private System.Windows.Forms.Button inventario_btn;
        private System.Windows.Forms.Button gusuario_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hcompras_btn;
        private System.Windows.Forms.Button hventas_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.TextBox buscar_txt;
        private System.Windows.Forms.ComboBox buscarpor_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource celuCenterDataSetBindingSource;
        private CeluCenterDataSet celuCenterDataSet;
        private CeluCenterDataSetVentas celuCenterDataSetVentas;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private CeluCenterDataSetVentasTableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView ventas_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroReciboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}