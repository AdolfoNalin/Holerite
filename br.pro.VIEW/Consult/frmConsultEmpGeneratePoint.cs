using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
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

                if (Calender.SelectionStart.Month == Calender.SelectionEnd.Month && dgGeneratePoint.CurrentRow.Index > 0)
                {
                    for (int i = Calender.SelectionRange.Start.Day; i <= Calender.SelectionRange.End.Day; i++)
                    {
                        list.Add($"{i}/{Calender.SelectionRange.Start.Month}/{Calender.SelectionRange.Start.Year}");
                    }

                    string cpf = dgGeneratePoint.CurrentRow.Cells[6].Value.ToString();

                    EmployeeDAO dao = new EmployeeDAO();
                    Employee emp = dao.GetSearch(cpf);

                    PrintOut.PrintOutPoint(emp, list);
                }
                else
                {
                    Dialog.Message("Verifique se o funcionário está seleccionado e de os dias do calendário estão selecionados", "atenção");
                }
            }
            else if(_codScreen == 2)
            {
                if (Calender.SelectionStart.Day + 2 <= Calender.SelectionEnd.Day && dgGeneratePoint.CurrentRow.Index >= 0)
                {
                    DialogResult resp = MessageBox.Show("Os dias foram selecionatos com sucesso!. Deseja fechar está tela?", "ateção", MessageBoxButtons.YesNo);

                    if (resp == DialogResult.Yes)
                    {
                        this.Hide();
                    }
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
