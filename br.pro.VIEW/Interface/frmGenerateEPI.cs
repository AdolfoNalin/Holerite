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

namespace Holerite.br.pro.VIEW.Interface
{
    public partial class frmGenerateEPI : Form
    {
        public frmGenerateEPI()
        {
            InitializeComponent();
        }

        #region btnGenerate_Click
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Employee emp = new EmployeeDAO().GetSearchEmp(txtName.Text);
            int.TryParse(txtLine.Text, out int amountLine);
            PrintOut.PrintOutEpi(emp, amountLine);
        }
        #endregion
    }
}
