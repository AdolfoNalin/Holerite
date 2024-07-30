namespace Holerite.br.pro.VIEW.Insert
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtComplement = new System.Windows.Forms.TextBox();
            this.lblComplement = new System.Windows.Forms.Label();
            this.txtHomeNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.lblNeighborhood = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.mtbTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFunction = new System.Windows.Forms.Label();
            this.txtPermissions = new System.Windows.Forms.TextBox();
            this.lblPermissions = new System.Windows.Forms.Label();
            this.btnPermissions = new System.Windows.Forms.Button();
            this.txtDaily = new System.Windows.Forms.TextBox();
            this.lblDaily = new System.Windows.Forms.Label();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtComplement
            // 
            this.txtComplement.Location = new System.Drawing.Point(72, 326);
            this.txtComplement.Multiline = true;
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Size = new System.Drawing.Size(699, 51);
            this.txtComplement.TabIndex = 63;
            // 
            // lblComplement
            // 
            this.lblComplement.AutoSize = true;
            this.lblComplement.Location = new System.Drawing.Point(29, 310);
            this.lblComplement.Name = "lblComplement";
            this.lblComplement.Size = new System.Drawing.Size(74, 13);
            this.lblComplement.TabIndex = 62;
            this.lblComplement.Text = "Complemento:";
            // 
            // txtHomeNumber
            // 
            this.txtHomeNumber.Location = new System.Drawing.Point(711, 262);
            this.txtHomeNumber.Name = "txtHomeNumber";
            this.txtHomeNumber.Size = new System.Drawing.Size(50, 20);
            this.txtHomeNumber.TabIndex = 61;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(666, 264);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 60;
            this.lblNumber.Text = "Numero:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(344, 263);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(306, 20);
            this.txtStreet.TabIndex = 59;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(312, 266);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(30, 13);
            this.lblStreet.TabIndex = 58;
            this.lblStreet.Text = "Rua:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(98, 213);
            this.mtbCEP.Mask = "99999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(64, 20);
            this.mtbCEP.TabIndex = 57;
            this.mtbCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCEP_KeyPress);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(63, 216);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 56;
            this.lblCEP.Text = "CEP:";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(52, 261);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(254, 20);
            this.txtNeighborhood.TabIndex = 55;
            // 
            // lblNeighborhood
            // 
            this.lblNeighborhood.AutoSize = true;
            this.lblNeighborhood.Location = new System.Drawing.Point(13, 263);
            this.lblNeighborhood.Name = "lblNeighborhood";
            this.lblNeighborhood.Size = new System.Drawing.Size(37, 13);
            this.lblNeighborhood.TabIndex = 54;
            this.lblNeighborhood.Text = "Bairro:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(378, 212);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(254, 20);
            this.txtCity.TabIndex = 53;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(334, 215);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 13);
            this.lblCity.TabIndex = 52;
            this.lblCity.Text = "Cidade:";
            // 
            // cbUF
            // 
            this.cbUF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(215, 212);
            this.cbUF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(81, 21);
            this.cbUF.TabIndex = 51;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(188, 215);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 50;
            this.lblUF.Text = "UF:";
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(212, 104);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(49, 13);
            this.lblTelephoneNumber.TabIndex = 49;
            this.lblTelephoneNumber.Text = "Telefone";
            // 
            // mtbTelephoneNumber
            // 
            this.mtbTelephoneNumber.Location = new System.Drawing.Point(263, 101);
            this.mtbTelephoneNumber.Mask = "(99) 0000-9999";
            this.mtbTelephoneNumber.Name = "mtbTelephoneNumber";
            this.mtbTelephoneNumber.Size = new System.Drawing.Size(86, 20);
            this.mtbTelephoneNumber.TabIndex = 48;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(34, 103);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(42, 13);
            this.lblPhoneNumber.TabIndex = 47;
            this.lblPhoneNumber.Text = "Celular:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(517, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 20);
            this.txtEmail.TabIndex = 46;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(483, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Email:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Location = new System.Drawing.Point(597, 411);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(98, 38);
            this.btnNovo.TabIndex = 44;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(449, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 38);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(307, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 38);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInsert.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsert.Location = new System.Drawing.Point(150, 411);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 38);
            this.btnInsert.TabIndex = 41;
            this.btnInsert.Text = "Salvar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(341, 49);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 40;
            this.lblCPF.Text = "CPF:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Location = new System.Drawing.Point(73, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 20);
            this.txtName.TabIndex = 39;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(46, 19);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(29, 13);
            this.lblCod.TabIndex = 38;
            this.lblCod.Text = "Cod:";
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(73, 100);
            this.mtbPhoneNumber.Mask = "(99) 00000-9999";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(86, 20);
            this.mtbPhoneNumber.TabIndex = 37;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Nome:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(371, 46);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(87, 20);
            this.mtbCPF.TabIndex = 35;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(72, 16);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(50, 20);
            this.txtCod.TabIndex = 34;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(466, 101);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(87, 20);
            this.txtUserName.TabIndex = 65;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(375, 104);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 13);
            this.lblUserName.TabIndex = 64;
            this.lblUserName.Text = "Nome do usuário:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(626, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(87, 20);
            this.txtPassword.TabIndex = 67;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(584, 99);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 13);
            this.lblPassword.TabIndex = 66;
            this.lblPassword.Text = "Senha:";
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(31, 151);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(38, 13);
            this.lblFunction.TabIndex = 69;
            this.lblFunction.Text = "Cargo:";
            // 
            // txtPermissions
            // 
            this.txtPermissions.Location = new System.Drawing.Point(281, 147);
            this.txtPermissions.Multiline = true;
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.Size = new System.Drawing.Size(334, 44);
            this.txtPermissions.TabIndex = 71;
            // 
            // lblPermissions
            // 
            this.lblPermissions.AutoSize = true;
            this.lblPermissions.Location = new System.Drawing.Point(211, 151);
            this.lblPermissions.Name = "lblPermissions";
            this.lblPermissions.Size = new System.Drawing.Size(69, 13);
            this.lblPermissions.TabIndex = 70;
            this.lblPermissions.Text = "Permissoens:";
            // 
            // btnPermissions
            // 
            this.btnPermissions.Location = new System.Drawing.Point(622, 145);
            this.btnPermissions.Name = "btnPermissions";
            this.btnPermissions.Size = new System.Drawing.Size(30, 23);
            this.btnPermissions.TabIndex = 72;
            this.btnPermissions.UseVisualStyleBackColor = true;
            // 
            // txtDaily
            // 
            this.txtDaily.Location = new System.Drawing.Point(721, 147);
            this.txtDaily.Name = "txtDaily";
            this.txtDaily.Size = new System.Drawing.Size(50, 20);
            this.txtDaily.TabIndex = 74;
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Location = new System.Drawing.Point(681, 150);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(37, 13);
            this.lblDaily.TabIndex = 73;
            this.lblDaily.Text = "Diária:";
            // 
            // cbFunction
            // 
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Location = new System.Drawing.Point(72, 148);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(121, 21);
            this.cbFunction.TabIndex = 75;
            this.cbFunction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFunction_KeyPress);
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(72, 148);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(121, 20);
            this.txtFunction.TabIndex = 76;
            this.txtFunction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFunction_KeyPress);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.cbFunction);
            this.Controls.Add(this.txtDaily);
            this.Controls.Add(this.lblDaily);
            this.Controls.Add(this.btnPermissions);
            this.Controls.Add(this.txtPermissions);
            this.Controls.Add(this.lblPermissions);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtComplement);
            this.Controls.Add(this.lblComplement);
            this.Controls.Add(this.txtHomeNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtNeighborhood);
            this.Controls.Add(this.lblNeighborhood);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblTelephoneNumber);
            this.Controls.Add(this.mtbTelephoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.mtbPhoneNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.txtCod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionário";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtComplement;
        private System.Windows.Forms.Label lblComplement;
        public System.Windows.Forms.TextBox txtHomeNumber;
        private System.Windows.Forms.Label lblNumber;
        public System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        public System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label lblCEP;
        public System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label lblNeighborhood;
        public System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblTelephoneNumber;
        public System.Windows.Forms.MaskedTextBox mtbTelephoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblCPF;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCod;
        public System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.MaskedTextBox mtbCPF;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFunction;
        public System.Windows.Forms.TextBox txtPermissions;
        private System.Windows.Forms.Label lblPermissions;
        private System.Windows.Forms.Button btnPermissions;
        public System.Windows.Forms.TextBox txtDaily;
        private System.Windows.Forms.Label lblDaily;
        public System.Windows.Forms.TextBox txtFunction;
        public System.Windows.Forms.ComboBox cbFunction;
    }
}