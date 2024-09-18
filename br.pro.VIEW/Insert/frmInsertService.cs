using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Consult;
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
    public partial class frmInsertService : Form
    {
        public frmInsertService()
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
            Severce obj = new Severce();
            
            obj.CodEmp = int.Parse(cbEmployee.SelectedValue.ToString());
            obj.ShortDescription = txtShortDescription.Text;
            obj.UM = cbUM.Text;
            obj.FullDescription = txtFullDescription.Text;
            obj.SpotPrice = float.Parse(txtSpotPrice.Text);
            obj.TermPrice = float.Parse(txtTerm.Text);
            obj.Observation = txtOBS.Text;

            ServiceDAO dao = new ServiceDAO();   
            dao.Insert(obj);
        }
        #endregion

        #region Load
        private void frmInsertSeverce_Load(object sender, EventArgs e)
        {
            EmployeeDAO emp = new EmployeeDAO();

            if (txtCod.Text == "")
            {
                cbEmployee.DataSource = emp.Consult();
            }
            else
            {
               cbEmployee.DataSource = emp.Consult(cbEmployee.Text);
            }

            cbEmployee.DisplayMember = "Nome";
            cbEmployee.ValueMember = "Código";
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

            if(cod > 0)
            {
                ServiceDAO dao = new ServiceDAO();
                dao.Delete(cod);

                frmConsultService tela = new frmConsultService();
                tela.dgSeverce.DataSource = dao.Consult();
                this.Hide();
                tela.ShowDialog();
            }

            
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
            Severce obj = new Severce();

            obj.Cod = int.Parse(txtCod.Text);
            obj.CodEmp = int.Parse(cbEmployee.SelectedValue.ToString());
            obj.ShortDescription = txtShortDescription.Text;
            obj.UM = cbUM.Text;
            obj.FullDescription = txtFullDescription.Text;
            obj.SpotPrice = float.Parse(txtSpotPrice.Text);
            obj.TermPrice = float.Parse(txtTerm.Text);
            obj.Observation = txtOBS.Text;

            ServiceDAO dao = new ServiceDAO();
            dao.Update(obj);

            frmConsultService tela = new frmConsultService();
            tela.dgSeverce.DataSource = dao.Consult();
            this.Hide();
            tela.ShowDialog();
        }
        #endregion
    }
}
