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
    public partial class frmConsultComapany : Form
    {
        public frmConsultComapany()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultComapany_Load(object sender, EventArgs e)
        {
            CompanyDAO dao = new CompanyDAO();
            dgCompany.DataSource = dao.Consult();
        }
        #endregion

        #region txtSerach_keypress
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            CompanyDAO dao = new CompanyDAO();
            dgCompany.DataSource = dao.Consult(txtSearch.Text);
        }
        #endregion

        #region btnSearch_click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            CompanyDAO dao = new CompanyDAO();
            dgCompany.DataSource = dao.Search(txtSearch.Text);
        }
        #endregion

        #region dgCompany_cellContentclick
        private void dgCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           this.Hide();
        }
        #endregion
    }
}
