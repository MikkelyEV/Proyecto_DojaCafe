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
    public partial class Ventas : Form
    {

        string cadenaConex=(@"Data Source = QUESADILLA; Initial Catalog = DOJACAFE; Integrated Security = True;MultipleActiveResultSets=True");
        public Ventas()
        {
            InitializeComponent();
        }

        private void nombre_lbl_Click(object sender, EventArgs e)
        {

        }

        private void btn_bitacora_Click(object sender, EventArgs e)
        {
            Bitacora_ventas bitacora_ventas = new Bitacora_ventas();
            bitacora_ventas.Show();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                String Folio_Actual = txb_folio.Text;
                String IDempleado = cbx_empleado.Text;
                String IDcliente = cbx_cliente.Text;
                String IDproducto = cbx_prod.Text;
                Int32 Cantidad = Int32.Parse((String)txb_cantidad.Text);
                Int32 total = Int32.Parse((String)txb_total.Text);
                DateTime Fecha = dtp_fecha.Value.Date;
                string Fecha1 = Fecha.Date.ToString("MM/dd/yyyy");
                SqlConnection conn = new SqlConnection(cadenaConex);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlCommand command = new SqlCommand("EXECUTE dbo.InsertarVenta'"+ Folio_Actual + "','" + Fecha1 + "','" + IDcliente + "','" + IDempleado + "','" + IDproducto + "'," + Cantidad + "," + total, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro de venta fallido");
            }
            
            cbx_prod.SelectedItem = null;
            cbx_empleado.SelectedItem = null;
            cbx_cliente.SelectedItem = null;
            txb_total.Clear();
            txb_cantidad.Clear();
            folio(cadenaConex);
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cbx_empleado.SelectedIndex = -1;
            cbx_prod.SelectedIndex = -1;
            cbx_cliente.SelectedIndex = -1;
            SqlConnection conectar = new SqlConnection(cadenaConex);
            conectar.Open();
            SqlCommand sc = new SqlCommand("select empleado_id from EMPLEADO", conectar);
            SqlCommand sc2 = new SqlCommand("select producto_id from producto", conectar);
            SqlCommand sc3 = new SqlCommand("select cliente_id from CLIENTE", conectar);
            SqlDataReader reader;
            SqlDataReader reader2;
            SqlDataReader reader3;

            reader = sc.ExecuteReader();
            reader2 = sc2.ExecuteReader();
            reader3 = sc3.ExecuteReader();

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            dt.Columns.Add("empleado_id", typeof(string));
            dt2.Columns.Add("producto_id", typeof(string));
            dt3.Columns.Add("cliente_id", typeof(string));

            dt.Load(reader);
            dt2.Load(reader2);
            dt3.Load(reader3);


            cbx_empleado.DisplayMember = "empleado_id";
            cbx_empleado.DataSource = dt;
            cbx_empleado.SelectedItem = null;

            cbx_prod.DisplayMember = "producto_id";
            cbx_prod.DataSource = dt2;
            cbx_prod.SelectedItem = null;

            cbx_cliente.DisplayMember = "cliente_id";
            cbx_cliente.DataSource = dt3;
            cbx_cliente.SelectedItem = null;

            conectar.Close();
            //FOLIO
            folio(cadenaConex);
        }

        private void cbx_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_prod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txb_folio_TextChanged(object sender, EventArgs e)
        {

        }

        public void folio (string cadenacone)
        {
            SqlConnection conectarf = new SqlConnection(cadenacone);
            conectarf.Open();
            SqlCommand scf = new SqlCommand("SELECT COUNT(*) FROM venta", conectarf);
            int folio = Convert.ToInt32(scf.ExecuteScalar()) + 1;
            txb_folio.Text = folio.ToString();
            conectarf.Close();
        }

        private void txb_cant_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txb_cant_TabStopChanged(object sender, EventArgs e)
        {
        }

        private void txb_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txb_cantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_cantidad.Text == string.Empty)
                {
                    txb_cantidad.TextChanged -= txb_cantidad_TextChanged;
                    txb_cantidad.Clear();
                    txb_total.Clear();
                    txb_cantidad.TextChanged += txb_cantidad_TextChanged;
                    return;
                }
                string id_prod = cbx_prod.Text;
                int cantidad;
                int total;
                int.TryParse(txb_cantidad.Text, out cantidad);
                string cadenaSQL = "SELECT precio FROM PRODUCTO where producto_id=" + id_prod;
                SqlConnection conectar = new SqlConnection(cadenaConex);
                conectar.Open();
                SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
                total = ((int)comando.ExecuteScalar()) * (cantidad);
                conectar.Close();
                txb_total.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en cantidad");
            }
        }

        private void txb_cantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
