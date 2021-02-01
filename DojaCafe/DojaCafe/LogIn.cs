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

namespace DojaCafe
{
    public partial class Form1 : Form
    {

        System.Boolean Bandera = false;
        string cadenaConex = @"Data Source=MSI;Initial Catalog = DOJACAFE; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void labl_pass_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            try
            {
                Metodos Sesion = new Metodos();
                string usuario = txtb_usuario.Text;
                string Contrasena = txtb_password.Text;
                String cadenaSQL = "SELECT * FROM PUESTO WHERE puesto ='" + usuario + "'and puesto_id ='" + Contrasena + "'";
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection conectar = new SqlConnection(cadenaConex);
                SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
                da.SelectCommand = comando;
                conectar.Open();
                da.Fill(dt);
                conectar.Close();
                conectar.Dispose();
                comando.Dispose();
                da.Dispose();
                if (dt.Rows.Count != 0)
                {

                    Bandera = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en el inicio de sesión, intente de nuevo");
                    txtb_usuario.Clear();
                    txtb_password.Clear();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en el inicio de sesión.");
            }


            //
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtb_password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtb_usuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Bandera == false)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (Bandera == false)
            {
                Application.Exit();
            }
        }
    }
}
