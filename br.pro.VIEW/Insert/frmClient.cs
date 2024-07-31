using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
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

namespace Holerite.br.pro.VIEW
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        #region Laod
        private void frmClient_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Insert
        /// <summary>
        /// Evento click que salva o cliente no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Client obj = new Client()
            {
                Name = txtName.Text,
                CPF = mtbCPF.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                Email = txtEmail.Text,
                State = cbUF.Text,
                City = txtCity.Text,
                Neighborhood = txtNeighborhood.Text,
                Street = txtStreet.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                CEP = mtbCEP.Text,
                Complement = txtComplement.Text
            };

            ClientDAO da = new ClientDAO();
            da.Insert(obj);

            frmConsultarClient tela = new frmConsultarClient();
            tela.dgClient.DataSource = da.Consult();
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os elementos no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Client obj = new Client()
            {
                Cod = int.Parse(txtCod.Text),
                Name = txtName.Text,
                CPF = mtbCPF.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                Email = txtEmail.Text,
                State = cbUF.Text,
                City = txtCity.Text,
                Neighborhood = txtNeighborhood.Text,
                Street = txtStreet.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                CEP = mtbCEP.Text,
                Complement = txtComplement.Text
            };

            ClientDAO da = new ClientDAO();
            da.Update(obj);

            frmConsultarClient tela = new frmConsultarClient();
            tela.dgClient.DataSource = da.Consult();
            this.Hide();
            tela.ShowDialog();
            
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o cliente no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCod.Text);

            if(cod > 0)
            {
                ClientDAO da = new ClientDAO();
                da.Delete(cod);

                frmConsultarClient tela = new frmConsultarClient();
                tela.dgClient.DataSource = da.Consult();
                this.Hide();
                tela.ShowDialog();
            }
            else
            {
                Dialog.Message("atenção", "O valor do cádigo não é valido");
            }
        }
        #endregion

        #region SearchCEP
        /// <summary>
        /// Busca o CEP e auto-completa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == 13)
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
            catch (Exception ex)
            {
                Dialog.Message($"CEP não encontrado!", "atenção");
            }
        }
        #endregion

    }
}
