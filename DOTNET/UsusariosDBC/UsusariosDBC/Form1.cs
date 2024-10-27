using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace UsusariosDBC
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conexion;//Objeto de conexión
        public Form1()
        {
            InitializeComponent();
            conexion = new NpgsqlConnection();
            //Creador del string de conexión
            NpgsqlConnectionStringBuilder strConexion = new NpgsqlConnectionStringBuilder()
            {
                Host = "localhost",
                Port = 5432,
                Database = "ejemplo_db",
                Username = "cdds",
                Password = "1234"
            };
            //Se le asigna el string de conexión
            conexion.ConnectionString = strConexion.ConnectionString;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                txtResultadoConexion.Text = $"Conectado a: {conexion.Database}" + Environment.NewLine +
                    $"Servidor: {conexion.Host}" + Environment.NewLine +
                    $"Puerto:{conexion.Port}"+ Environment.NewLine +
                    $"Usuario:{conexion.UserName}";                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if(conexion.State is ConnectionState.Open)
                    conexion.Close();
                txtResultadoConexion.Text = $"Desconectado de: {conexion.Database}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFormVB_Click(object sender, EventArgs e)
        {
            UsuariosDBC_VB.FormVB formVB = new UsuariosDBC_VB.FormVB();
            formVB.ShowDialog();
        }

        private void btnFormCShapr_Click(object sender, EventArgs e)
        {
            Form2 formCsharp = new Form2();
            formCsharp.ShowDialog();
        }
    }
}
