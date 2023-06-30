using System;

namespace CeluCenter.Vistas
{
    partial class GestionarUsuario_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarUsuario_form));
            this.hventas_btn = new System.Windows.Forms.Button();
            this.hcompras_btn = new System.Windows.Forms.Button();
            this.gusuario_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usuarios_tabla = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriminatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celuCenterUsuarios = new CeluCenter.CeluCenterUsuarios();
            this.cargo_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.confirma_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ci_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefono_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inventario_btn = new System.Windows.Forms.Button();
            this.usuariosTableAdapter = new CeluCenter.CeluCenterUsuariosTableAdapters.UsuariosTableAdapter();
            this.menu_btn = new System.Windows.Forms.Button();
            this.cerrarsesion_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.nuevo_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterUsuarios)).BeginInit();
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
            this.hventas_btn.TabIndex = 33;
            this.hventas_btn.Text = "Historial de ventas";
            this.hventas_btn.UseVisualStyleBackColor = false;
            this.hventas_btn.Click += new System.EventHandler(this.hventas_btn_Click);
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
            this.hcompras_btn.TabIndex = 32;
            this.hcompras_btn.Text = "Historial de compras";
            this.hcompras_btn.UseVisualStyleBackColor = false;
            this.hcompras_btn.Click += new System.EventHandler(this.hcompras_btn_Click);
            // 
            // gusuario_btn
            // 
            this.gusuario_btn.AutoSize = true;
            this.gusuario_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.gusuario_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gusuario_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gusuario_btn.FlatAppearance.BorderSize = 0;
            this.gusuario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.gusuario_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.gusuario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gusuario_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gusuario_btn.Location = new System.Drawing.Point(7, 172);
            this.gusuario_btn.Name = "gusuario_btn";
            this.gusuario_btn.Size = new System.Drawing.Size(205, 43);
            this.gusuario_btn.TabIndex = 29;
            this.gusuario_btn.Text = "Gestionar usuarios";
            this.gusuario_btn.UseVisualStyleBackColor = false;
            this.gusuario_btn.Click += new System.EventHandler(this.gusuario_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(209, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 537);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.eliminar_btn);
            this.panel2.Controls.Add(this.modificar_btn);
            this.panel2.Controls.Add(this.nuevo_btn);
            this.panel2.Controls.Add(this.usuarios_tabla);
            this.panel2.Controls.Add(this.cargo_combo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.confirma_txt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pass_txt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ci_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.usuario_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.telefono_txt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nombre_txt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(31, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 512);
            this.panel2.TabIndex = 34;
            // 
            // usuarios_tabla
            // 
            this.usuarios_tabla.AutoGenerateColumns = false;
            this.usuarios_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuarios_tabla.BackgroundColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarios_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usuarios_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarios_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.nomUsuarioDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn,
            this.cIDataGridViewTextBoxColumn,
            this.discriminatorDataGridViewTextBoxColumn});
            this.usuarios_tabla.DataSource = this.usuariosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuarios_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.usuarios_tabla.Location = new System.Drawing.Point(31, 338);
            this.usuarios_tabla.Name = "usuarios_tabla";
            this.usuarios_tabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarios_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usuarios_tabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.usuarios_tabla.Size = new System.Drawing.Size(816, 150);
            this.usuarios_tabla.TabIndex = 21;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomUsuarioDataGridViewTextBoxColumn
            // 
            this.nomUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Nom_Usuario";
            this.nomUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.nomUsuarioDataGridViewTextBoxColumn.Name = "nomUsuarioDataGridViewTextBoxColumn";
            this.nomUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDataGridViewTextBoxColumn
            // 
            this.cIDataGridViewTextBoxColumn.DataPropertyName = "CI";
            this.cIDataGridViewTextBoxColumn.HeaderText = "CI";
            this.cIDataGridViewTextBoxColumn.Name = "cIDataGridViewTextBoxColumn";
            this.cIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discriminatorDataGridViewTextBoxColumn
            // 
            this.discriminatorDataGridViewTextBoxColumn.DataPropertyName = "Discriminator";
            this.discriminatorDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.discriminatorDataGridViewTextBoxColumn.Name = "discriminatorDataGridViewTextBoxColumn";
            this.discriminatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.celuCenterUsuarios;
            // 
            // celuCenterUsuarios
            // 
            this.celuCenterUsuarios.DataSetName = "CeluCenterUsuarios";
            this.celuCenterUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargo_combo
            // 
            this.cargo_combo.FormattingEnabled = true;
            this.cargo_combo.Items.AddRange(new object[] {
            "Propietario",
            "Vendedor"});
            this.cargo_combo.Location = new System.Drawing.Point(439, 209);
            this.cargo_combo.Name = "cargo_combo";
            this.cargo_combo.Size = new System.Drawing.Size(159, 29);
            this.cargo_combo.TabIndex = 20;
            this.cargo_combo.Text = "Seleccione";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cargo:";
            // 
            // confirma_txt
            // 
            this.confirma_txt.Location = new System.Drawing.Point(156, 261);
            this.confirma_txt.Name = "confirma_txt";
            this.confirma_txt.Size = new System.Drawing.Size(159, 30);
            this.confirma_txt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 42);
            this.label6.TabIndex = 17;
            this.label6.Text = "Confirmar\r\ncontraseña";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(156, 208);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(159, 30);
            this.pass_txt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Contraseña:";
            // 
            // ci_txt
            // 
            this.ci_txt.Location = new System.Drawing.Point(439, 155);
            this.ci_txt.Name = "ci_txt";
            this.ci_txt.Size = new System.Drawing.Size(159, 30);
            this.ci_txt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "CI:";
            // 
            // usuario_txt
            // 
            this.usuario_txt.Location = new System.Drawing.Point(156, 155);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(159, 30);
            this.usuario_txt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre\r\nusuario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // telefono_txt
            // 
            this.telefono_txt.Location = new System.Drawing.Point(439, 103);
            this.telefono_txt.Name = "telefono_txt";
            this.telefono_txt.Size = new System.Drawing.Size(159, 30);
            this.telefono_txt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Teléfono:";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(156, 103);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(159, 30);
            this.nombre_txt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "GESTION DE USUARIOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.inventario_btn.TabIndex = 10;
            this.inventario_btn.Text = "Inventario";
            this.inventario_btn.UseVisualStyleBackColor = false;
            this.inventario_btn.Click += new System.EventHandler(this.inventario_btn_Click);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
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
            this.menu_btn.TabIndex = 31;
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
            this.cerrarsesion_btn.TabIndex = 30;
            this.cerrarsesion_btn.Text = "Cerrar Sesión";
            this.cerrarsesion_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarsesion_btn.UseVisualStyleBackColor = true;
            this.cerrarsesion_btn.Click += new System.EventHandler(this.cerrarsesion_btn_Click);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_btn.Image = ((System.Drawing.Image)(resources.GetObject("eliminar_btn.Image")));
            this.eliminar_btn.Location = new System.Drawing.Point(677, 259);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(145, 52);
            this.eliminar_btn.TabIndex = 24;
            this.eliminar_btn.Text = " Eliminar";
            this.eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // modificar_btn
            // 
            this.modificar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modificar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificar_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.modificar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_btn.Image = ((System.Drawing.Image)(resources.GetObject("modificar_btn.Image")));
            this.modificar_btn.Location = new System.Drawing.Point(677, 186);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(145, 52);
            this.modificar_btn.TabIndex = 23;
            this.modificar_btn.Text = " Modificar";
            this.modificar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modificar_btn.UseVisualStyleBackColor = true;
            // 
            // nuevo_btn
            // 
            this.nuevo_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevo_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.nuevo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo_btn.Image = ((System.Drawing.Image)(resources.GetObject("nuevo_btn.Image")));
            this.nuevo_btn.Location = new System.Drawing.Point(677, 112);
            this.nuevo_btn.Name = "nuevo_btn";
            this.nuevo_btn.Size = new System.Drawing.Size(145, 52);
            this.nuevo_btn.TabIndex = 22;
            this.nuevo_btn.Text = "   Nuevo";
            this.nuevo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevo_btn.UseVisualStyleBackColor = true;
            // 
            // GestionarUsuario_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.inventario_btn);
            this.Controls.Add(this.hventas_btn);
            this.Controls.Add(this.hcompras_btn);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.cerrarsesion_btn);
            this.Controls.Add(this.gusuario_btn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "GestionarUsuario_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CELUCENTER - Gestión de usuarios";
            this.Load += new System.EventHandler(this.GestionarUsuario_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GestionarUsuario_form_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button hventas_btn;
        private System.Windows.Forms.Button hcompras_btn;
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button cerrarsesion_btn;
        private System.Windows.Forms.Button gusuario_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inventario_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirma_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ci_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefono_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView usuarios_tabla;
        private System.Windows.Forms.ComboBox cargo_combo;
        private System.Windows.Forms.Label label8;
        private CeluCenterUsuarios celuCenterUsuarios;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private CeluCenterUsuariosTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriminatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.Button nuevo_btn;
    }
}