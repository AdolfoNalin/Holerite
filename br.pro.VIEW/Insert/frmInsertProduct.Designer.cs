namespace Holerite.br.pro.VIEW.Insert
{
    partial class frmInsertProduct
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.txtFullDescription = new System.Windows.Forms.TextBox();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.lblFullDescription = new System.Windows.Forms.Label();
            this.lblSpotPrice = new System.Windows.Forms.Label();
            this.lblTermPrice = new System.Windows.Forms.Label();
            this.txtSpotPrice = new System.Windows.Forms.TextBox();
            this.txtTermPrice = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.mtbCA = new System.Windows.Forms.MaskedTextBox();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblOBS = new System.Windows.Forms.Label();
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(136, 361);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(91, 45);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Salvar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(264, 361);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(379, 361);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 45);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(492, 361);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 45);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(79, 25);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 4;
            this.lblCod.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(125, 22);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(40, 20);
            this.txtCod.TabIndex = 5;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(466, 61);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(169, 21);
            this.cbSupplier.TabIndex = 6;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(399, 65);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(64, 13);
            this.lblSupplier.TabIndex = 7;
            this.lblSupplier.Text = "Fornecedor:";
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(125, 66);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(219, 20);
            this.txtShortDescription.TabIndex = 8;
            // 
            // txtFullDescription
            // 
            this.txtFullDescription.Location = new System.Drawing.Point(125, 109);
            this.txtFullDescription.Multiline = true;
            this.txtFullDescription.Name = "txtFullDescription";
            this.txtFullDescription.Size = new System.Drawing.Size(219, 41);
            this.txtFullDescription.TabIndex = 9;
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.AutoSize = true;
            this.lblShortDescription.Location = new System.Drawing.Point(15, 69);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(108, 13);
            this.lblShortDescription.TabIndex = 10;
            this.lblShortDescription.Text = "Descrição Resumida:";
            // 
            // lblFullDescription
            // 
            this.lblFullDescription.AutoSize = true;
            this.lblFullDescription.Location = new System.Drawing.Point(17, 112);
            this.lblFullDescription.Name = "lblFullDescription";
            this.lblFullDescription.Size = new System.Drawing.Size(105, 13);
            this.lblFullDescription.TabIndex = 11;
            this.lblFullDescription.Text = "Descrição Completa:";
            // 
            // lblSpotPrice
            // 
            this.lblSpotPrice.AutoSize = true;
            this.lblSpotPrice.Location = new System.Drawing.Point(386, 110);
            this.lblSpotPrice.Name = "lblSpotPrice";
            this.lblSpotPrice.Size = new System.Drawing.Size(69, 13);
            this.lblSpotPrice.TabIndex = 12;
            this.lblSpotPrice.Text = "Valor Á vista:";
            // 
            // lblTermPrice
            // 
            this.lblTermPrice.AutoSize = true;
            this.lblTermPrice.Location = new System.Drawing.Point(383, 138);
            this.lblTermPrice.Name = "lblTermPrice";
            this.lblTermPrice.Size = new System.Drawing.Size(74, 13);
            this.lblTermPrice.TabIndex = 13;
            this.lblTermPrice.Text = "Valor Á Prazo:";
            // 
            // txtSpotPrice
            // 
            this.txtSpotPrice.Location = new System.Drawing.Point(457, 108);
            this.txtSpotPrice.Name = "txtSpotPrice";
            this.txtSpotPrice.Size = new System.Drawing.Size(70, 20);
            this.txtSpotPrice.TabIndex = 14;
            // 
            // txtTermPrice
            // 
            this.txtTermPrice.Location = new System.Drawing.Point(457, 134);
            this.txtTermPrice.Name = "txtTermPrice";
            this.txtTermPrice.Size = new System.Drawing.Size(70, 20);
            this.txtTermPrice.TabIndex = 15;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(595, 103);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(40, 20);
            this.txtAmount.TabIndex = 16;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(529, 107);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 13);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Quantidade:";
            // 
            // mtbCA
            // 
            this.mtbCA.Location = new System.Drawing.Point(593, 133);
            this.mtbCA.Mask = "99,999";
            this.mtbCA.Name = "mtbCA";
            this.mtbCA.Size = new System.Drawing.Size(43, 20);
            this.mtbCA.TabIndex = 18;
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(565, 137);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(24, 13);
            this.lblCA.TabIndex = 19;
            this.lblCA.Text = "CA:";
            // 
            // lblOBS
            // 
            this.lblOBS.AutoSize = true;
            this.lblOBS.Location = new System.Drawing.Point(51, 226);
            this.lblOBS.Name = "lblOBS";
            this.lblOBS.Size = new System.Drawing.Size(68, 13);
            this.lblOBS.TabIndex = 21;
            this.lblOBS.Text = "Observação:";
            // 
            // txtOBS
            // 
            this.txtOBS.Location = new System.Drawing.Point(125, 226);
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.Size = new System.Drawing.Size(507, 41);
            this.txtOBS.TabIndex = 20;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(400, 29);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(65, 13);
            this.lblEmployee.TabIndex = 23;
            this.lblEmployee.Text = "Funcionário:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(467, 25);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(169, 21);
            this.cbEmployee.TabIndex = 22;
            // 
            // frmInsertProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.lblOBS);
            this.Controls.Add(this.txtOBS);
            this.Controls.Add(this.lblCA);
            this.Controls.Add(this.mtbCA);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtTermPrice);
            this.Controls.Add(this.txtSpotPrice);
            this.Controls.Add(this.lblTermPrice);
            this.Controls.Add(this.lblSpotPrice);
            this.Controls.Add(this.lblFullDescription);
            this.Controls.Add(this.lblShortDescription);
            this.Controls.Add(this.txtFullDescription);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Name = "frmInsertProduct";
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.frmInsertProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.Label lblFullDescription;
        private System.Windows.Forms.Label lblSpotPrice;
        private System.Windows.Forms.Label lblTermPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblOBS;
        private System.Windows.Forms.Label lblEmployee;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.ComboBox cbSupplier;
        public System.Windows.Forms.TextBox txtShortDescription;
        public System.Windows.Forms.TextBox txtFullDescription;
        public System.Windows.Forms.TextBox txtSpotPrice;
        public System.Windows.Forms.TextBox txtTermPrice;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.MaskedTextBox mtbCA;
        public System.Windows.Forms.TextBox txtOBS;
        public System.Windows.Forms.ComboBox cbEmployee;
    }
}