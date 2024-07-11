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
            frmInsertProduct tela = new frmInsertProduct();
            Product obj = new Product();

            tela.txtCod.Text = dgProduct.CurrentRow.Cells[0].Value.ToString();
            tela.txtShortDescription.Text = dgProduct.CurrentRow.Cells[1].Value.ToString();
            tela.txtFullDescription.Text = dgProduct.CurrentRow.Cells[2].Value.ToString();
            tela.cbSupplier.Text = dgProduct.CurrentRow.Cells[3].Value.ToString();
            tela.cbEmployee.Text = dgProduct.CurrentRow.Cells[4].Value.ToString();
            tela.txtAmount.Text = dgProduct.CurrentRow.Cells[5].Value.ToString();
            tela.txtSpotPrice.Text = dgProduct.CurrentRow.Cells[6].Value.ToString();
            tela.txtTermPrice.Text = dgProduct.CurrentRow.Cells[7].Value.ToString();
            tela.mtbCA.Text = dgProduct.CurrentRow.Cells[8].Value.ToString();
            tela.txtOBS.Text = dgProduct.CurrentRow.Cells[9].Value.ToString();

            tela.ShowDialog();
        }
        #endregion
    }
}
