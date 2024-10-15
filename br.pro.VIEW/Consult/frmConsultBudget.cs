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
            this.Hide();
        }
        #endregion
    }
}