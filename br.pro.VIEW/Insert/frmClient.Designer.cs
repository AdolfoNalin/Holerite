namespace Holerite.br.pro.VIEW
{
    partial class frmClient
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.mtbTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.lblNeighborhood = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtHomeNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtComplement = new System.Windows.Forms.TextBox();
            this.lblComplement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(80, 12);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(50, 20);
            this.txtCod.TabIndex = 0;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(379, 42);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(87, 20);
            this.mtbCPF.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome:";
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(81, 96);
            this.mtbPhoneNumber.Mask = "(99) 00000-9999";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(86, 20);
            this.mtbPhoneNumber.TabIndex = 3;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(54, 15);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(29, 13);
            this.lblCod.TabIndex = 4;
            this.lblCod.Text = "Cod:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Location = new System.Drawing.Point(81, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(349, 45);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInsert.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsert.Location = new System.Drawing.Point(158, 422);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 38);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Salvar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(315, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(457, 422);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 38);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Location = new System.Drawing.Point(605, 422);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(98, 38);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(491, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(525, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(42, 99);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(42, 13);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Celular:";
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(220, 100);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(49, 13);
            this.lblTelephoneNumber.TabIndex = 15;
            this.lblTelephoneNumber.Text = "Telefone";
            // 
            // mtbTelephoneNumber
            // 
            this.mtbTelephoneNumber.Location = new System.Drawing.Point(271, 97);
            this.mtbTelephoneNumber.Mask = "(99) 00000-9999";
            this.mtbTelephoneNumber.Name = "mtbTelephoneNumber";
            this.mtbTelephoneNumber.Size = new System.Drawing.Size(86, 20);
            this.mtbTelephoneNumber.TabIndex = 14;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(576, 102);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 17;
            this.lblUF.Text = "UF:";
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
            this.cbUF.Location = new System.Drawing.Point(603, 99);
            this.cbUF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(81, 21);
            this.cbUF.TabIndex = 21;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(81, 170);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(254, 20);
            this.txtCity.TabIndex = 23;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(37, 173);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 13);
            this.lblCity.TabIndex = 22;
            this.lblCity.Text = "Cidade:";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(447, 170);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(254, 20);
            this.txtNeighborhood.TabIndex = 25;
            // 
            // lblNeighborhood
            // 
            this.lblNeighborhood.AutoSize = true;
            this.lblNeighborhood.Location = new System.Drawing.Point(408, 172);
            this.lblNeighborhood.Name = "lblNeighborhood";
            this.lblNeighborhood.Size = new System.Drawing.Size(37, 13);
            this.lblNeighborhood.TabIndex = 24;
            this.lblNeighborhood.Text = "Bairro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(418, 100);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 26;
            this.lblCEP.Text = "CEP:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(453, 97);
            this.mtbCEP.Mask = "99999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(64, 20);
            this.mtbCEP.TabIndex = 27;
            this.mtbCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCEP_KeyPress);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(80, 251);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(306, 20);
            this.txtStreet.TabIndex = 29;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(48, 254);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(30, 13);
            this.lblStreet.TabIndex = 28;
            this.lblStreet.Text = "Rua:";
            // 
            // txtHomeNumber
            // 
            this.txtHomeNumber.Location = new System.Drawing.Point(447, 250);
            this.txtHomeNumber.Name = "txtHomeNumber";
            this.txtHomeNumber.Size = new System.Drawing.Size(50, 20);
            this.txtHomeNumber.TabIndex = 31;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(402, 252);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 30;
            this.lblNumber.Text = "Numero:";
            // 
            // txtComplement
            // 
            this.txtComplement.Location = new System.Drawing.Point(80, 322);
            this.txtComplement.Multiline = true;
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Size = new System.Drawing.Size(699, 51);
            this.txtComplement.TabIndex = 33;
            // 
            // lblComplement
            // 
            this.lblComplement.AutoSize = true;
            this.lblComplement.Location = new System.Drawing.Point(37, 306);
            this.lblComplement.Name = "lblComplement";
            this.lblComplement.Size = new System.Drawing.Size(74, 13);
            this.lblComplement.TabIndex = 32;
            this.lblComplement.Text = "Complemento:";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 493);
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
            this.Name = "frmClient";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.MaskedTextBox mtbTelephoneNumber;
        private System.Windows.Forms.Label lblUF;
        public System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label lblNeighborhood;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtHomeNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtComplement;
        private System.Windows.Forms.Label lblComplement;
    }
}