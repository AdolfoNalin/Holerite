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
    public partial class frmConsultSeverce : Form
    {
        public frmConsultSeverce()
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

        #region Severce
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgSeverce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Severce obj = new Severce();
            frmInsertSeverce tela = new frmInsertSeverce();

            obj.Cod = int.Parse(dgSeverce.CurrentRow.Cells[0].Value.ToString());
            obj.ShortDescription = dgSeverce.CurrentRow.Cells[1].Value.ToString();
            obj.FullDescription = dgSeverce.CurrentRow.Cells[1].Value.ToString();
            obj.SportPrice = float.Parse(dgSeverce.CurrentRow.Cells[1].Value.ToString());
            obj.TermPrice = float.Parse(dgSeverce.CurrentRow.Cells[1].Value.ToString());
            obj.Observation = dgSeverce.CurrentRow.Cells[1].Value.ToString();

            tela.txtCod.Text = obj.Cod.ToString();
            tela.cbEmployee.Text = new EmployeeDAO().Search(obj.Cod);
            tela.txtFullDescription.Text = obj.FullDescription.ToString();
            tela.txtShortDescription.Text = obj.ShortDescription.ToString();
            tela.txtSpotPrice.Text = obj.SportPrice.ToString();
            tela.txtTerm.Text = obj.TermPrice.ToString();

            tela.ShowDialog();
        }
        #endregion
    }
}
