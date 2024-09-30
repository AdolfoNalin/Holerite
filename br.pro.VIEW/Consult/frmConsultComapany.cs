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
            Company obj = new Company()
            { 
                Cod = int.Parse(dgCompany.CurrentRow.Cells[0].Value.ToString()),
                Name = dgCompany.CurrentRow.Cells[1].Value.ToString(),
                FantasyName = dgCompany.CurrentRow.Cells[2].Value.ToString(),
                CPF = dgCompany.CurrentRow.Cells[3].Value.ToString(),
                CNPJ = dgCompany.CurrentRow.Cells[4].Value.ToString(),
                TelephoneNumber = dgCompany.CurrentRow.Cells[5].Value.ToString(),
                PhoneNumber = dgCompany.CurrentRow.Cells[6].Value.ToString(),
                Email = dgCompany.CurrentRow.Cells[7].Value.ToString(),
                CEP = dgCompany.CurrentRow.Cells[8].Value.ToString(),
                State = dgCompany.CurrentRow.Cells[9].Value.ToString(),
                City = dgCompany.CurrentRow.Cells[10].Value.ToString(),
                Neighborhood = dgCompany.CurrentRow.Cells[11].Value.ToString(),
                Street = dgCompany.CurrentRow.Cells[12].Value.ToString(),
                HomeNumber = int.Parse(dgCompany.CurrentRow.Cells[13].Value.ToString()),
                Complement = dgCompany.CurrentRow.Cells[14].Value.ToString(),
            };

            frmCompany tela = new frmCompany();

            tela.txtCod.Text = obj.Cod.ToString();
            tela.txtName.Text = obj.Name.ToString();
            tela.mtbCpf.Text = obj.CPF.ToString();
            tela.mtbCNPJ.Text = obj.CNPJ.ToString();
            tela.txtEmail.Text = obj.Email.ToString();
            tela.cbUF.Text = obj.State.ToString();
            tela.txtCity.Text = obj.City.ToString();
            tela.txtNeighborhood.Text = obj.Neighborhood.ToString();
            tela.txtStreet.Text = obj.Street.ToString();
            tela.txtHomeNumber.Text = obj.HomeNumber.ToString();
            tela.txtFantasyName.Text = obj.FantasyName.ToString();
            tela.mtbCEP.Text = obj.CEP.ToString();
            tela.txtComplement.Text = obj.Complement.ToString();
            tela.mtbTelephoneNumber.Text = obj.TelephoneNumber.ToString();
            tela.mtbPhoneNumber.Text = obj.PhoneNumber.ToString();

            tela.ShowDialog();  
        }
        #endregion
    }
}
