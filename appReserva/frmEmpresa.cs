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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdReservaumgDataSet1.tbEmpresa' Puede moverla o quitarla según sea necesario.
            this.tbEmpresaTableAdapter.Fill(this.bdReservaumgDataSet1.tbEmpresa);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.tbEmpresaTableAdapter.insertarEmpresa(txtEmpresa.Text);
            this.tbEmpresaTableAdapter.Fill(this.bdReservaumgDataSet1.tbEmpresa);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string vid;

            //Devolver el valor de la fila actual
            vid = tbEmpresaDataGridView.Rows[tbEmpresaDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //Console.WriteLine(vid);
            this.tbEmpresaTableAdapter.eliminarEmpresa(Convert.ToInt32(vid));
            this.tbEmpresaTableAdapter.Fill(this.bdReservaumgDataSet1.tbEmpresa);
        }
    }
}
