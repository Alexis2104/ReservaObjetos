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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdReservaumgDataSet);

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet.tbCliente' Puede moverla o quitarla según sea necesario.
            this.tbClienteTableAdapter.Fill(this.bdReservaumgDataSet.tbCliente);

        }
    }
}
