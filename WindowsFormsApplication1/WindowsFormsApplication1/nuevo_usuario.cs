using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class nuevo_usuario : Form
    {

        public nuevo_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //He obtenido el cómo insertar datos en access desde C# a través de la página oficial de Microsoft
		        OleDbConnection conexion = new OleDbConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
		        conexion.Open();
		
		        string insertar = "INSERT INTO Usuarios VALUES ( @id_usuario, @nombre_usuario, @contraseña_usuario)";
		        OleDbCommand cmd = new OleDbCommand(insertar, conexion);
                cmd.Parameters.AddWithValue("@id_usuario", txt_id.Text);
		        cmd.Parameters.AddWithValue("@nombre_usuario", txt_usuario.Text);
                cmd.Parameters.AddWithValue("@contraseña_usuario", txt_password.Text);
	
		        cmd.ExecuteNonQuery();
		        MessageBox.Show("Usuario guardado");
            }
            catch (Exception mensaje)
            {
                //Mostramos un error producido debido a un error en el try, no sabemos el error específico.
                MessageBox.Show(mensaje.Message, "Error");
            }
        }
    }
}
