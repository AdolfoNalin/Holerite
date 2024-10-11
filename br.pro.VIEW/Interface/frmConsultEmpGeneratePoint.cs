using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite.br.pro.VIEW.Consult
{
    public partial class frmConsultEmpGeneratePoint : Form
    {
        public List<String> date = new List<String>();
        private int _codScreen;
        public frmConsultEmpGeneratePoint(int codScreen)
        {
            InitializeComponent();
            _codScreen = codScreen;
        }

        public frmConsultEmpGeneratePoint()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultEmpGeneratePoint_Load(object sender, EventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            dgGeneratePoint.DataSource = dao.Consult();
        }
        #endregion

        #region txtName_Keypress
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            dgGeneratePoint.DataSource = dao.Consult(txtName.Text);
        }
        #endregion

        #region btnSearch_Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            dgGeneratePoint.DataSource = dao.Search(txtName.Text);
        }
        #endregion

        #region btnGenerate_click
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (_codScreen == 1)
            {
                List<string> list = new List<string>();

                if (dtpStart.Value.Month == dtpEnd.Value.Month && dgGeneratePoint.CurrentRow.Index >= 0)
                {
                    for (int i = dtpStart.Value.Day; i <= dtpEnd.Value.Day; i++)
                    {
                        list.Add($"{i}/{dtpStart.Value.Month}/{dtpStart.Value.Year}");
                    }

                    string cpf = dgGeneratePoint.CurrentRow.Cells[7].Value.ToString();

                    Employee emp = new EmployeeDAO().GetSearch(cpf);
                    Company com = new CompanyDAO().SearchName(dgGeneratePoint.CurrentRow.Cells[1].Value.ToString());
                    PrintOut.PrintOutPoint(com, emp, list);
                }
                else
                {
                    Dialog.Message("Verifique se o funcionário está selecionado e de os dias do calendário estão selecionados", "atenção");
                }
            }
            else if(_codScreen == 2)
            {
                if (dtpStart.Value.Month == dtpEnd.Value.Month && dgGeneratePoint.CurrentRow.Index >= 0)
                {
                    DialogResult resp = MessageBox.Show("Os dias foram selecionatos com sucesso!", "ateção", MessageBoxButtons.YesNo);

                    if (resp == DialogResult.Yes)
                    {
                        for (int i = dtpStart.Value.Day; i <= dtpEnd.Value.Day; i++)
                        {
                            date.Add($"{i}/{dtpStart.Value.Month}/{dtpStart.Value.Year}");
                        }
                    }
                    this.Hide();
                }
                else
                {
                    Dialog.Message("Certifique-se que há mais de 3 dias selecionado para a folha de ponto ser válida!", "atenção");
                }
            }            
        }
        #endregion

        #region dgGeneratePoint_CellDoubleClick
        private void dgGeneratePoint_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
