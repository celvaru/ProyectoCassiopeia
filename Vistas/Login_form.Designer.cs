namespace CeluCenter
{
    partial class Login_form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.ingresar_btn = new System.Windows.Forms.Button();
            this.perfil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // ingresar_btn
            // 
            this.ingresar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar_btn.Location = new System.Drawing.Point(128, 447);
            this.ingresar_btn.Name = "ingresar_btn";
            this.ingresar_btn.Size = new System.Drawing.Size(130, 41);
            this.ingresar_btn.TabIndex = 0;
            this.ingresar_btn.Text = "INGRESAR";
            this.ingresar_btn.UseVisualStyleBackColor = true;
            this.ingresar_btn.Click += new System.EventHandler(this.ingresar_btn_Click);
            // 
            // perfil
            // 
            this.perfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("perfil.BackgroundImage")));
            this.perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.perfil.Location = new System.Drawing.Point(97, 86);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(200, 200);
            this.perfil.TabIndex = 1;
            this.perfil.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // usuario_txt
            // 
            this.usuario_txt.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_txt.Location = new System.Drawing.Point(162, 305);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(184, 30);
            this.usuario_txt.TabIndex = 5;
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(162, 356);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(184, 30);
            this.password_txt.TabIndex = 6;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 525);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.ingresar_btn);
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ingresar_btn;
        private System.Windows.Forms.PictureBox perfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.TextBox password_txt;
    }
}

