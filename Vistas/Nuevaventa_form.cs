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
    public partial class Nuevaventa_form : Form
    {
        public Nuevaventa_form()
        {
            InitializeComponent();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ncliente_btn_Click(object sender, EventArgs e)
        {
            Registrocliente_form registrocliente_Form = new Registrocliente_form();
            registrocliente_Form.ShowDialog();
        }
    }
}
