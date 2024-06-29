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
                CPF = mtbCEP.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                Email = txtEmail.Text,
                CEP = mtbCEP.Text,
                State = cbUF.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                Complement = txtComplement.Text
            };

            ClientDAO.Insert(obj);
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
                Name = txtName.Text,
                CPF = mtbCEP.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                Email = txtEmail.Text,
                CEP = mtbCEP.Text,
                State = cbUF.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                Complement = txtComplement.Text
            };

            ClientDAO.Update(obj);
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
                ClientDAO.Delete(cod);
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
                    string cep = mtbCEP.Text;
                    string url = "https://viacep.com.br/ws/" + cep + "/xml/";

                    DataSet ds = new DataSet();
                    ds.ReadXml(url);

                    txtStreet.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                    txtNeighborhood.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0]["localidade"].ToString();
                    txtComplement.Text = ds.Tables[0].Rows[0]["complemento"].ToString();
                    cbUF.Text = ds.Tables[0].Rows[0]["uf"].ToString();
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
