namespace CeluCenter.Vistas
{
    partial class Registrocliente_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrocliente_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ci_txt = new System.Windows.Forms.TextBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cliente_tabla = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celuCenterCliente = new CeluCenter.CeluCenterCliente();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.nuevo_btn = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new CeluCenter.CeluCenterClienteTableAdapters.ClientesTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ci_txt);
            this.groupBox1.Controls.Add(this.nombre_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // ci_txt
            // 
            this.ci_txt.Location = new System.Drawing.Point(378, 39);
            this.ci_txt.Name = "ci_txt";
            this.ci_txt.Size = new System.Drawing.Size(156, 30);
            this.ci_txt.TabIndex = 2;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(116, 39);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(199, 30);
            this.nombre_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "CI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO CLIENTE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cliente_tabla);
            this.groupBox2.Controls.Add(this.cancelar_btn);
            this.groupBox2.Controls.Add(this.eliminar_btn);
            this.groupBox2.Controls.Add(this.modificar_btn);
            this.groupBox2.Controls.Add(this.nuevo_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de clientes";
            // 
            // cliente_tabla
            // 
            this.cliente_tabla.AllowUserToOrderColumns = true;
            this.cliente_tabla.AutoGenerateColumns = false;
            this.cliente_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cliente_tabla.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cliente_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cliente_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cliente_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.ciClienteDataGridViewTextBoxColumn});
            this.cliente_tabla.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cliente_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.cliente_tabla.Location = new System.Drawing.Point(26, 43);
            this.cliente_tabla.Name = "cliente_tabla";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cliente_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cliente_tabla.Size = new System.Drawing.Size(346, 194);
            this.cliente_tabla.TabIndex = 41;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // ciClienteDataGridViewTextBoxColumn
            // 
            this.ciClienteDataGridViewTextBoxColumn.DataPropertyName = "CiCliente";
            this.ciClienteDataGridViewTextBoxColumn.HeaderText = "CI";
            this.ciClienteDataGridViewTextBoxColumn.Name = "ciClienteDataGridViewTextBoxColumn";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.celuCenterCliente;
            // 
            // celuCenterCliente
            // 
            this.celuCenterCliente.DataSetName = "CeluCenterCliente";
            this.celuCenterCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_btn.Image = ((System.Drawing.Image)(resources.GetObject("cancelar_btn.Image")));
            this.cancelar_btn.Location = new System.Drawing.Point(403, 195);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(131, 42);
            this.cancelar_btn.TabIndex = 40;
            this.cancelar_btn.Text = " Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_btn.Image = ((System.Drawing.Image)(resources.GetObject("eliminar_btn.Image")));
            this.eliminar_btn.Location = new System.Drawing.Point(403, 138);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(131, 42);
            this.eliminar_btn.TabIndex = 39;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // modificar_btn
            // 
            this.modificar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificar_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.modificar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_btn.Image = ((System.Drawing.Image)(resources.GetObject("modificar_btn.Image")));
            this.modificar_btn.Location = new System.Drawing.Point(403, 82);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(131, 42);
            this.modificar_btn.TabIndex = 38;
            this.modificar_btn.Text = " Modificar";
            this.modificar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modificar_btn.UseVisualStyleBackColor = true;
            // 
            // nuevo_btn
            // 
            this.nuevo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevo_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.nuevo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo_btn.Image = ((System.Drawing.Image)(resources.GetObject("nuevo_btn.Image")));
            this.nuevo_btn.Location = new System.Drawing.Point(403, 29);
            this.nuevo_btn.Name = "nuevo_btn";
            this.nuevo_btn.Size = new System.Drawing.Size(131, 42);
            this.nuevo_btn.TabIndex = 37;
            this.nuevo_btn.Text = " Guardar";
            this.nuevo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevo_btn.UseVisualStyleBackColor = true;
            this.nuevo_btn.Click += new System.EventHandler(this.nuevo_btn_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // Registrocliente_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Registrocliente_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CELUCENTER - Registro cliente";
            this.Load += new System.EventHandler(this.Registrocliente_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cliente_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ci_txt;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.Button nuevo_btn;
        private System.Windows.Forms.DataGridView cliente_tabla;
        private CeluCenterCliente celuCenterCliente;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private CeluCenterClienteTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciClienteDataGridViewTextBoxColumn;
    }
}