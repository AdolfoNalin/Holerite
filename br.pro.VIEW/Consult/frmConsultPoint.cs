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
    }
}
