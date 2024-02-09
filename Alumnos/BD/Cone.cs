using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alumnos.Conexion
{
    class Cone
    {
        public SqlConnection con = new SqlConnection();
        string connectionString = "Data Source =DESKTOP-K7PE792\\SQLEXPRESS;Initial Catalog=Alumnos; Integrated Security=True; User ID=sa; Password=123";
        
        public Cone() 
        {
            con.ConnectionString = connectionString;
        }

        public void abrirConexion()
        {
            try
            {
                con.Open();
                Console.WriteLine("Conexion Exitosa!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion." + ex.ToString());
            }
        }

        public void cerrarConexion()
        {
            try
            {
                con.Close();
                Console.WriteLine("Conexion cerrada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexion." + ex.ToString());
            }
        }

    }
}
