using Holerite.br.pro.DAO;
using Holerite.br.pro.VIEW.Consult;
using Holerite.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite.br.pro.VIEW.Insert
{
    public partial class frmInsertBudget : Form
    {
        public frmInsertBudget()
        {
            InitializeComponent();
        }

        #region Load
        private void frmInsertBudget_Load(object sender, EventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            cbEmployee.DataSource = dao.Consult();
            cbEmployee.SelectedValue = "id";
            cbEmployee.DisplayMember = "Name";
        }
        #endregion

        #region btnAdd_click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbSpot.Checked == false && rbTerm.Checked == false)
            {
                Dialog.Message("Por favor selecione a forma de pagamento!", "atenção");
            }
            else
            {
                
            }
        }

        #endregion

        #region btnSearch
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmConsultarClient tela = new frmConsultarClient();
            tela.ShowDialog();
        }
        #endregion

        #region 
        private void btnSearchSeverce_Click(object sender, EventArgs e)
        {
           
        }
        #endregion
    }
}
