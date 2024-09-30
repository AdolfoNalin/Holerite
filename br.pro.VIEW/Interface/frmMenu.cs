using Holerite.br.pro.VIEW.Consult;
using Holerite.br.pro.VIEW.Insert;
using Holerite.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Holerite.br.pro.VIEW
{
    public partial class frmMenu : Form
    {
        public List<string> permissions = new List<string>();
        public frmMenu()
        {
            InitializeComponent();

        }

        #region btnBudget_click
        private void btnBudget_Click(object sender, EventArgs e)
        {
            frmInsertBudget tela = new frmInsertBudget();
            Verification.ValidadePermission(permissions, "Orçamento", tela);
            tela.Close();
        }
        #endregion

        #region btnConsultBedget
        private void btnConsultBudget_Click(object sender, EventArgs e)
        {
            frmConsultBudget tela = new frmConsultBudget();
            Verification.ValidadePermission(permissions, "Orçamento", tela);
            tela.Close();
        }
        #endregion

        #region ConsultClient
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmConsultarClient tela = new frmConsultarClient();
            Verification.ValidadePermission(permissions, "Cliente", tela);
            tela.Close();
        }
        #endregion

        #region InsertClient
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient tela = new frmClient();
            Verification.ValidadePermission(permissions, "Cliente", tela);
            tela.Close();
        }
        #endregion

        #region ConsultEmployee
        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultEmployee tela = new frmConsultEmployee();
            Verification.ValidadePermission(permissions, "Funcionário", tela);
            tela.Close();
        }
        #endregion

        #region InsertEployee
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmployee tela = new frmEmployee();
            Verification.ValidadePermission(permissions, "Funcionário", tela);
            tela.Close();
        }
        #endregion

        #region ConsultSupplier
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultSupplier tela = new frmConsultSupplier();
            Verification.ValidadePermission(permissions, "Fornecedor", tela);
            tela.Close();
        }
        #endregion

        #region InsertSupplier
        private void cadastarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier tela = new frmSupplier(); 
            Verification.ValidadePermission(permissions, "Fornecedor", tela);
            tela.Close();
        }
        #endregion

        #region ConsultService
        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultService tela = new frmConsultService();
            Verification.ValidadePermission(permissions, "Serviço", tela);
            tela.Close();
        }
        #endregion

        #region InsertService
        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmInsertService tela = new frmInsertService(); 
            Verification.ValidadePermission(permissions, "Serviço", tela);
            tela.Close();
        }
        #endregion

        #region ConsultProduct
        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultProduct tela = new frmConsultProduct();
            Verification.ValidadePermission(permissions, "Produto", tela);
            tela.Close();
        }
        #endregion

        #region InsertProduct
        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmInsertProduct tela = new frmInsertProduct();
            Verification.ValidadePermission(permissions, "Produto", tela);
            tela.Close();
        }
        #endregion

        #region Gerar Ponto
        private void gerarPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultEmpGeneratePoint tela = new frmConsultEmpGeneratePoint(1);
            Verification.ValidadePermission(permissions, "Ponto", tela);
            tela.Close();
        }
        #endregion

        #region Cadastrar Ponto
        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmInsertPoint tela = new frmInsertPoint();
            Verification.ValidadePermission(permissions, "Ponto", tela);
            tela.Close();
        }
        #endregion

        #region ConsultHolerite
        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region ConsultCompany
        private void consultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmConsultComapany tela = new frmConsultComapany();
            Verification.ValidadePermission(permissions, "Empresa", tela);
            tela.Close();
        }
        #endregion

        #region InsertCompanyu
        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmCompany tela = new frmCompany();
            Verification.ValidadePermission(permissions, "Empresa", tela);
            tela.Close();
        }
        #endregion

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        #region Exit
        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja mesmo sair os do programa?", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

    }
}
