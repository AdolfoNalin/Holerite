using Holerite.br.pro.VIEW.Consult;
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

namespace Holerite.br.pro.VIEW
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        #region btnBudget_click
        private void btnBudget_Click(object sender, EventArgs e)
        {
            frmInsertBudget tela = new frmInsertBudget();

            tela.ShowDialog();
        }
        #endregion

        #region btnConsultBedget
        private void btnConsultBudget_Click(object sender, EventArgs e)
        {
            frmConsultBudget tela = new frmConsultBudget();
            tela.ShowDialog();
        }
        #endregion

        #region ConsultClient
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarClient tela = new frmConsultarClient();

            tela.ShowDialog();
        }
        #endregion

        #region InsertClient
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient tela = new frmClient();
            tela.ShowDialog();
        }
        #endregion

        #region ConsultEmployee
        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultEmployee tela = new frmConsultEmployee();

            tela.ShowDialog();
        }
        #endregion

        #region InsertEployee
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmployee tela = new frmEmployee();
            tela.ShowDialog();
        }
        #endregion

        #region ConsultSupplier
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultSupplier tela = new frmConsultSupplier(); 
            tela.ShowDialog();
        }
        #endregion

        #region InsertSupplier
        private void cadastarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier tela = new frmSupplier();
            tela.ShowDialog();
        }
        #endregion

        #region ConsultSeverce
        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultSeverce tela = new frmConsultSeverce();
            tela.ShowDialog();
        }
        #endregion

        #region InsertSeverce
        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmInsertSeverce tela = new frmInsertSeverce(); 
            tela.ShowDialog();
        }
        #endregion

        #region ConsultProduct
        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultProduct tela = new frmConsultProduct();
            tela.ShowDialog();
        }
        #endregion

        #region InsertProduct
        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultProduct tela = new frmConsultProduct();
            tela.ShowDialog();
        }
        #endregion

    }
}
