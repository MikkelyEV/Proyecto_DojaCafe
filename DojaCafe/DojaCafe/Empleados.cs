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
        string cadenaConex = @"Data Source=MSI;Initial Catalog=DOJACAFE;Integrated Security=True";
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
            cbx_puesto.SelectedIndex = -1;
            SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=DOJACAFE;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("select puesto from Puesto", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("puesto", typeof(string));
            dt.Load(reader);

           
            cbx_puesto.DisplayMember = "puesto";
            cbx_puesto.DataSource = dt;
            cbx_puesto.SelectedItem = null;

            conn.Close();
            txb_salario.Text = " ";
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
            String Puesto = cbx_puesto.Text;
            DateTime Fecha = dtp_fecha.Value.Date;
            string Fecha1 = Fecha.Date.ToString();
            String Correo = txb_correo.Text;
            String Direccion = txb_direccion.Text;
            String salario = txb_salario.Text;
            DateTime contratacion = DateTime.Today.Date;
            int edad = 20;
            puestonombre(Puesto);
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=DOJACAFE;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //SqlCommand command = new SqlCommand("EXECUTE dbo.InsertarEmpleado @EClave='" + IDempleado + "'@ENombre'"+nombreempleado+ "'@ETelefono'" + Telefono+ "'@EDireccion'" + Direccion+ "'@Correo'" + Correo+ "'@EPuesto'" + Puesto+ "'@EFecha'" + Fecha + "'@EEdad"+15+"", conn);
                SqlCommand command = new SqlCommand("EXECUTE dbo.InsertarEmpleado'" + IDempleado + "','" + nombreempleado + "','" + Telefono + "','" + Direccion + "','" + Correo + "','" + Puesto + "','" +null+ "',"+edad, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                command.Dispose();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insercion fallida");
            }



            //revisar id

            /*SqlConnection conectar = new SqlConnection(cadenaConex);
            conectar.Open();
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            SqlDataReader rdr = comando.ExecuteReader();
            if (rdr.HasRows)
            {
                existe = true;
                MessageBox.Show("Esta clave de empleado ya existe");
            }
            else
            {
                existe = false;
                try
                {
                    string cadenaSQL1 = "Insert into EMPLEADO (empleado_id,nombre, telefono, direccion, correo, puesto_id, fecha_nac, contratacion) Values('" + IDempleado + "','" + nombreempleado + "','" + Telefono + "','" + Direccion + "','" + Correo + "','" + Puesto +"','"+Fecha + "','"+contratacion+"')";
                    SqlCommand comando1 = new SqlCommand(cadenaSQL1, conectar);
                    comando1.ExecuteNonQuery();
                    MessageBox.Show("El registro se ha agregado");
                    txtb_id.Clear();
                  txtb_nombre.Clear();
                    txb_telefono.Clear();
                    cbx_puesto.SelectedIndex = -1;
                   dtp_fecha.Value=DateTime.Now;
                     txb_correo.Clear();
                    txb_direccion.Clear();
                     txb_salario.Clear();
                    
                }
                catch (Exception E)
                {
                    MessageBox.Show("Hubo un error, ingrese todos los datos correctamente");

                }

            }
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
            */
        }

        private void cbx_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string puestoelegido = cbx_puesto.Text;
            SqlConnection Conn = new SqlConnection(cadenaConex);
            SqlCommand Comm1 = new SqlCommand("Select salario from Puesto Where puesto='" + puestoelegido + "'", Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                txb_salario.Text = DR1.GetValue(0).ToString();
            }
            Conn.Close();
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txb_salario_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        public string puestonombre(string puesto)
        {
           
            SqlConnection Conn = new SqlConnection(cadenaConex);
            SqlCommand Comm1 = new SqlCommand("Select puesto_id from Puesto Where puesto='" + puesto + "'", Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                puesto = DR1.GetValue(0).ToString();
            }
            Conn.Close();
            return puesto;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
             /*void EliminarEmpleado(empleadoid)
            {
                string cadenaSQL = "Delete Empleados Where empleado_id=" + empleadoid;
                SqlConnection conectar = new SqlConnection(cadenaConex);
                SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
                conectar.Open();
                comando.ExecuteNonQuery();
                conectar.Close();
                conectar.Dispose();
                comando.Dispose();
             */
            }
        }
    }

