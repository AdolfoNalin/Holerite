using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using MySqlX.XDevAPI;
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
    public partial class frmConsultarClient : Form
    {
        public frmConsultarClient()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultarClient_Load(object sender, EventArgs e)
        {
            ClientDAO dao = new ClientDAO();
            dgClient.DataSource = dao.Consult();
        }
        #endregion

        #region dgClient_CellDoubleClick
        /// <summary>
        /// Passa os dados para tela de cadastro de funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmClient tela = new frmClient();
            MODEL.Client obj = new MODEL.Client();

            obj.Cod = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
            obj.Name = dgClient.CurrentRow.Cells[1].Value.ToString();
            obj.CPF = dgClient.CurrentRow.Cells[2].Value.ToString();
            obj.Email = dgClient.CurrentRow.Cells[3].Value.ToString();
            obj.TelephoneNumber = dgClient.CurrentRow.Cells[4].Value.ToString();
            obj.PhoneNumber = dgClient.CurrentRow.Cells[5].Value.ToString();
            obj.CEP = dgClient.CurrentRow.Cells[6].Value.ToString();
            obj.State = dgClient.CurrentRow.Cells[7].Value.ToString();
            obj.City = dgClient.CurrentRow.Cells[8].Value.ToString();
            obj.Neighborhood = dgClient.CurrentRow.Cells[9].Value.ToString();
            obj.Street = dgClient.CurrentRow.Cells[10].Value.ToString();
            obj.HomeNumber = int.Parse(dgClient.CurrentRow.Cells[11].Value.ToString());
            obj.Complement = dgClient.CurrentRow.Cells[12].Value.ToString();

            tela.txtCod.Text = obj.Cod.ToString();
            tela.txtName.Text = obj.Name.ToString();
            tela.mtbCPF.Text = obj.CPF.ToString();
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

            this.Hide();
            tela.ShowDialog();
        }
        #endregion

        #region txtName_KeyPress
        /// <summary>
        /// Filtra o cliente conforme a digitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClientDAO dao = new ClientDAO();
            dgClient.DataSource = dao.ConsultName(txtName.Text);
        }
        #endregion

        #region btnSearch_click
        /// <summary>
        /// Filtra o cliente pelo click do btnSearch_click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClientDAO dao = new ClientDAO();
            dgClient.DataSource = dao.Search(txtName.Text);
        }
        #endregion
    }
}
