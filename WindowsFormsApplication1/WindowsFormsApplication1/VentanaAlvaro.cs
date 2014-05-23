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
    public partial class VentanaAlvaro : Form
    {
        public VentanaAlvaro()
        {
            InitializeComponent();
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwind_2007DataSet);

        }

        private void VentanaAlvaro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwind_2007DataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.northwind_2007DataSet.Empleados);

        }
    }
}
