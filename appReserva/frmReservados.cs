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
    public partial class frmReservados : Form
    {
        public frmReservados()
        {
            InitializeComponent();
        }

        private void tbReservaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.tbReservaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdReservaumgDataSet);

        }

        private void frmReservados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet.vReservados' Puede moverla o quitarla según sea necesario.
            this.vReservadosTableAdapter.Fill(this.bdReservaumgDataSet.vReservados);

        }
    }
}
