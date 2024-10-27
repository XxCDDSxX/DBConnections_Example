Imports Npgsql 'Importacion de Npgsql
Public Class FormVB
    'String de conexión
    Dim strConexion As New NpgsqlConnectionStringBuilder With {
        .Host = "localhost",
        .Port = 5432,
        .Database = "ejemplo_db",
        .Username = "cdds",
        .Password = "1234"
    }
    'Objeto de conexión
    Dim conexion As New NpgsqlConnection With {
        .ConnectionString = strConexion.ConnectionString
    }

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Objeto para ejecutar comando
        Dim comando As New NpgsqlCommand With {
            .Connection = conexion,
            .CommandText = "INSERT INTO main.usuarios(id, nombre, correo) VALUES(@id, @nombre, @correo)"
        }
        'Parámetros de la consulta
        comando.Parameters.AddWithValue("id", Convert.ToInt64(txtID.Text))
        comando.Parameters.AddWithValue("nombre", txtNombre.Text)
        comando.Parameters.AddWithValue("correo", txtCorreo.Text)
        'Ejcución
        Try
            comando.Connection.Open()
            If comando.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Usuario Agregado")
            End If
            comando.Connection.Close()
            txtID.Text = ""
            txtNombre.Text = ""
            txtCorreo.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
