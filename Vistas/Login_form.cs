using CeluCenter.Context;
using CeluCenter.Controladores;
using CeluCenter.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeluCenter
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            //CompraVenta db = new CompraVenta();
            //var usuario = db.Usuario.ToList();
            //var propietario = db.Propietario.ToList();
            //var vendedor = db.Vendedor.ToList();
            //var cliente = db.Cliente.ToList();
            //var compra = db.Compra.ToList();
            //var venta = db.Venta.ToList();
            //var detalle_venta = db.Detalle_Venta.ToList();
            //var producto = db.Producto.ToList();
        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            string usuario = usuario_txt.Text;
            string password = password_txt.Text;
            UsuarioController usuarioController = new UsuarioController();
            bool isLogin = usuarioController.Login(usuario, password);
            if (isLogin == true)
            {
                MenuPrincipal_form menuPrincipal_Form = new MenuPrincipal_form();
                menuPrincipal_Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Celucenter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
