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
    public partial class Login : Form
    {

        //Este login está basado en un vídeo de FernandoR2D de youtube.

        OleDbConnection conexion = new OleDbConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);

        public Login()
        {
            InitializeComponent();
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_password.Text != "" && txt_usuario.Text != "")
                {
                    //Creamos una variable donde guardar la consulta deseada, en este caso, un string
                    String consulta = "SELECT id_usuario FROM Usuarios WHERE nombre_usuario = '" + txt_usuario.Text + "' AND contraseña_usuario = '" + txt_password.Text + "'";

                    //Se enlaza la consulta con la BBDD
                    OleDbCommand sql = new OleDbCommand(consulta, conexion);

                    //Se abre la BBDD
                    conexion.Open();

                    //Comprobamos que la consulta no ha dado una respuesta null.
                    //En el caso en el que fuera null, significaría que no hay ningún usuario que coincida con esa constraseña
                    if (sql.ExecuteScalar() != null) 
                    { 
                        //Primero nos ponemos en el caso en el que no sea null, es decir, que el usuario exista e iniciamos sesión
                       
                        //Mostramos un mensaje como que se ha iniciado sesión 

                        //lo del mensaje lo he sacado de la página oficial de windows
                        MessageBox.Show("Sesión iniciada como " + txt_usuario.Text + ".", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        new ventanaParaVistas().ShowDialog();
                    }
                    else
                    {
                        //Si la cuenta no existe decimos que los datos son erróneos y borramos los campos.

                        MessageBox.Show("Usuario o contraseña incorrecta", "Error");

                        //Se limpian los textbox:
                        txt_usuario.Clear();
                        txt_password.Clear();
                        
                        //Devolvemos el foco al textbox del usuario
                        txt_usuario.Focus();
                    }
                    //Cerramos la conexión
                    conexion.Close();
                }
            }
            catch (Exception mensaje)
            {
                //Mostramos un error producido debido a un error en el try, no sabemos el error específico.
                MessageBox.Show(mensaje.Message, "Error");
            }
        }

        private void crear_Click(object sender, EventArgs e)
        {
            new nuevo_usuario().ShowDialog();
        }
    }
}
