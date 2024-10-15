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
    public partial class frmConsultService : Form
    {
        public frmConsultService()
        {
            InitializeComponent();
        }

        #region txtName
        /// <summary>
        /// Consulta o Serviço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = "%" + txtName.Text + "%";

            ServiceDAO dao = new ServiceDAO();
            dao.Consult(name);
        }
        #endregion

        #region Search_click
        /// <summary>
        /// Pesquisa o serviço por click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ServiceDAO dao = new ServiceDAO();
            dao.Search(txtName.Text);
        }

        #endregion

        #region frmConsultSeverce_Load
        private void frmConsultSeverce_Load(object sender, EventArgs e)
        {
            ServiceDAO dao = new ServiceDAO();
            dgSeverce.DataSource = dao.Consult();
        }
        #endregion

        #region dgSeverce_CellContentClick
        private void dgSeverce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
