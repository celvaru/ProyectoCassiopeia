using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeluCenter.Vistas
{
    public partial class Registrocliente_form : Form
    {
        public Registrocliente_form()
        {
            InitializeComponent();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrocliente_form_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'celuCenterCliente.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.celuCenterCliente.Clientes);

        }

        SqlConnection conexion = new SqlConnection("server= localhost ; database= CeluCenter ; integrated security= true");
        
        private void nuevo_btn_Click(object sender, EventArgs e)
        {
            string insertar = "Insert into Clientes([Nombre],[CiCliente])" + "values('" + nombre_txt.Text + "','" + ci_txt.Text + "')";
            SqlCommand comando_insertar = new SqlCommand(insertar, conexion);
            comando_insertar.ExecuteNonQuery();

            MessageBox.Show("El cliente se añadió correctamente","Información",MessageBoxButtons.OK);

            nombre_txt.Text = "";
            ci_txt.Text = "";

            
        }
    }
}
