using Holerite.br.pro.DAO;
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
    public partial class frmConsultEmployee : Form
    {
        public frmConsultEmployee()
        {
            InitializeComponent();
        }

        #region Load
        private void frmInsertEmployee_Load(object sender, EventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            dgEmployee.DataSource = dao.Consult();
        }
        #endregion
        
        #region NameKeypress 
        /// <summary>
        /// Evento que detecta o click para a perquisa do funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();

            string name = "%" + txtName.Text + "%";

            dgEmployee.DataSource = dao.Consult(name);
        }
        #endregion

        #region btnSearch
        /// <summary>
        /// Busca o funcionário com o click do button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO(); 
            dgEmployee.DataSource= dao.Search(txtName.Text);
        }
        #endregion

        #region dgEmployee DoubleClick
        private void dgEmployee_DoubleClick(object sender, EventArgs e)
        {
            frmEmployee tela = new frmEmployee();

            tela.txtCod.Text = dgEmployee.CurrentRow.Cells[0].Value.ToString();
            tela.txtName.Text = dgEmployee.CurrentRow.Cells[1].Value.ToString();
            tela.txtUserName.Text = dgEmployee.CurrentRow.Cells[2].Value.ToString();
            tela.txtPassword.Text = dgEmployee.CurrentRow.Cells[3].Value.ToString();
            tela.txtPermissions.Text = dgEmployee.CurrentRow.Cells[4].Value.ToString();
            tela.txtDaily.Text = dgEmployee.CurrentRow.Cells[5].Value.ToString();
            tela.mtbCPF.Text = dgEmployee.CurrentRow.Cells[6].Value.ToString();
            tela.txtEmail.Text = dgEmployee.CurrentRow.Cells[7].Value.ToString();
            tela.mtbPhoneNumber.Text = dgEmployee.CurrentRow.Cells[8].Value.ToString();
            tela.mtbTelephoneNumber.Text = dgEmployee.CurrentRow.Cells[9].Value.ToString();
            tela.mtbCEP.Text = dgEmployee.CurrentRow.Cells[10].Value.ToString();
            tela.cbUF.Text = dgEmployee.CurrentRow.Cells[11].Value.ToString();
            tela.txtCity.Text = dgEmployee.CurrentRow.Cells[12].Value.ToString();
            tela.txtNeighborhood.Text = dgEmployee.CurrentRow.Cells[13].Value.ToString();
            tela.txtStreet.Text = dgEmployee.CurrentRow.Cells[14].Value.ToString();
            tela.txtHomeNumber.Text = dgEmployee.CurrentRow.Cells[15].Value.ToString();
            tela.txtComplement.Text = dgEmployee.CurrentRow.Cells[16].Value.ToString();
            tela.cbFunction.Text = dgEmployee.CurrentRow.Cells[17].Value.ToString();

            this.Hide();
            tela.ShowDialog();
        }
        #endregion
    }
}
