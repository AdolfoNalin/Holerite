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
    public partial class frmConsultProduct : Form
    {
        public frmConsultProduct()
        {
            InitializeComponent();
        }

        #region Laod
        private void frmConsultProduct_Load(object sender, EventArgs e)
        {
            ProductDAO dao = new ProductDAO();
            dgProduct.DataSource = dao.Consult();
        }
        #endregion

        #region txtShortDescription_Keypress
        private void txtShortDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            string description = txtShortDescription.Text;
            ProductDAO dao = new ProductDAO();
            dgProduct.DataSource = dao.Consult(description);
        }
        #endregion

        #region Search_click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string description = txtShortDescription.Text;
            ProductDAO dao = new ProductDAO();
            dgProduct.DataSource = dao.Search(description);
        }
        #endregion

        #region dgProduct_click
        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
