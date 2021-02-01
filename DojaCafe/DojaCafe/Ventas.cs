using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DojaCafe
{
    public partial class Ventas : Form
    {
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
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[18];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var Folio = new String(stringChars);
           
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

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
    }
}
