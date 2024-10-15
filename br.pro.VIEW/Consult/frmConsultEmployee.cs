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
            this.Hide();
        }
        #endregion
    }
}
