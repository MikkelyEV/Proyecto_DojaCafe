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
    public partial class Bitacora_Empleado : Form
    {
        public Bitacora_Empleado()
        {
            InitializeComponent();
        }

        private void dgv_empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bitacora_Empleado_Load(object sender, EventArgs e)
        {
            string cadenaConex = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mikel\source\repos\MikkelyEV\Proyecto_DojaCafe-Final\DojaCafe\DojaCafe\DojaCafe.mdf;Integrated Security=True";

            string cadenaSQL = "SELECT * FROM EMPLEADO ORDER BY empleado_id";
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
            dgv_empleado.AutoGenerateColumns = true;
            dgv_empleado.DataSource = dt;
            

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
