using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DojaCafe
{
    public partial class Empleados : Form
    {
        string cadenaConex = @"Data Source=MSI\SQLEXPRESS01;Initial Catalog=PracticaU3;Integrated Security=True";
        public Empleados()
        {
            InitializeComponent();
        }

        private void nombre_lbl_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Precio_lbl_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_bitacora_Click(object sender, EventArgs e)
        {
            Bitacora_Empleado workers = new Bitacora_Empleado();
            workers.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String IDempleado = txtb_id.Text;
            String nombreempleado = txtb_nombre.Text;
            String Telefono = txb_telefono.Text;
            String Puesto = txtb_id.Text;

            //revisar id
            bool existe = false;
            string cadenaSQL = "Select * from CLIENTE Where Clave=@clave";

            SqlConnection conectar = new SqlConnection(cadenaConex);

            conectar.Open();
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            comando.Parameters.AddWithValue("@clave", IDempleado);
            SqlDataReader rdr = comando.ExecuteReader();
            if (rdr.HasRows)
            {
                existe = true;
            }
            else
            {
                existe = false;
            }
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
            
        }

        private void cbx_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
