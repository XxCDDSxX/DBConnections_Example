using System;
using System.Windows.Forms;
using Npgsql; //Importación de Npgsql
namespace UsusariosDBC
{
    public partial class Form2 : Form
    {
        //Objeto de conexión
        NpgsqlConnection conexion;
        public Form2()
        {
            InitializeComponent();
            conexion = new NpgsqlConnection();
            //String de conexión
            NpgsqlConnectionStringBuilder strConnexion = new NpgsqlConnectionStringBuilder()
            {
                Host = "localhost",
                Port = 5432,
                Database = "ejemplo_db",
                Username = "cdds",
                Password = "1234"
            };
            conexion.ConnectionString = strConnexion.ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Objeto para ejecutar comandos
            NpgsqlCommand comando = new NpgsqlCommand()
            {
                Connection = conexion,
                CommandText = "INSERT INTO main.usuarios(id, nombre, correo) VALUES(@id, @nombre, @correo)"
            };
            //Parámetros de la consulta
            comando.Parameters.AddWithValue("id", Convert.ToInt64(txtID.Text));
            comando.Parameters.AddWithValue("nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("correo", txtCorreo.Text);
            //Ejecución
            try
            {
                comando.Connection.Open();
                if (comando.ExecuteNonQuery() == 1)
                    MessageBox.Show("Usuario Agregado");
                comando.Connection.Close();
                txtID.Text = "";
                txtNombre.Text = "";
                txtCorreo.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
