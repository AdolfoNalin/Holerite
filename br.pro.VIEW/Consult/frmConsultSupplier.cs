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
    public partial class frmConsultSupplier : Form
    {
        public frmConsultSupplier()
        {
            InitializeComponent();
        }

        #region dgSupplier_DoubleClick
        private void dgSupplier_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Load
        private void frmConsultSupplier_Load(object sender, EventArgs e)
        {
            SupplierDAO dao = new SupplierDAO();
            dgSupplier.DataSource = dao.Consult();
        }
        #endregion

        #region txtName_keypress
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = "%" + txtName.Text + "%";

            SupplierDAO dao = new SupplierDAO();
            dgSupplier.DataSource = dao.Consult(name);
        }
        #endregion

        #region btnSearch_click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SupplierDAO dao = new SupplierDAO();
            dgSupplier.DataSource = dao.Search(txtName.Text);
        }
        #endregion
    }
}
