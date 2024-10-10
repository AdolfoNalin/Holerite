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

namespace Holerite.br.pro.VIEW.Consult
{
    public partial class frmConsultPoint : Form
    {
        public frmConsultPoint()
        {
            InitializeComponent();
        }

        #region Laod
        private void frmConsultPoint_Load(object sender, EventArgs e)
        {
            PointDAO dao = new PointDAO();
            dgPoint.DataSource = dao.Consult();
        }
        #endregion

        #region  dgPoint_CellContentClick
        /// <summary>
        /// Show the Insert point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPoint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nameCompany = dgPoint.CurrentRow.Cells[1].Value.ToString();
            Company com = new CompanyDAO().SearchName(nameCompany);
            frmInsertPoint ip = new frmInsertPoint(com.Cod);
            ip.txtCod.Text = dgPoint.CurrentRow.Cells[0].Value.ToString();
            ip.txtNameEmployee.Text = nameCompany;
            ip.mtbDate.Text = dgPoint.CurrentRow.Cells[2].Value.ToString();

            Employee emp = new EmployeeDAO().GetSearchEmp(ip.txtNameEmployee.Text);

            ip.txtFunction.Text = emp.Function;
            ip.mtbCPF.Text = emp.CPF;  

            string address = $"{emp.CEP}, {emp.State}, {emp.City}, {emp.Neighborhood}, {emp.Street}, {emp.HomeNumber}, {emp.Complement}";

            ip.txtAddress.Text = address;

            ip.dgPoint.Columns.Clear();

            ip.dgPoint.DataSource = new ItemPointDAO().Search(int.Parse(ip.txtCod.Text));
    
            ip.ShowDialog();
            this.Close();
        }
        #endregion

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            dgPoint.DataSource = new PointDAO().Search(dtpStartDate.Text, dtpEndDate.Text);
        }
    }
}
