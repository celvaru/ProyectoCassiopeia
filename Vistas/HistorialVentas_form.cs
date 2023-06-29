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
    public partial class HistorialVentas_form : Form
    {
        public HistorialVentas_form()
        {
            InitializeComponent();
        }

        private void gusuario_btn_Click(object sender, EventArgs e)
        {
            GestionarUsuario_form gestionarUsuario_Form = new GestionarUsuario_form();
            gestionarUsuario_Form.Show();
            this.Dispose();
        }

        private void inventario_btn_Click(object sender, EventArgs e)
        {
            Inventario_form inventario_Form = new Inventario_form();
            inventario_Form.Show();
            this.Dispose();
        }

        private void hcompras_btn_Click(object sender, EventArgs e)
        {
            HistorialCompras_form historialCompras_Form = new HistorialCompras_form();
            historialCompras_Form.Show();
            this.Dispose();
        }

        private void gusuario_btn_Click_1(object sender, EventArgs e)
        {
            GestionarUsuario_form gestionarUsuario_Form = new GestionarUsuario_form();
            gestionarUsuario_Form.Show();
            this.Dispose();
        }

        private void hcompras_btn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            MenuPrincipal_form menuPrincipal_Form = new MenuPrincipal_form();
            menuPrincipal_Form.Show();
            this.Dispose();
        }

        private void HistorialVentas_form_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'celuCenterDataSetVentas.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.celuCenterDataSetVentas.Ventas);

        }

        private void cerrarsesion_btn_Click(object sender, EventArgs e)
        {
            Login_form login_form = new Login_form();
            login_form.Show();
            this.Close();
        }
    }
}
