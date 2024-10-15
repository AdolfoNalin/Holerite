using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Consult;
using Holerite.br.pro.VIEW.Insert;
using Holerite.br.pro.VIEW.Interface;
using Holerite.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Holerite.br.pro.VIEW
{
    public partial class frmMenu : Form
    {
        public List<string> permissions = new List<string>();
        private int _codCompany;

        public frmMenu(int codCompany)
        {
            _codCompany = codCompany;
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
            frmConsultBudget screen = new frmConsultBudget();
            Verification.ValidadePermission(permissions, "Orçamento", screen);

            DataTable dt = new DataTable();
            ItemBudgetDAO dao = new ItemBudgetDAO();

            dt = dao.Consult(int.Parse(screen.dgBudget.CurrentRow.Cells[0].Value.ToString()));

            frmInsertBudget tela = new frmInsertBudget();
            tela.txtCodBudget.Text = screen.dgBudget.CurrentRow.Cells[0].Value.ToString();
            tela.mtbDate.Text = screen.dgBudget.CurrentRow.Cells[1].Value.ToString();
            string payment = screen.dgBudget.CurrentRow.Cells[2].Value.ToString();
            tela.dgBudget.DataSource = dt;
            tela.txtEmployee.Text = screen.dgBudget.CurrentRow.Cells[3].Value.ToString();
            tela.txtClient.Text = screen.dgBudget.CurrentRow.Cells[4].Value.ToString();
            tela.txtSubtotal.Text = screen.dgBudget.CurrentRow.Cells[5].Value.ToString();
            tela.txtTotal.Text = screen.dgBudget.CurrentRow.Cells[5].Value.ToString();
            tela.txtObs.Text = screen.dgBudget.CurrentRow.Cells[6].Value.ToString();

            if (payment == "Vista")
            {
                tela.rbSpot.Checked = true;
            }
            else
            {
                tela.rbTerm.Checked = true;
            }

            tela.ShowDialog();

            tela.Close();
        }
        #endregion

        #region ConsultClient
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmConsultarClient screen = new frmConsultarClient();
            Verification.ValidadePermission(permissions, "Cliente", screen);

            frmClient tela = new frmClient();
            MODEL.Client obj = new MODEL.Client();

            obj.Cod = int.Parse(screen.dgClient.CurrentRow.Cells[0].Value.ToString());
            obj.Name = screen.dgClient.CurrentRow.Cells[1].Value.ToString();
            obj.CPF = screen.dgClient.CurrentRow.Cells[2].Value.ToString();
            obj.Email = screen.dgClient.CurrentRow.Cells[3].Value.ToString();
            obj.TelephoneNumber = screen.dgClient.CurrentRow.Cells[4].Value.ToString();
            obj.PhoneNumber = screen.dgClient.CurrentRow.Cells[5].Value.ToString();
            obj.CEP = screen.dgClient.CurrentRow.Cells[6].Value.ToString();
            obj.State = screen.dgClient.CurrentRow.Cells[7].Value.ToString();
            obj.City = screen.dgClient.CurrentRow.Cells[8].Value.ToString();
            obj.Neighborhood = screen.dgClient.CurrentRow.Cells[9].Value.ToString();
            obj.Street = screen.dgClient.CurrentRow.Cells[10].Value.ToString();
            obj.HomeNumber = int.Parse(screen.dgClient.CurrentRow.Cells[11].Value.ToString());
            obj.Complement = screen.dgClient.CurrentRow.Cells[12].Value.ToString();

            tela.txtCod.Text = obj.Cod.ToString();
            tela.txtName.Text = obj.Name.ToString();
            tela.mtbCPF.Text = obj.CPF.ToString();
            tela.txtEmail.Text = obj.Email.ToString();
            tela.mtbTelephoneNumber.Text = obj.TelephoneNumber.ToString();
            tela.mtbPhoneNumber.Text = obj.PhoneNumber.ToString();
            tela.cbUF.Text = obj.State.ToString();
            tela.txtCity.Text = obj.City.ToString();
            tela.txtNeighborhood.Text = obj.Neighborhood.ToString();
            tela.txtStreet.Text = obj.Street.ToString();
            tela.txtHomeNumber.Text = obj.HomeNumber.ToString();
            tela.mtbCEP.Text = obj.CEP.ToString();
            tela.txtComplement.Text = obj.Complement.ToString();

            tela.ShowDialog();

            screen.Close();
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
            frmConsultEmployee screen = new frmConsultEmployee();
            Verification.ValidadePermission(permissions, "Funcionário", screen);

            string fantasyName = screen.dgEmployee.CurrentRow.Cells[1].Value.ToString();
            Company com = new CompanyDAO().SearchName(fantasyName);

            frmEmployee tela = new frmEmployee(com.Cod);

            tela.txtCod.Text = screen.dgEmployee.CurrentRow.Cells[0].Value.ToString();
            tela.txtName.Text = screen.dgEmployee.CurrentRow.Cells[2].Value.ToString();
            tela.txtUserName.Text = screen.dgEmployee.CurrentRow.Cells[3].Value.ToString();
            tela.txtPassword.Text = screen.dgEmployee.CurrentRow.Cells[4].Value.ToString();
            tela.txtPermissions.Text = screen.dgEmployee.CurrentRow.Cells[5].Value.ToString();
            tela.txtDaily.Text = screen.dgEmployee.CurrentRow.Cells[6].Value.ToString();
            tela.mtbCPF.Text = screen.dgEmployee.CurrentRow.Cells[7].Value.ToString();
            tela.txtEmail.Text = screen.dgEmployee.CurrentRow.Cells[8].Value.ToString();
            tela.mtbPhoneNumber.Text = screen.dgEmployee.CurrentRow.Cells[9].Value.ToString();
            tela.mtbTelephoneNumber.Text = screen.dgEmployee.CurrentRow.Cells[10].Value.ToString();
            tela.mtbCEP.Text = screen.dgEmployee.CurrentRow.Cells[11].Value.ToString();
            tela.cbUF.Text = screen.dgEmployee.CurrentRow.Cells[12].Value.ToString();
            tela.txtCity.Text = screen.dgEmployee.CurrentRow.Cells[13].Value.ToString();
            tela.txtNeighborhood.Text = screen.dgEmployee.CurrentRow.Cells[14].Value.ToString();
            tela.txtStreet.Text = screen.dgEmployee.CurrentRow.Cells[15].Value.ToString();
            tela.txtHomeNumber.Text = screen.dgEmployee.CurrentRow.Cells[16].Value.ToString();
            tela.txtComplement.Text = screen.dgEmployee.CurrentRow.Cells[17].Value.ToString();
            tela.txtFunction.Text = screen.dgEmployee.CurrentRow.Cells[18].Value.ToString();
            screen.Close();
            tela.ShowDialog();
            tela.Close();
        }
        #endregion

        #region InsertEployee
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmployee tela = new frmEmployee(_codCompany);
            Verification.ValidadePermission(permissions, "Funcionário", tela);
            tela.txtCodCompany.Text = _codCompany.ToString();
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
            frmConsultService screen = new frmConsultService();
            Verification.ValidadePermission(permissions, "Serviço", screen);

            Severce obj = new Severce();
            EmployeeDAO dao = new EmployeeDAO();
            frmInsertService tela = new frmInsertService();

            obj.Cod = int.Parse(screen.dgSeverce.CurrentRow.Cells[0].Value.ToString());
            obj.ShortDescription = screen.dgSeverce.CurrentRow.Cells[2].Value.ToString();
            obj.FullDescription = screen.dgSeverce.CurrentRow.Cells[3].Value.ToString();
            obj.UM = screen.dgSeverce.CurrentRow.Cells[4].Value.ToString();
            obj.SpotPrice = float.Parse(screen.dgSeverce.CurrentRow.Cells[5].Value.ToString());
            obj.TermPrice = float.Parse(screen.dgSeverce.CurrentRow.Cells[6].Value.ToString());
            obj.Observation = screen.dgSeverce.CurrentRow.Cells[7].Value.ToString();

            tela.txtCod.Text = obj.Cod.ToString();
            tela.cbEmployee.Text = screen.dgSeverce.CurrentRow.Cells[1].Value.ToString();
            tela.txtFullDescription.Text = obj.FullDescription.ToString();
            tela.txtShortDescription.Text = obj.ShortDescription.ToString();
            tela.cbUM.Text = obj.UM.ToString();
            tela.txtSpotPrice.Text = obj.SpotPrice.ToString();
            tela.txtTerm.Text = obj.TermPrice.ToString();

            tela.ShowDialog();

            screen.Close();
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
            frmConsultProduct screen = new frmConsultProduct();
            Verification.ValidadePermission(permissions, "Produto", screen);

            frmInsertProduct tela = new frmInsertProduct();
            Product obj = new Product();

            tela.txtCod.Text = screen.dgProduct.CurrentRow.Cells[0].Value.ToString();
            tela.txtShortDescription.Text = screen.dgProduct.CurrentRow.Cells[1].Value.ToString();
            tela.txtFullDescription.Text = screen.dgProduct.CurrentRow.Cells[2].Value.ToString();
            tela.cbSupplier.Text = screen.dgProduct.CurrentRow.Cells[3].Value.ToString();
            tela.cbEmployee.Text = screen.dgProduct.CurrentRow.Cells[4].Value.ToString();
            tela.txtAmount.Text = screen.dgProduct.CurrentRow.Cells[5].Value.ToString();
            tela.txtSpotPrice.Text = screen.dgProduct.CurrentRow.Cells[6].Value.ToString();
            tela.txtTermPrice.Text = screen.dgProduct.CurrentRow.Cells[7].Value.ToString();
            tela.mtbCA.Text = screen.dgProduct.CurrentRow.Cells[8].Value.ToString();
            tela.txtOBS.Text = screen.dgProduct.CurrentRow.Cells[9].Value.ToString();
            screen.Close();

            tela.ShowDialog();
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

        #region GerarPonto
        private void gerarPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultEmpGeneratePoint tela = new frmConsultEmpGeneratePoint(1);
            Verification.ValidadePermission(permissions, "Ponto", tela);
            tela.Close();
        }
        #endregion

        #region InsertPonto
        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmInsertPoint tela = new frmInsertPoint(_codCompany);
            Verification.ValidadePermission(permissions, "Ponto", tela);
            tela.Close();
        }
        #endregion

        #region ConsultPoint
        private void consultaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmConsultPoint screen = new frmConsultPoint();
            Verification.ValidadePermission(permissions, "Ponto", screen);
            screen.Close();
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

        #region InsertCompany
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

        #region ConsultEpi
        private void consultaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmConsultEpi screen = new frmConsultEpi();
            Verification.ValidadePermission(permissions,"Epi", screen);
            screen.Close();
        }
        #endregion

        #region InsertEpi
        private void cadastrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmInsertEPI screen = new frmInsertEPI();
            Verification.ValidadePermission(permissions, "Epi", screen);
            screen.Close();
        }
        #endregion

        #region GenerateEPI
        private void gerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerateEPI screen = new frmGenerateEPI();
            Verification.ValidadePermission(permissions, "Epi", screen);
            screen.Close();
        }
        #endregion
    }
}
