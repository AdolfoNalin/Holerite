﻿using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Consult;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Holerite.Helpers;
using Holerite.br.pro.VIEW.Interface;

namespace Holerite.br.pro.VIEW.Insert
{
    public partial class frmEmployee : Form
    {
        private int _codCompany;
        public frmEmployee(int codCompany)
        {
            _codCompany = codCompany;
            InitializeComponent();
        }

        #region btnInsert
        /// <summary>
        /// Botão que cadastra os dados do funcionário no banco de dados 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {

            string password = PasswordGenerator.GeneratePassword(txtPassword.Text);
            Employee obj = new Employee()
            {
                Name = txtName.Text,
                UserName = txtUserName.Text,
                Password = password,
                Function = txtFunction.Text,
                Daily = float.Parse(txtDaily.Text),
                Permissions = txtPermissions.Text,
                CPF = mtbCPF.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                Email = txtEmail.Text,
                State = cbUF.Text,
                City = txtCity.Text,
                Neighborhood = txtNeighborhood.Text,
                Street = txtStreet.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                CEP = mtbCEP.Text,
                Complement = txtComplement.Text
            };

            EmployeeDAO da = new EmployeeDAO();
            da.Insert(obj);

            DialogResult resp = MessageBox.Show("Deseja cadastrar outro funcionário?", "atenção", MessageBoxButtons.YesNo);

            if(resp == DialogResult.No)
            {
                frmConsultEmployee tela = new frmConsultEmployee();
                tela.dgEmployee.DataSource = da.Consult();
                this.Hide();
                tela.ShowDialog();
            }
        }
        #endregion

        #region btnDelete
        /// <summary>
        /// Botão que deleta o funcionário do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCod.Text);

            if (cod > 0)
            {
                EmployeeDAO dao = new EmployeeDAO();
                dao.Delete(cod);

                frmConsultEmployee tela = new frmConsultEmployee();
                this.Hide();
                tela.ShowDialog();
            }
            else
            {
                Dialog.Message("Código não encontrado", "atenção");
            }
        }

        #endregion

        #region btnUpdate
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string password = PasswordGenerator.GeneratePassword(txtPassword.Text);
            Employee obj = new Employee()
            {
                Cod = int.Parse(txtCod.Text),
                Name = txtName.Text,
                UserName = txtUserName.Text,
                Password = password,
                Function = txtFunction.Text,
                Daily = float.Parse(txtDaily.Text),
                Permissions = txtPermissions.Text,
                CPF = mtbCPF.Text,
                TelephoneNumber = mtbTelephoneNumber.Text,
                PhoneNumber = mtbPhoneNumber.Text,
                Email = txtEmail.Text,
                State = cbUF.Text,
                City = txtCity.Text,
                Neighborhood = txtNeighborhood.Text,
                Street = txtStreet.Text,
                HomeNumber = int.Parse(txtHomeNumber.Text),
                CEP = mtbCEP.Text,
                Complement = txtComplement.Text
            };

            EmployeeDAO da = new EmployeeDAO();
            da.Update(obj);

            frmConsultEmployee tela = new frmConsultEmployee();
            tela.dgEmployee.DataSource = da.Consult();
            this.Hide();
            tela.ShowDialog();
        }
        #endregion

        #region ConsultCEP
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Address obj = new Address();
                obj = ConsultCEP.Consult(mtbCEP.Text);

                cbUF.Text = obj.State;
                txtCity.Text = obj.City;
                txtNeighborhood.Text = obj.Neighborhood;
                txtStreet.Text = obj.Street;
                txtHomeNumber.Text = obj.HomeNumber;
                txtComplement.Text = obj.Complement;
            }
        }
        #endregion

        #region btnPermissions_Click
        private void btnPermissions_Click(object sender, EventArgs e)
        {
            frmPermission tela = new frmPermission();
            tela.ShowDialog();
            List<CheckBox> listCheck = tela.listChck;
            txtPermissions.Text = String.Empty;
            listCheck.ForEach(lc => txtPermissions.Text += $"{lc.Text},");
        }
        #endregion
    }
}

