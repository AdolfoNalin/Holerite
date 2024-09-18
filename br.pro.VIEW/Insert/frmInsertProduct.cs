using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
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
    public partial class frmInsertProduct : Form
    {
        public frmInsertProduct()
        {
            InitializeComponent();
        }

        #region Load
        private void frmInsertProduct_Load(object sender, EventArgs e)
        {
            cbSupplier.DataSource = new SupplierDAO().Consult();
            cbSupplier.ValueMember = "Código";
            cbSupplier.DisplayMember = "Nome Fantasia";

            cbEmployee.DataSource = new EmployeeDAO().Consult();
            cbEmployee.ValueMember = "Código";
            cbEmployee.DisplayMember = "Nome";
        }
        #endregion

        #region btnInsert_Click
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product obj = new Product()
            {
                ShortDescription = txtShortDescription.Text,
                FullDescription = txtFullDescription.Text,
                SpotPrice = float.Parse(txtSpotPrice.Text),
                TermPrice = float.Parse(txtTermPrice.Text),
                Amount = int.Parse(txtAmount.Text),
                CA = mtbCA.Text,
                CodSupplier = int.Parse(cbSupplier.SelectedValue.ToString()),
                CodEmp = int.Parse(cbEmployee.SelectedValue.ToString()),
                Obs = txtOBS.Text
            };

            ProductDAO da = new ProductDAO();
            da.Insert(obj);
        }
        #endregion

        #region btnEdit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Product obj = new Product()
            {
                Cod = int.Parse(txtCod.Text),
                ShortDescription = txtShortDescription.Text,
                FullDescription = txtFullDescription.Text,
                SpotPrice = float.Parse(txtSpotPrice.Text),
                TermPrice = float.Parse(txtTermPrice.Text),
                Amount = int.Parse(txtAmount.Text),
                CA = mtbCA.Text,
                CodSupplier = int.Parse(cbSupplier.ValueMember),
                CodEmp = int.Parse(cbEmployee.ValueMember),
                Obs = txtOBS.Text
            };

            ProductDAO da = new ProductDAO();
            da.Update(obj);
        }
        #endregion

        #region Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCod.Text);

            ProductDAO dao = new ProductDAO();
            dao.Delete(cod);
        }
        #endregion
    }
    
}
