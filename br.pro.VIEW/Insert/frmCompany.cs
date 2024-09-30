using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            
        }

        #region mtbCEP_keypress
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Address obj =  ConsultCEP.Consult(mtbCEP.Text);

                cbUF.Text = obj.State.ToString();
                txtCity.Text = obj.City.ToString();
                txtNeighborhood.Text = obj.Neighborhood.ToString();
                txtStreet.Text = obj.Street.ToString();
                txtHomeNumber.Text = obj.HomeNumber.ToString();
                txtComplement.Text = obj.Complement.ToString();
            }
        }
        #endregion

        #region btnInsert_click
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Company obj = new Company()
            {
                Name = txtName.Text,
                FantasyName = txtFantasyName.Text,
                CNPJ = mtbCNPJ.Text,
                Email = txtEmail.Text,
                CPF = mtbCpf.Text,
                CEP = mtbCEP.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                State = cbUF.Text,
                City = txtCity.Text,
                Neighborhood = txtNeighborhood.Text,
                Street = txtStreet.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                Complement = txtComplement.Text
            };

            CompanyDAO dao = new CompanyDAO();
            dao.Insert(obj);
        }
        #endregion

        #region Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCod.Text);

            new CompanyDAO().Delete(cod);   
        }
        #endregion

        #region btnEdit_click
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Company obj = new Company()
            {
                Cod = int.Parse(txtCod.Text),
                Name = txtName.Text,
                FantasyName = txtFantasyName.Text,
                CPF = mtbCpf.Text,
                CNPJ = mtbCNPJ.Text,
                Email = txtEmail.Text,
                CEP = mtbCEP.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                State = cbUF.Text,
                City = txtCity.Text,
                Neighborhood = txtNeighborhood.Text,
                Street = txtStreet.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                Complement = txtComplement.Text
            };

            CompanyDAO dao = new CompanyDAO();
            dao.Update(obj);
        }
        #endregion
    }
}
