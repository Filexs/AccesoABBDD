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
    public partial class VentanaInicial : Form
    {
        public VentanaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new VentanaFran().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VentanaAlvaro().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new VentanaPedro().ShowDialog();
        }
    }
}
