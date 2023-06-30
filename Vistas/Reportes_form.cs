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
    public partial class Reportes_form : Form
    {
        SqlConnection conexion = new SqlConnection("server= localhost ; database= CeluCenter ; integrated security= true");
        public Reportes_form()
        {
            InitializeComponent();

            

            string consulta = "SELECT codigo, modelo, COUNT(*) AS cantidad FROM Productoes p, Detalle_Venta WHERE p.codigo = Producto_Codigo GROUP BY codigo, modelo ORDER BY cantidad DESC";
            SqlCommand consultaSql = new SqlCommand(consulta,conexion);
            SqlDataAdapter datos = new SqlDataAdapter(consultaSql);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            masvendidos_tabla.DataSource = tabla;
        }

        private void volver_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
