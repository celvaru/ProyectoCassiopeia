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
    public partial class Reportes_form : Form
    {
        public Reportes_form()
        {
            InitializeComponent();
        }

        private void volver_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
