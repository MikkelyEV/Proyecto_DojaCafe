﻿using System;
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
    public partial class Bitacora_ventas : Form
    {
        public Bitacora_ventas()
        {
            InitializeComponent();
        }

        private void Bitacora_ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dOJACAFEDataSet.VENTA' Puede moverla o quitarla según sea necesario.
            string cadenaConex = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mikel\source\repos\MikkelyEV\Proyecto_DojaCafe - Final\DojaCafe\DojaCafe\DojaCafe.mdf; Integrated Security = True";
            string cadenaSQL = "SELECT * FROM VENTA ORDER BY folio";
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
            dgv_ventas.AutoGenerateColumns = true;
            dgv_ventas.DataSource = dt;
        }

        private void dgv_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
