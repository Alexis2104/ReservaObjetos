using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appReserva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa frmEmpresa = new frmEmpresa();
            frmEmpresa.ShowDialog();
        }

        private void objetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObjetos frmObjetos = new frmObjetos();
            frmObjetos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }
    }
}
