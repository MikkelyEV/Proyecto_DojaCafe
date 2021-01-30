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
    public partial class Form1 : Form
    {

        System.Boolean Bandera = false;
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
            if (txtb_usuario.Text == "admin" && txtb_password.Text == "123")
            {
                Bandera = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("User y/o Password incorrectos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
