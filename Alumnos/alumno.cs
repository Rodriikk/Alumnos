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
using Alumnos.Conexion;

namespace Alumnos
{
    public partial class alumnos : Form
    {
        alum alum = new alum();
        Cone c = new Cone();

        public alumnos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sqlServer = "insert into alumnos(nombre, apellido, edad, dni, legajo) " +
                "values('" + txtNombre.Text + "','" + txtApellido.Text + "'," + txtEdad.Text + ", " + txtDNI.Text + "," + txtLegajo.Text + ")";

            // Crear un comando con la consulta y la conexión
            using (SqlCommand comando = new SqlCommand(sqlServer, c.con))
            {
                comando.ExecuteNonQuery();

            }
            MessageBox.Show("Se han registrado los datos con exito!");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cargarTabla()
        {
            c.abrirConexion();
            string cadena = "SELECT * FROM alumnos";
            SqlCommand comando = new SqlCommand(cadena, c.con);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            tablaDatos.DataSource = tabla;
        }

        private void alumnos_Load(object sender, EventArgs e)
        {
            //tablaDatos.DataSource = c.SelectDataTable("select * from alumnos");
            
            cargarTabla();

        }
    }
}
