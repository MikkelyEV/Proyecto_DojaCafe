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
    }
}
