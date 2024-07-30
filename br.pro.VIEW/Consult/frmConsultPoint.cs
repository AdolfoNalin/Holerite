using Holerite.br.pro.DAO;
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
        
        #region
        /// <summary>
        /// Show the Insert point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPoint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInsertPoint ip = new frmInsertPoint();
            ip.txtCod.Text = dgPoint.CurrentRow.Cells[0].Value.ToString();
            ip.txtNameEmployee.Text = dgPoint.CurrentRow.Cells[1].Value.ToString();
            ip.mtbCPF.Text = dgPoint.CurrentRow.Cells[2].Value.ToString();
            ip.txtFunction.Text = dgPoint.CurrentRow.Cells[4].Value.ToString();
            ip.txtAddress.Text = dgPoint.CurrentRow.Cells[5].Value.ToString();

            ip.ShowDialog();
        }
        #endregion
    }
}
