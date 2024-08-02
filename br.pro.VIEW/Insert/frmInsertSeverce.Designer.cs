namespace Holerite.br.pro.VIEW.Insert
{
    partial class frmInsertSeverce
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
            this.lblFullDescription = new System.Windows.Forms.Label();
            this.txtFullDescription = new System.Windows.Forms.TextBox();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.txtSpotPrice = new System.Windows.Forms.TextBox();
            this.lblSpotPrice = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.lblTermPrice = new System.Windows.Forms.Label();
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.lblObservation = new System.Windows.Forms.Label();
            this.btnInset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblNew = new System.Windows.Forms.Button();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblUM = new System.Windows.Forms.Label();
            this.cbUM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFullDescription
            // 
            this.lblFullDescription.AutoSize = true;
            this.lblFullDescription.Location = new System.Drawing.Point(37, 45);
            this.lblFullDescription.Name = "lblFullDescription";
            this.lblFullDescription.Size = new System.Drawing.Size(102, 13);
            this.lblFullDescription.TabIndex = 0;
            this.lblFullDescription.Text = "Descrição Completa";
            // 
            // txtFullDescription
            // 
            this.txtFullDescription.Location = new System.Drawing.Point(144, 42);
            this.txtFullDescription.Multiline = true;
            this.txtFullDescription.Name = "txtFullDescription";
            this.txtFullDescription.Size = new System.Drawing.Size(233, 39);
            this.txtFullDescription.TabIndex = 1;
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(144, 106);
            this.txtShortDescription.Multiline = true;
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(233, 16);
            this.txtShortDescription.TabIndex = 4;
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.AutoSize = true;
            this.lblShortDescription.Location = new System.Drawing.Point(37, 107);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(105, 13);
            this.lblShortDescription.TabIndex = 3;
            this.lblShortDescription.Text = "Descrição Resumida";
            // 
            // txtSpotPrice
            // 
            this.txtSpotPrice.Location = new System.Drawing.Point(144, 151);
            this.txtSpotPrice.Multiline = true;
            this.txtSpotPrice.Name = "txtSpotPrice";
            this.txtSpotPrice.Size = new System.Drawing.Size(62, 16);
            this.txtSpotPrice.TabIndex = 7;
            // 
            // lblSpotPrice
            // 
            this.lblSpotPrice.AutoSize = true;
            this.lblSpotPrice.Location = new System.Drawing.Point(70, 152);
            this.lblSpotPrice.Name = "lblSpotPrice";
            this.lblSpotPrice.Size = new System.Drawing.Size(73, 13);
            this.lblSpotPrice.TabIndex = 6;
            this.lblSpotPrice.Text = "Preço Á vista:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(315, 154);
            this.txtTerm.Multiline = true;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(62, 16);
            this.txtTerm.TabIndex = 9;
            // 
            // lblTermPrice
            // 
            this.lblTermPrice.AutoSize = true;
            this.lblTermPrice.Location = new System.Drawing.Point(238, 154);
            this.lblTermPrice.Name = "lblTermPrice";
            this.lblTermPrice.Size = new System.Drawing.Size(78, 13);
            this.lblTermPrice.TabIndex = 8;
            this.lblTermPrice.Text = "Preço Á Prazo:";
            // 
            // txtOBS
            // 
            this.txtOBS.Location = new System.Drawing.Point(144, 245);
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.Size = new System.Drawing.Size(453, 39);
            this.txtOBS.TabIndex = 11;
            // 
            // lblObservation
            // 
            this.lblObservation.AutoSize = true;
            this.lblObservation.Location = new System.Drawing.Point(74, 248);
            this.lblObservation.Name = "lblObservation";
            this.lblObservation.Size = new System.Drawing.Size(68, 13);
            this.lblObservation.TabIndex = 10;
            this.lblObservation.Text = "Observação:";
            // 
            // btnInset
            // 
            this.btnInset.Location = new System.Drawing.Point(78, 369);
            this.btnInset.Name = "btnInset";
            this.btnInset.Size = new System.Drawing.Size(122, 35);
            this.btnInset.TabIndex = 13;
            this.btnInset.Text = "Salvar";
            this.btnInset.UseVisualStyleBackColor = true;
            this.btnInset.Click += new System.EventHandler(this.btnInset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(232, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(378, 369);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 35);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblNew
            // 
            this.lblNew.Location = new System.Drawing.Point(538, 369);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(122, 35);
            this.lblNew.TabIndex = 16;
            this.lblNew.Text = "Novo";
            this.lblNew.UseVisualStyleBackColor = true;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(586, 44);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(134, 21);
            this.cbEmployee.TabIndex = 17;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(518, 47);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(65, 13);
            this.lblEmployee.TabIndex = 18;
            this.lblEmployee.Text = "Funcionário:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(144, 20);
            this.txtCod.Multiline = true;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(62, 16);
            this.txtCod.TabIndex = 20;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(95, 21);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 19;
            this.lblCod.Text = "Código:";
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Location = new System.Drawing.Point(518, 74);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(67, 13);
            this.lblUM.TabIndex = 22;
            this.lblUM.Text = "Uni. Medida:";
            // 
            // cbUM
            // 
            this.cbUM.FormattingEnabled = true;
            this.cbUM.Items.AddRange(new object[] {
            "M3",
            "M2"});
            this.cbUM.Location = new System.Drawing.Point(586, 71);
            this.cbUM.Name = "cbUM";
            this.cbUM.Size = new System.Drawing.Size(134, 21);
            this.cbUM.TabIndex = 21;
            // 
            // frmInsertSeverce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUM);
            this.Controls.Add(this.cbUM);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInset);
            this.Controls.Add(this.txtOBS);
            this.Controls.Add(this.lblObservation);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblTermPrice);
            this.Controls.Add(this.txtSpotPrice);
            this.Controls.Add(this.lblSpotPrice);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.lblShortDescription);
            this.Controls.Add(this.txtFullDescription);
            this.Controls.Add(this.lblFullDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInsertSeverce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInsertSeverce";
            this.Load += new System.EventHandler(this.frmInsertSeverce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullDescription;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.Label lblSpotPrice;
        private System.Windows.Forms.Label lblTermPrice;
        private System.Windows.Forms.Label lblObservation;
        private System.Windows.Forms.Button btnInset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button lblNew;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblCod;
        public System.Windows.Forms.TextBox txtFullDescription;
        public System.Windows.Forms.TextBox txtShortDescription;
        public System.Windows.Forms.TextBox txtSpotPrice;
        public System.Windows.Forms.TextBox txtTerm;
        public System.Windows.Forms.TextBox txtOBS;
        public System.Windows.Forms.ComboBox cbEmployee;
        public System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblUM;
        public System.Windows.Forms.ComboBox cbUM;
    }
}