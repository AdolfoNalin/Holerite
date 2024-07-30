namespace Holerite.br.pro.VIEW.Insert
{
    partial class frmCompany
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFantasyName = new System.Windows.Forms.Label();
            this.txtFantasyName = new System.Windows.Forms.TextBox();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnAddPictores = new System.Windows.Forms.Button();
            this.btnRemovePictures = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.mtbTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblNeighborhood = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblHomeNumber = new System.Windows.Forms.Label();
            this.txtHomeNumber = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblComplement = new System.Windows.Forms.Label();
            this.txtComplement = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // lblFantasyName
            // 
            this.lblFantasyName.AutoSize = true;
            this.lblFantasyName.Location = new System.Drawing.Point(349, 56);
            this.lblFantasyName.Name = "lblFantasyName";
            this.lblFantasyName.Size = new System.Drawing.Size(78, 13);
            this.lblFantasyName.TabIndex = 3;
            this.lblFantasyName.Text = "Nome fantasia:";
            // 
            // txtFantasyName
            // 
            this.txtFantasyName.Location = new System.Drawing.Point(429, 53);
            this.txtFantasyName.Name = "txtFantasyName";
            this.txtFantasyName.Size = new System.Drawing.Size(234, 20);
            this.txtFantasyName.TabIndex = 2;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(746, 53);
            this.mtbCNPJ.Mask = "99,999,999/9999-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(107, 20);
            this.mtbCNPJ.TabIndex = 4;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(706, 57);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 5;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbLogo.Location = new System.Drawing.Point(967, 18);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(133, 137);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // btnAddPictores
            // 
            this.btnAddPictores.Location = new System.Drawing.Point(886, 95);
            this.btnAddPictores.Name = "btnAddPictores";
            this.btnAddPictores.Size = new System.Drawing.Size(75, 23);
            this.btnAddPictores.TabIndex = 7;
            this.btnAddPictores.Text = "Add";
            this.btnAddPictores.UseVisualStyleBackColor = true;
            // 
            // btnRemovePictures
            // 
            this.btnRemovePictures.Location = new System.Drawing.Point(886, 124);
            this.btnRemovePictures.Name = "btnRemovePictures";
            this.btnRemovePictures.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePictures.TabIndex = 8;
            this.btnRemovePictures.Text = "Remover";
            this.btnRemovePictures.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(340, 118);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(52, 13);
            this.lblTelephoneNumber.TabIndex = 12;
            this.lblTelephoneNumber.Text = "Telefone:";
            // 
            // mtbTelephoneNumber
            // 
            this.mtbTelephoneNumber.Location = new System.Drawing.Point(395, 114);
            this.mtbTelephoneNumber.Mask = "(99) 0000-9999";
            this.mtbTelephoneNumber.Name = "mtbTelephoneNumber";
            this.mtbTelephoneNumber.Size = new System.Drawing.Size(79, 20);
            this.mtbTelephoneNumber.TabIndex = 11;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(501, 117);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(42, 13);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Celular:";
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(545, 113);
            this.mtbPhoneNumber.Mask = "(99) 00000-9999";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(89, 20);
            this.mtbPhoneNumber.TabIndex = 13;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(670, 117);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 16;
            this.lblCEP.Text = "CEP:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(704, 113);
            this.mtbCEP.Mask = "99999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(57, 20);
            this.mtbCEP.TabIndex = 15;
            this.mtbCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCEP_KeyPress);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(36, 188);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 13);
            this.lblCity.TabIndex = 18;
            this.lblCity.Text = "Cidade:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(82, 185);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(234, 20);
            this.txtCity.TabIndex = 17;
            // 
            // lblNeighborhood
            // 
            this.lblNeighborhood.AutoSize = true;
            this.lblNeighborhood.Location = new System.Drawing.Point(339, 188);
            this.lblNeighborhood.Name = "lblNeighborhood";
            this.lblNeighborhood.Size = new System.Drawing.Size(34, 13);
            this.lblNeighborhood.TabIndex = 20;
            this.lblNeighborhood.Text = "Bairro";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(377, 185);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(234, 20);
            this.txtNeighborhood.TabIndex = 19;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(651, 187);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(30, 13);
            this.lblStreet.TabIndex = 22;
            this.lblStreet.Text = "Rua:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(683, 184);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(316, 20);
            this.txtStreet.TabIndex = 21;
            // 
            // lblHomeNumber
            // 
            this.lblHomeNumber.AutoSize = true;
            this.lblHomeNumber.Location = new System.Drawing.Point(1015, 188);
            this.lblHomeNumber.Name = "lblHomeNumber";
            this.lblHomeNumber.Size = new System.Drawing.Size(47, 13);
            this.lblHomeNumber.TabIndex = 24;
            this.lblHomeNumber.Text = "Número:";
            // 
            // txtHomeNumber
            // 
            this.txtHomeNumber.Location = new System.Drawing.Point(1065, 185);
            this.txtHomeNumber.Name = "txtHomeNumber";
            this.txtHomeNumber.Size = new System.Drawing.Size(42, 20);
            this.txtHomeNumber.TabIndex = 23;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(709, 313);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(113, 45);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(533, 313);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 45);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(356, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 45);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(193, 313);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(113, 45);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Text = "Salvar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbUF
            // 
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
            this.cbUF.Location = new System.Drawing.Point(811, 112);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(51, 21);
            this.cbUF.TabIndex = 29;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(784, 116);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 30;
            this.lblUF.Text = "UF:";
            // 
            // lblComplement
            // 
            this.lblComplement.AutoSize = true;
            this.lblComplement.Location = new System.Drawing.Point(50, 247);
            this.lblComplement.Name = "lblComplement";
            this.lblComplement.Size = new System.Drawing.Size(74, 13);
            this.lblComplement.TabIndex = 32;
            this.lblComplement.Text = "Complemento:";
            // 
            // txtComplement
            // 
            this.txtComplement.Location = new System.Drawing.Point(124, 247);
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Size = new System.Drawing.Size(564, 20);
            this.txtComplement.TabIndex = 31;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(36, 21);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 34;
            this.lblCod.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(82, 18);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(42, 20);
            this.txtCod.TabIndex = 33;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 423);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblComplement);
            this.Controls.Add(this.txtComplement);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblHomeNumber);
            this.Controls.Add(this.txtHomeNumber);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblNeighborhood);
            this.Controls.Add(this.txtNeighborhood);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.mtbPhoneNumber);
            this.Controls.Add(this.lblTelephoneNumber);
            this.Controls.Add(this.mtbTelephoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnRemovePictures);
            this.Controls.Add(this.btnAddPictores);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.lblFantasyName);
            this.Controls.Add(this.txtFantasyName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Empresa";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFantasyName;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnAddPictores;
        private System.Windows.Forms.Button btnRemovePictures;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblNeighborhood;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblHomeNumber;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblComplement;
        private System.Windows.Forms.Label lblCod;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtFantasyName;
        public System.Windows.Forms.MaskedTextBox mtbCNPJ;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.MaskedTextBox mtbTelephoneNumber;
        public System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        public System.Windows.Forms.MaskedTextBox mtbCEP;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.TextBox txtNeighborhood;
        public System.Windows.Forms.TextBox txtStreet;
        public System.Windows.Forms.TextBox txtHomeNumber;
        public System.Windows.Forms.ComboBox cbUF;
        public System.Windows.Forms.TextBox txtComplement;
        public System.Windows.Forms.TextBox txtCod;
    }
}