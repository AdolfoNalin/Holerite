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
            this.Hide();
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
