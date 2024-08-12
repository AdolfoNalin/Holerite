using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
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

namespace Holerite.br.pro.VIEW.Insert
{
    public partial class frmGenerateEPI : Form
    {
        public frmGenerateEPI()
        {
            InitializeComponent();
        }

        #region Load
        private void frmGenerateEPI_Load(object sender, EventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            dgEpi.DataSource = dao.Consult();
        }

        #endregion

        #region txtName_KeyPress
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            dgEpi.DataSource = dao.Consult(txtName.Text);
        }
        #endregion

        #region btnSearch_Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            EmployeeDAO dao = new EmployeeDAO();
            dgEpi.DataSource = dao.Search(name);
        }
        #endregion

        #region btnGerate_click
        private void btnGerate_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee()
            {
                Cod = int.Parse(dgEpi.CurrentRow.Cells[0].Value.ToString()),
                Name = dgEpi.CurrentRow.Cells[1].Value.ToString(),
                CEP = dgEpi.CurrentRow.Cells[10].Value.ToString(),
                State = dgEpi.CurrentRow.Cells[11].Value.ToString(),
                City = dgEpi.CurrentRow.Cells[12].Value.ToString(),
                Neighborhood = dgEpi.CurrentRow.Cells[13].Value.ToString(),
                Street = dgEpi.CurrentRow.Cells[14].Value.ToString(),
                HomeNumber = int.Parse(dgEpi.CurrentRow.Cells[15].Value.ToString())
            };

            PrintOut.PrintOutEpi(obj, int.Parse(txtAmount.Text));

            DialogResult resp = Dialog.MessageInsertOthers("Gerar EPI");

            if (resp == DialogResult.Yes)
            {
                txtAmount.Text = String.Empty;
            }
            else
            {
                this.Hide();
            }
        }
        #endregion
    }
}
