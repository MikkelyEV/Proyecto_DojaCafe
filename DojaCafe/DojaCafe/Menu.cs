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
    public partial class Menu : Form
    {


        public Menu()
        {
            InitializeComponent();
            //Form1 login = new Form1();
            //login.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Empleados());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Ventas());
        }

        private void panel_izq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cerrar sesión");
            }
            //aqui se abre otro login
        }

        private void Label_Empleado_Click(object sender, EventArgs e)
        {

        }

        private void panel_izq_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(childForm);
            panel_menu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void panel_productos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boton_inventario_Click(object sender, EventArgs e)
        {
            openChildForm(new Inventario());
        }

        private void boton_clientes_Click(object sender, EventArgs e)
        {
            openChildForm(new Cliente());
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
