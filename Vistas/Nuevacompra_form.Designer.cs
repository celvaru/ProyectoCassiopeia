namespace CeluCenter.Vistas
{
    partial class Nuevacompra_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevacompra_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechacompra_date = new System.Windows.Forms.DateTimePicker();
            this.cantidad_txt = new System.Windows.Forms.TextBox();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.ncompra_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.producto_combo = new System.Windows.Forms.ComboBox();
            this.cantactual_txt = new System.Windows.Forms.TextBox();
            this.cantstock_txt = new System.Windows.Forms.TextBox();
            this.codigo_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fecharegistro_date = new System.Windows.Forms.DateTimePicker();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.aceptar_btn = new System.Windows.Forms.Button();
            this.celuCenterProducto = new CeluCenter.CeluCenterProducto();
            this.celuCenterProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechacompra_date);
            this.groupBox1.Controls.Add(this.cantidad_txt);
            this.groupBox1.Controls.Add(this.total_txt);
            this.groupBox1.Controls.Add(this.ncompra_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la compra";
            // 
            // fechacompra_date
            // 
            this.fechacompra_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechacompra_date.CustomFormat = "dd/MM/yyyy";
            this.fechacompra_date.Enabled = false;
            this.fechacompra_date.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechacompra_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechacompra_date.Location = new System.Drawing.Point(417, 34);
            this.fechacompra_date.MaxDate = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            this.fechacompra_date.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fechacompra_date.Name = "fechacompra_date";
            this.fechacompra_date.Size = new System.Drawing.Size(123, 30);
            this.fechacompra_date.TabIndex = 16;
            this.fechacompra_date.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // cantidad_txt
            // 
            this.cantidad_txt.Location = new System.Drawing.Point(417, 80);
            this.cantidad_txt.Name = "cantidad_txt";
            this.cantidad_txt.Size = new System.Drawing.Size(123, 30);
            this.cantidad_txt.TabIndex = 12;
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(142, 80);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(123, 30);
            this.total_txt.TabIndex = 5;
            // 
            // ncompra_txt
            // 
            this.ncompra_txt.Enabled = false;
            this.ncompra_txt.Location = new System.Drawing.Point(142, 38);
            this.ncompra_txt.Name = "ncompra_txt";
            this.ncompra_txt.Size = new System.Drawing.Size(123, 30);
            this.ncompra_txt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro. compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUEVA COMPRA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.producto_combo);
            this.groupBox2.Controls.Add(this.cantactual_txt);
            this.groupBox2.Controls.Add(this.cantstock_txt);
            this.groupBox2.Controls.Add(this.codigo_txt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del producto";
            // 
            // producto_combo
            // 
            this.producto_combo.FormattingEnabled = true;
            this.producto_combo.Location = new System.Drawing.Point(142, 42);
            this.producto_combo.Name = "producto_combo";
            this.producto_combo.Size = new System.Drawing.Size(121, 29);
            this.producto_combo.TabIndex = 11;
            // 
            // cantactual_txt
            // 
            this.cantactual_txt.Enabled = false;
            this.cantactual_txt.Location = new System.Drawing.Point(417, 84);
            this.cantactual_txt.Name = "cantactual_txt";
            this.cantactual_txt.Size = new System.Drawing.Size(123, 30);
            this.cantactual_txt.TabIndex = 10;
            // 
            // cantstock_txt
            // 
            this.cantstock_txt.Enabled = false;
            this.cantstock_txt.Location = new System.Drawing.Point(417, 42);
            this.cantstock_txt.Name = "cantstock_txt";
            this.cantstock_txt.Size = new System.Drawing.Size(123, 30);
            this.cantstock_txt.TabIndex = 9;
            // 
            // codigo_txt
            // 
            this.codigo_txt.Enabled = false;
            this.codigo_txt.Location = new System.Drawing.Point(142, 84);
            this.codigo_txt.Name = "codigo_txt";
            this.codigo_txt.Size = new System.Drawing.Size(123, 30);
            this.codigo_txt.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cant. stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cant. actual:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha registro:";
            // 
            // fecharegistro_date
            // 
            this.fecharegistro_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecharegistro_date.CustomFormat = "dd/MM/yyyy";
            this.fecharegistro_date.Enabled = false;
            this.fecharegistro_date.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharegistro_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecharegistro_date.Location = new System.Drawing.Point(430, 75);
            this.fecharegistro_date.MaxDate = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            this.fecharegistro_date.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fecharegistro_date.Name = "fecharegistro_date";
            this.fecharegistro_date.Size = new System.Drawing.Size(123, 30);
            this.fecharegistro_date.TabIndex = 17;
            this.fecharegistro_date.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_btn.Image = ((System.Drawing.Image)(resources.GetObject("cancelar_btn.Image")));
            this.cancelar_btn.Location = new System.Drawing.Point(331, 393);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(171, 47);
            this.cancelar_btn.TabIndex = 16;
            this.cancelar_btn.Text = "  Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // aceptar_btn
            // 
            this.aceptar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aceptar_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.aceptar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar_btn.Image = ((System.Drawing.Image)(resources.GetObject("aceptar_btn.Image")));
            this.aceptar_btn.Location = new System.Drawing.Point(81, 393);
            this.aceptar_btn.Name = "aceptar_btn";
            this.aceptar_btn.Size = new System.Drawing.Size(195, 47);
            this.aceptar_btn.TabIndex = 15;
            this.aceptar_btn.Text = "Aceptar compra";
            this.aceptar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aceptar_btn.UseVisualStyleBackColor = true;
            // 
            // celuCenterProducto
            // 
            this.celuCenterProducto.DataSetName = "CeluCenterProducto";
            this.celuCenterProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celuCenterProductoBindingSource
            // 
            this.celuCenterProductoBindingSource.DataSource = this.celuCenterProducto;
            this.celuCenterProductoBindingSource.Position = 0;
            // 
            // Nuevacompra_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.fecharegistro_date);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.aceptar_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Nuevacompra_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CELUCENTER - Nueva compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celuCenterProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cantidad_txt;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.TextBox ncompra_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cantactual_txt;
        private System.Windows.Forms.TextBox cantstock_txt;
        private System.Windows.Forms.TextBox codigo_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button aceptar_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.ComboBox producto_combo;
        private System.Windows.Forms.DateTimePicker fechacompra_date;
        private System.Windows.Forms.DateTimePicker fecharegistro_date;
        private System.Windows.Forms.BindingSource celuCenterProductoBindingSource;
        private CeluCenterProducto celuCenterProducto;
    }
}