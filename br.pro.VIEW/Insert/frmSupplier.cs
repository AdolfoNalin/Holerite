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
using Holerite.Helpers;
using Holerite.br.pro.VIEW.Consult;

namespace Holerite.br.pro.VIEW.Insert
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        #region btnInsert_click
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Supplier obj = new Supplier()
            {
                Name = txtName.Text,
                CNPJ = mtbCNPJ.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                Email = txtEmail.Text,
                State = cbUF.Text,
                City = txtCity.Text,
                Neighborhood = txtNeighborhood.Text,
                Street = txtStreet.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                CEP = mtbCEP.Text,
                Complement = txtComplement.Text,
                FantasyName = txtFantasyName.Text
            };

            SupplierDAO dao = new SupplierDAO();
            dao.Insert(obj);

            DialogResult resp = MessageBox.Show("Deseja cadastrar outro Fornecedor", "atenção", MessageBoxButtons.YesNo);

            if(resp == DialogResult.No)
            {
                frmConsultSupplier tela = new frmConsultSupplier();
                this.Hide();
                tela.ShowDialog();
            }
        }
        #endregion

        #region mtbCEP
        /// <summary>
        /// API de consulta do CEP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Address obj = new Address();

                obj = ConsultCEP.Consult(mtbCEP.Text);

                cbUF.Text = obj.State;
                txtCity.Text = obj.City;
                txtNeighborhood.Text = obj.Neighborhood;
                txtStreet.Text = obj.Street;
                txtHomeNumber.Text = obj.HomeNumber;
                txtComplement.Text = obj.Complement;
            }
        }
        #endregion

        #region btnUpdate_click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Supplier obj = new Supplier()
            {
                Cod = int.Parse(txtCod.Text),
                Name = txtName.Text,
                CNPJ = mtbCNPJ.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                Email = txtEmail.Text,
                State = cbUF.Text,
                City = txtCity.Text,
                Neighborhood = txtNeighborhood.Text,
                Street = txtStreet.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                CEP = mtbCEP.Text,
                Complement = txtComplement.Text,
                FantasyName = txtFantasyName.Text
            };

            SupplierDAO dao = new SupplierDAO();
            dao.Upadate(obj);

            frmConsultSupplier tela = new frmConsultSupplier();
            this.Hide();
            tela.ShowDialog();
        }
        #endregion

        #region
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCod.Text);

            if (cod > 0)
            {
                SupplierDAO dao = new SupplierDAO();
                dao.Delete(cod);

                frmConsultSupplier tela = new frmConsultSupplier();
                this.Hide();
                tela.ShowDialog();
            }
            else
            {
                Dialog.Message("Código não encontrado", "atenção");
            }
            
        }
        #endregion
    }
}
