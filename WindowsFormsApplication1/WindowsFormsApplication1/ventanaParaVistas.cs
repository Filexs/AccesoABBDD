using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ventanaParaVistas : Form
    {
        public ventanaParaVistas()
        {
            InitializeComponent();
        }

        private void boton_Fran_Click(object sender, EventArgs e)
        {
            new ventanaFran().ShowDialog();
        }

        private void boton_Alvaro_Click(object sender, EventArgs e)
        {
            new ventanaAlvaro().ShowDialog();
        }

        private void boton_Pedro_Click(object sender, EventArgs e)
        {
            new ventanaPedro().ShowDialog();
        }
    }
}
