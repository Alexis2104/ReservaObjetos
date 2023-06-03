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
    public partial class frmObjetos : Form
    {
        public frmObjetos()
        {
            InitializeComponent();
        }

        private void tbObjetoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbObjetoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdReservaumgDataSet);

        }

        private void tbEmpresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbEmpresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdReservaumgDataSet);

        }

        private void tbEmpresaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbEmpresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdReservaumgDataSet);

        }

        private void frmObjetos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet.tbObjeto' Puede moverla o quitarla según sea necesario.
            this.tbObjetoTableAdapter.Fill(this.bdReservaumgDataSet.tbObjeto);
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet.tbObjeto' Puede moverla o quitarla según sea necesario.
            this.tbObjetoTableAdapter.Fill(this.bdReservaumgDataSet.tbObjeto);
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet.tbEmpresa' Puede moverla o quitarla según sea necesario.
            this.tbEmpresaTableAdapter.Fill(this.bdReservaumgDataSet.tbEmpresa);

        }
    }
}
