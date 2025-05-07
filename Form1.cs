using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNmostrar_Click(object sender, EventArgs e)
        {
            DgDatos.DataSource = acc.Mostrar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (acc.ExportarExcel())
                MessageBox.Show("Exportado con exito");
            else
                MessageBox.Show("Fallo al exportarlo");
        }

        private void BTNimportar_Click(object sender, EventArgs e)
        {
            if (acc.ImportarExcel())
                MessageBox.Show("importado con exito");
            else
                MessageBox.Show("Fallo al importarlo");
        }
    }
}
