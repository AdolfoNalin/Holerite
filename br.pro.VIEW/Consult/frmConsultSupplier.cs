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

        #region
        private void dgSupplier_DoubleClick(object sender, EventArgs e)
        {
            frmSupplier tela = new frmSupplier();
            Supplier obj = new Supplier();

            obj.Cod = int.Parse(dgSupplier.CurrentRow.Cells[0].Value.ToString());
            obj.Name = dgSupplier.CurrentRow.Cells[1].Value.ToString();
            obj.CPF = dgSupplier.CurrentRow.Cells[2].Value.ToString();
            obj.Email = dgSupplier.CurrentRow.Cells[3].Value.ToString();
            obj.TelephoneNumber = dgSupplier.CurrentRow.Cells[4].Value.ToString();
            obj.PhoneNumber = dgSupplier.CurrentRow.Cells[5].Value.ToString();
            obj.State = dgSupplier.CurrentRow.Cells[6].Value.ToString();
            obj.City = dgSupplier.CurrentRow.Cells[7].Value.ToString();
            obj.Neighborhood = dgSupplier.CurrentRow.Cells[8].Value.ToString();
            obj.Street = dgSupplier.CurrentRow.Cells[9].Value.ToString();
            obj.HomeNumber = int.Parse(dgSupplier.CurrentRow.Cells[10].Value.ToString());
            obj.FantasyName = dgSupplier.CurrentRow.Cells[11].Value.ToString();
            obj.CEP = dgSupplier.CurrentRow.Cells[12].Value.ToString();
            obj.Complement = dgSupplier.CurrentRow.Cells[13].Value.ToString();

            tela.txtCod.Text = obj.Cod.ToString();
            tela.txtName.Text = obj.Name.ToString();
            tela.mtbCNPJ.Text = obj.CPF.ToString();
            tela.txtEmail.Text = obj.Email.ToString();
            tela.mtbTelephoneNumber.Text = obj.TelephoneNumber.ToString();
            tela.mtbPhoneNumber.Text = obj.PhoneNumber.ToString();
            tela.cbUF.Text = obj.State.ToString();
            tela.txtCity.Text = obj.City.ToString();
            tela.txtNeighborhood.Text = obj.Neighborhood.ToString();
            tela.txtStreet.Text = obj.Street.ToString();
            tela.txtHomeNumber.Text = obj.HomeNumber.ToString();
            tela.mtbCEP.Text = obj.CEP.ToString();
            tela.txtComplement.Text = obj.Complement.ToString();
            tela.txtFantasyName.Text = obj.FantasyName.ToString();

            tela.ShowDialog();
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
