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
    public partial class MenuPrincipal_form : Form
    {
        public MenuPrincipal_form()
        {
            InitializeComponent();
        }

        private void hcompras_btn_Click(object sender, EventArgs e)
        {
            HistorialCompras_form historialCompras_Form = new HistorialCompras_form();
            historialCompras_Form.Show();
            this.Dispose();
        }

        private void hventas_btn_Click(object sender, EventArgs e)
        {
            HistorialVentas_form historialVentas_Form = new HistorialVentas_form();
            historialVentas_Form.Show();
            this.Close();
        }

        private void inventario_btn_Click(object sender, EventArgs e)
        {
            Inventario_form inventario_Form = new Inventario_form();
            inventario_Form.Show();
            this.Close();
        }

        private void gusuario_btn_Click(object sender, EventArgs e)
        {
            GestionarUsuario_form gestionarUsuario_Form = new GestionarUsuario_form();
            gestionarUsuario_Form.Show();
            this.Close();
        }

        private void cerrarsesion_btn_Click(object sender, EventArgs e)
        {
            Login_form login_form = new Login_form();  
            login_form.Show();
            this.Close();
        }

        private void nventa_btn_Click(object sender, EventArgs e)
        {
            Nuevaventa_form nuevaventa_Form = new Nuevaventa_form();
            nuevaventa_Form.Show();

        }

        private void ncompra_btn_Click(object sender, EventArgs e)
        {
            Nuevacompra_form nuevacompra_Form = new Nuevacompra_form();
            nuevacompra_Form.Show();
        }

        private void nreporte_btn_Click(object sender, EventArgs e)
        {
            Reportes_form reportes_Form = new Reportes_form();
            reportes_Form.Show();
        }
    }
}
