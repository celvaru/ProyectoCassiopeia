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
    public partial class Nuevacompra_form : Form
    {
        public Nuevacompra_form()
        {
            InitializeComponent();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
