using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Insert;
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
    public partial class frmConsultBudget : Form
    {
        public frmConsultBudget()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultBudget_Load(object sender, EventArgs e)
        {
            BudgetDAO dao = new BudgetDAO();
            dgBudget.DataSource = dao.Consult();
        }
        #endregion

        #region txtCod_keypress
        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BudgetDAO dao = new BudgetDAO();
                dgBudget.DataSource = dao.Consult(int.Parse(txtCod.Text));
            }
        }
        #endregion

        #region tbnNameClient_keypress
        private void txtNameClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            BudgetDAO dao = new BudgetDAO();
            dgBudget.DataSource = dao.Consult(txtNameClient.Text);
        }
        #endregion

        #region btnSearch for Date
        private void btnSeach_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(dtpStart.Text);
            DateTime endtDate = DateTime.Parse(dtpEnd.Text);

            BudgetDAO dao = new BudgetDAO();
            dgBudget.DataSource = dao.Consult(startDate, endtDate);
        }
        #endregion

        #region dgBudget_CellClick
        private void dgBudget_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            ItemBudgetDAO dao = new ItemBudgetDAO();

            dt = dao.Consult(int.Parse(dgBudget.CurrentRow.Cells[0].Value.ToString()));

            frmInsertBudget tela = new frmInsertBudget();
            tela.txtCodBudget.Text = dgBudget.CurrentRow.Cells[0].Value.ToString();
            tela.mtbDate.Text = dgBudget.CurrentRow.Cells[1].Value.ToString();
            string payment = dgBudget.CurrentRow.Cells[2].Value.ToString();
            tela.dgBudget.DataSource = dt;
            tela.cbEmployee.Text = dgBudget.CurrentRow.Cells[3].Value.ToString();
            tela.cbClient.Text = dgBudget.CurrentRow.Cells[4].Value.ToString();
            tela.txtSubtotal.Text = dgBudget.CurrentRow.Cells[5].Value.ToString();
            tela.txtTotal.Text = dgBudget.CurrentRow.Cells[5].Value.ToString();
            tela.txtObs.Text = dgBudget.CurrentRow.Cells[6].Value.ToString();

            if (payment == "Vista")
            {
                tela.rbSpot.Checked = true;
            }
            else
            {
                tela.rbTerm.Checked = true;
            }

            tela.ShowDialog();
        }
        #endregion
    }
}