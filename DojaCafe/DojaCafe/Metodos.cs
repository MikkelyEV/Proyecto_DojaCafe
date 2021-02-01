using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DojaCafe
{
    class Metodos
    {
        string cadenaConex = @"Data Source=MSI;Initial Catalog=DOJACAFE;Integrated Security=True";
        public Boolean Iniciar(int clave, string contra)
        {
            Boolean sesion = false;
            string cadenaSQL = "SELECT * FROM datos WHERE Clave =" + clave + "and Contrasena ='" + contra + "'";
            SqlConnection conectar = new SqlConnection(cadenaConex);
            SqlCommand Cmd = new SqlCommand(cadenaSQL, conectar);
            conectar.Open();
            SqlDataReader Reader;
            int Login = Cmd.ExecuteNonQuery();
            conectar.Close();
            if (Login == 0)
            {
                sesion = false;
            }
            else
            {
                sesion = true;
            }
            return sesion;
        }

        public Boolean CheckClave(int clave)
        {
            bool existe = false;
            string cadenaSQL = "Select * from datos Where Clave=@clave";

            SqlConnection conectar = new SqlConnection(cadenaConex);

            conectar.Open();
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            comando.Parameters.AddWithValue("@clave", clave);
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
            return existe;
        }


        public void Eliminar(int clave)
        {
            string cadenaSQL = "Delete datos Where Clave=" + clave;
            SqlConnection conectar = new SqlConnection(cadenaConex);
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
        }

        public void Actualizar(int clave, string nombre, string direccion, string contra)
        {
            string cadenaSQL = "Update datos Set Nombre='" + nombre + "',Direccion='" + direccion + "',Contrasena='" + contra + "' Where Clave=" + clave;
            SqlConnection conectar = new SqlConnection(cadenaConex);
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
        }


        public void Anadir(int clave, string nombre, string direccion, string contra)
        {
            string cadenaSQL = "Insert into datos (Clave,Nombre, Direccion, Contrasena) Values(" + clave + ",'" + nombre + "','" + direccion + "','" + contra + "')";
            SqlConnection conectar = new SqlConnection(cadenaConex);
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
        }
        //MÉTODOSPARA---EMPLEADOS
        public void EliminarEmpleado(int empleadoid)
        {
            string cadenaSQL = "Delete Empleados Where empleadoid=" + empleadoid;
            SqlConnection conectar = new SqlConnection(cadenaConex);
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
        }
        /*
        public void ModificarEmpleados(varchar empleado_id, varchar nombre, varchar telefono, varchar direccion, varchar correo, varchar puestoid, date fecha_nac, date fecha_con)
        {
            string cadenaSQL = "Update Empleados Set nombre='" + nombre + "',telefono='" + telefono + "',direccion='" + direccion + "',correo='"+ correo +"',puesto_id='"+ puesto_id + "' Where empleado_id=" + empleado_id;
            SqlConnection conectar = new SqlConnection(cadenaConex);
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
        }*/

    }


}
