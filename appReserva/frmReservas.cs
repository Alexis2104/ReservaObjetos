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
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }

        private void tbEmpresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbEmpresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdReservaumgDataSet);

        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet.tbCliente' Puede moverla o quitarla según sea necesario.
            this.tbClienteTableAdapter.Fill(this.bdReservaumgDataSet.tbCliente);
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet.tbReserva' Puede moverla o quitarla según sea necesario.
            this.tbReservaTableAdapter.Fill(this.bdReservaumgDataSet.tbReserva);
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet.tbObjeto' Puede moverla o quitarla según sea necesario.
            this.tbObjetoTableAdapter.Fill(this.bdReservaumgDataSet.tbObjeto);
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet.tbEmpresa' Puede moverla o quitarla según sea necesario.
            this.tbEmpresaTableAdapter.Fill(this.bdReservaumgDataSet.tbEmpresa);

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string vid1;

            //Devolver el valor de la fila actual
            vid1 = tbObjetoDataGridView.Rows[tbObjetoDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();

            this.tbReservaTableAdapter.agregarReserva(Convert.ToInt32(vid1), dtmInicio.Value, dtmFin.Value, Convert.ToInt32(idCliente.SelectedValue), "asd");
            //Console.WriteLine(idCliente.SelectedValue);

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarR_Click(object sender, EventArgs e)
        {
            string vid;

            //Devolver el valor de la fila actual
            vid = tbObjetoDataGridView.Rows[tbObjetoDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.tbReservaTableAdapter.eliminarReserva(Convert.ToInt32(vid));
            this.tbObjetoTableAdapter.Fill(this.bdReservaumgDataSet.tbObjeto);
        }
    }
}


