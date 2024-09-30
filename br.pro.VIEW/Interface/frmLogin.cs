using Holerite.Helpers;
using Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite.br.pro.VIEW
{
    public partial class frmLogin : Form
    {
        public List<string> permissions = new List<string>();
        public frmLogin()
        {
            InitializeComponent();
        }

        #region btnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btnLogar
        /// <summary>
        /// Button of login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogar_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            string hashPassword = PasswordGenerator.GeneratePassword(txtPassword.Text);
            permissions = Verification.VelidatePermissionUser(txtUserName.Text);
            permissions.RemoveAt(permissions.Count - 1);

            tela.permissions = permissions;

            if (Verification.Login(txtUserName.Text, hashPassword) == true)
            {
                this.Hide();
                tela.ShowDialog();
                this.Close();
            }
            else
            {
                txtUserName.Text = String.Empty;
                txtPassword.Text = String.Empty;
            }
        }
        #endregion
    }
}
