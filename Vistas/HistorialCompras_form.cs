using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeluCenter.Vistas
{
    public partial class HistorialCompras_form : Form
    {
        public HistorialCompras_form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCompras_form));
            this.hcompras_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.compras_tabla = new System.Windows.Forms.DataGridView();
            this.nroCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celuCenterDataSet = new CeluCenter.CeluCenterDataSet();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buscarpor_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inventario_btn = new System.Windows.Forms.Button();
            this.gusuario_btn = new System.Windows.Forms.Button();
            this.hventas_btn = new System.Windows.Forms.Button();
            this.comprasTableAdapter = new CeluCenter.CeluCenterDataSetTableAdapters.ComprasTableAdapter();
            this.menu_btn = new System.Windows.Forms.Button();
            this.cerrarsesion_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compras_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hcompras_btn
            // 
            this.hcompras_btn.AutoSize = true;
            this.hcompras_btn.BackColor = System.Drawing.Color.IndianRed;
            this.hcompras_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hcompras_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hcompras_btn.FlatAppearance.BorderSize = 0;
            this.hcompras_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.hcompras_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.hcompras_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hcompras_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hcompras_btn.Location = new System.Drawing.Point(7, 25);
            this.hcompras_btn.Name = "hcompras_btn";
            this.hcompras_btn.Size = new System.Drawing.Size(219, 43);
            this.hcompras_btn.TabIndex = 22;
            this.hcompras_btn.Text = "Historial de compras";
            this.hcompras_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(209, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 537);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.compras_tabla);
            this.panel2.Controls.Add(this.buscar_btn);
            this.panel2.Controls.Add(this.buscar_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buscarpor_combo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(31, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 512);
            this.panel2.TabIndex = 0;
            // 
            // compras_tabla
            // 
            this.compras_tabla.AllowUserToAddRows = false;
            this.compras_tabla.AllowUserToDeleteRows = false;
            this.compras_tabla.AllowUserToOrderColumns = true;
            this.compras_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compras_tabla.AutoGenerateColumns = false;
            this.compras_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.compras_tabla.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compras_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.compras_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compras_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCompraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.productoCodigoDataGridViewTextBoxColumn,
            this.cantidadCompraDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.compras_tabla.DataSource = this.comprasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.compras_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.compras_tabla.GridColor = System.Drawing.Color.IndianRed;
            this.compras_tabla.Location = new System.Drawing.Point(26, 172);
            this.compras_tabla.Name = "compras_tabla";
            this.compras_tabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compras_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.compras_tabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.compras_tabla.Size = new System.Drawing.Size(820, 305);
            this.compras_tabla.TabIndex = 9;
            // 
            // nroCompraDataGridViewTextBoxColumn
            // 
            this.nroCompraDataGridViewTextBoxColumn.DataPropertyName = "Nro_Compra";
            this.nroCompraDataGridViewTextBoxColumn.HeaderText = "Nro.Compra";
            this.nroCompraDataGridViewTextBoxColumn.Name = "nroCompraDataGridViewTextBoxColumn";
            this.nroCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoCodigoDataGridViewTextBoxColumn
            // 
            this.productoCodigoDataGridViewTextBoxColumn.DataPropertyName = "Producto_Codigo";
            this.productoCodigoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoCodigoDataGridViewTextBoxColumn.Name = "productoCodigoDataGridViewTextBoxColumn";
            this.productoCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadCompraDataGridViewTextBoxColumn
            // 
            this.cantidadCompraDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Compra";
            this.cantidadCompraDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadCompraDataGridViewTextBoxColumn.Name = "cantidadCompraDataGridViewTextBoxColumn";
            this.cantidadCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.celuCenterDataSet;
            // 
            // celuCenterDataSet
            // 
            this.celuCenterDataSet.DataSetName = "CeluCenterDataSet";
            this.celuCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscar_btn
            // 
            this.buscar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar_btn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_btn.Location = new System.Drawing.Point(689, 94);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(90, 30);
            this.buscar_btn.TabIndex = 8;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            // 
            // buscar_txt
            // 
            this.buscar_txt.Location = new System.Drawing.Point(382, 94);
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(301, 30);
            this.buscar_txt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "HISTORIAL DE COMPRAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buscarpor_combo
            // 
            this.buscarpor_combo.FormattingEnabled = true;
            this.buscarpor_combo.Items.AddRange(new object[] {
            "Nro. Compra",
            "Fecha",
            "Producto"});
            this.buscarpor_combo.Location = new System.Drawing.Point(203, 95);
            this.buscarpor_combo.Name = "buscarpor_combo";
            this.buscarpor_combo.Size = new System.Drawing.Size(122, 29);
            this.buscarpor_combo.TabIndex = 1;
            this.buscarpor_combo.Text = "Seleccione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
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
            this.inventario_btn.TabIndex = 24;
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
            this.gusuario_btn.TabIndex = 23;
            this.gusuario_btn.Text = "Gestionar usuarios";
            this.gusuario_btn.UseVisualStyleBackColor = false;
            this.gusuario_btn.Click += new System.EventHandler(this.gusuario_btn_Click);
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
            this.hventas_btn.TabIndex = 34;
            this.hventas_btn.Text = "Historial de ventas";
            this.hventas_btn.UseVisualStyleBackColor = false;
            this.hventas_btn.Click += new System.EventHandler(this.hventas_btn_Click);
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
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
            this.menu_btn.TabIndex = 26;
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
            this.cerrarsesion_btn.TabIndex = 25;
            this.cerrarsesion_btn.Text = "Cerrar Sesión";
            this.cerrarsesion_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarsesion_btn.UseVisualStyleBackColor = true;
            this.cerrarsesion_btn.Click += new System.EventHandler(this.cerrarsesion_btn_Click);
            // 
            // HistorialCompras_form
            // 
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.hventas_btn);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.cerrarsesion_btn);
            this.Controls.Add(this.inventario_btn);
            this.Controls.Add(this.gusuario_btn);
            this.Controls.Add(this.hcompras_btn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "HistorialCompras_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CELUCENTER - Historial de compras";
            this.Load += new System.EventHandler(this.HistorialCompras_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compras_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void gusuario_btn_Click(object sender, EventArgs e)
        {
            GestionarUsuario_form gestionarUsuario_Form = new GestionarUsuario_form();
            gestionarUsuario_Form.Show();
            this.Dispose();
        }

        private void hventas_btn_Click(object sender, EventArgs e)
        {
            HistorialVentas_form historialVentas_Form = new HistorialVentas_form();
            historialVentas_Form.Show();
            this.Dispose();
        }

        private void inventario_btn_Click(object sender, EventArgs e)
        {
            Inventario_form inventario_Form = new Inventario_form();
            inventario_Form.Show();
            this.Dispose();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            MenuPrincipal_form menuPrincipal_Form = new MenuPrincipal_form();
            menuPrincipal_Form.Show();
            this.Dispose();
        }

        private void HistorialCompras_form_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'celuCenterDataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.celuCenterDataSet.Compras);

        }

        private void cerrarsesion_btn_Click(object sender, EventArgs e)
        {
            Login_form login_form = new Login_form();
            login_form.Show();
            this.Close();
        }
    }
}
