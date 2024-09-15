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

            SeverceDAO dao = new SeverceDAO();
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
            SeverceDAO dao = new SeverceDAO();
            dao.Search(txtName.Text);
        }

        #endregion

        #region dgSeverce_CellMouseClick
        private void dgSeverce_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Severce obj = new Severce();
            EmployeeDAO dao = new EmployeeDAO();
            frmInsertService tela = new frmInsertService();

            obj.Cod = int.Parse(dgSeverce.CurrentRow.Cells[0].Value.ToString());
            obj.ShortDescription = dgSeverce.CurrentRow.Cells[2].Value.ToString();
            obj.FullDescription = dgSeverce.CurrentRow.Cells[3].Value.ToString();
            obj.UM = dgSeverce.CurrentRow.Cells[4].Value.ToString();
            obj.SpotPrice = float.Parse(dgSeverce.CurrentRow.Cells[5].Value.ToString());
            obj.TermPrice = float.Parse(dgSeverce.CurrentRow.Cells[6].Value.ToString());
            obj.Observation = dgSeverce.CurrentRow.Cells[7].Value.ToString();

            tela.txtCod.Text = obj.Cod.ToString();
            tela.cbEmployee.Text = dgSeverce.CurrentRow.Cells[1].Value.ToString();
            tela.txtFullDescription.Text = obj.FullDescription.ToString();
            tela.txtShortDescription.Text = obj.ShortDescription.ToString();
            tela.cbUM.Text = obj.UM.ToString();
            tela.txtSpotPrice.Text = obj.SpotPrice.ToString();
            tela.txtTerm.Text = obj.TermPrice.ToString();

            tela.ShowDialog();
            this.Hide();
        }
        #endregion

        #region frmConsultSeverce_Load
        private void frmConsultSeverce_Load(object sender, EventArgs e)
        {
            SeverceDAO dao = new SeverceDAO();
            dgSeverce.DataSource = dao.Consult();
        }
        #endregion
    }
}
