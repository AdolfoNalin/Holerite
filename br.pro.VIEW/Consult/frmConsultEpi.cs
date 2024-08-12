using Holerite.br.pro.DAO;
using Holerite.br.pro.VIEW.Insert;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite.br.pro.VIEW.Consult
{
    public partial class frmConsultEpi : Form
    {
        public frmConsultEpi()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultEpi_Load(object sender, EventArgs e)
        {
            dgEpi.DataSource = new EpiDAO().Consult();
        }
        #endregion

        #region txtName_KeyPress
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = "%" + txtName.Text + "%";

            EpiDAO dao = new EpiDAO();
            dgEpi.DataSource = dao.Consult(name);
        }
        #endregion

        #region btnSearch_click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            EpiDAO dao = new EpiDAO();
            dgEpi.DataSource = dao.Search(txtName.Text);
        }
        #endregion

        #region dgEpi_CellClick
        private void dgEpi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemEpiDAO dao = new ItemEpiDAO();
            frmInsertEPI tela = new frmInsertEPI();
            tela.rbSpot.Checked =  dgEpi.CurrentRow.Cells[3].Value.ToString() == "vista" ? true : tela.rbTerm.Checked = false;

            int cod = int.Parse(dgEpi.CurrentRow.Cells[0].Value.ToString());
            tela.txtCodEpi.Text = cod.ToString();
            tela.mtbDate.Text = dgEpi.CurrentRow.Cells[1].Value.ToString();
            tela.cbEmployee.Text = dgEpi.CurrentRow.Cells[2].Value.ToString();
            tela.txtTotal.Text = dgEpi.CurrentRow.Cells[4].Value.ToString();
            tela.dgEPI.DataSource = dao.Search(cod);
            this.Hide();
            tela.ShowDialog();
        }
        #endregion
    }
}
