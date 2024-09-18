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
    public partial class frmPermission : Form
    {
        public List<CheckBox> listChck { get; set; }

        public frmPermission()
        {
            InitializeComponent();
        }

        #region btnBack_Click
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region btnConfirm_click
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<CheckBox> cb = new List<CheckBox>()
            {
                cbClient, cbCompany, cbEmployee,
                cbSupplier, cbService, cbProduct,
                cbPoint, cbHolerite, cbCheckout,
                cbSetting, cbBudget
            };

            listChck = cb.Where(lc => lc.Checked == true).ToList<CheckBox>();
            this.Hide();
        }
        #endregion

        #region cbAdmin_CheckedChanged
        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            List<CheckBox> cb = new List<CheckBox>()
            {
                cbClient, cbCompany, cbEmployee, 
                cbSupplier, cbService, cbProduct, 
                cbPoint, cbHolerite, cbCheckout, 
                cbSetting, cbBudget
            };

            if(cbAdmin.Checked)
            {
                cb.ForEach(b => b.Checked = true);
            }
            else
            {
                cb.ForEach(c => c.Checked = false);
            }
        }
        #endregion
    }
}
