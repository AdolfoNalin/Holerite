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

namespace Holerite.br.pro.VIEW.Insert
{
    public partial class frmInsertSeverce : Form
    {
        public frmInsertSeverce()
        {
            InitializeComponent();
        }

        #region btnInsert
        /// <summary>
        /// Botão que salva o serviço no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInset_Click(object sender, EventArgs e)
        {
            Severce obj = new Severce()
            {
                CodEmp = int.Parse(cbEmployee.SelectedValue.ToString()),
                ShortDescription = txtShortDescription.Text,
                FullDescription = txtFullDescription.Text,
                SpotPrice = float.Parse(txtSpotPrice.Text),
                TermPrice = float.Parse(txtTerm.Text),
                Observation = txtOBS.Text
            };

            SeverceDAO dao = new SeverceDAO();   
            dao.Insert(obj);
        }
        #endregion

        #region Load
        private void frmInsertSeverce_Load(object sender, EventArgs e)
        {
            SeverceDAO dao = new SeverceDAO();
            cbEmployee.DataSource = dao.Consult();
            cbEmployee.DisplayMember = "emp_name";
            cbEmployee.ValueMember = "cod";
        }
        #endregion

        #region btnDelete
        /// <summary>
        /// Botão que deleta os dados do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCod.Text);

            SeverceDAO dao = new SeverceDAO();
            dao.Delete(cod);
        }
        #endregion

        #region btnEdit
        /// <summary>
        /// Edita os dados do serviço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Severce obj = new Severce()
            {
                CodEmp = int.Parse(cbEmployee.SelectedValue.ToString()),
                ShortDescription = txtShortDescription.Text,
                FullDescription = txtFullDescription.Text,
                SpotPrice = float.Parse(txtSpotPrice.Text),
                TermPrice = float.Parse(txtTerm.Text),
                Observation = txtOBS.Text
            };

            SeverceDAO dao = new SeverceDAO();
            dao.Update(obj);
        }
        #endregion
    }
}
