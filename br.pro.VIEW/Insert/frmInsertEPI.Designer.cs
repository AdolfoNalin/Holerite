namespace Holerite.br.pro.VIEW.Insert
{
    partial class frmInsertEPI
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
            this.dgEPI = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCodEpi = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSalve = new System.Windows.Forms.Button();
            this.txtCodProduct = new System.Windows.Forms.TextBox();
            this.lblCodProduct = new System.Windows.Forms.Label();
            this.txtSpot = new System.Windows.Forms.TextBox();
            this.lblSpot = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.rbSpot = new System.Windows.Forms.RadioButton();
            this.rbTerm = new System.Windows.Forms.RadioButton();
            this.txtCodEpi = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintOut = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnConsultEmployee = new System.Windows.Forms.Button();
            this.btnConsultProduct = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEPI)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEPI
            // 
            this.dgEPI.AllowUserToAddRows = false;
            this.dgEPI.AllowUserToDeleteRows = false;
            this.dgEPI.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgEPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEPI.Location = new System.Drawing.Point(599, 66);
            this.dgEPI.Name = "dgEPI";
            this.dgEPI.ReadOnly = true;
            this.dgEPI.Size = new System.Drawing.Size(296, 219);
            this.dgEPI.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(518, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(518, 95);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(113, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome:";
            // 
            // lblCodEpi
            // 
            this.lblCodEpi.AutoSize = true;
            this.lblCodEpi.Location = new System.Drawing.Point(12, 15);
            this.lblCodEpi.Name = "lblCodEpi";
            this.lblCodEpi.Size = new System.Drawing.Size(29, 13);
            this.lblCodEpi.TabIndex = 5;
            this.lblCodEpi.Text = "Cod:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(40, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Desc:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(358, 171);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(84, 20);
            this.txtAmount.TabIndex = 11;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(291, 174);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 13);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Quantidade:";
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(829, 15);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(66, 20);
            this.mtbDate.TabIndex = 13;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(87, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 24);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSalve
            // 
            this.btnSalve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalve.Location = new System.Drawing.Point(194, 351);
            this.btnSalve.Name = "btnSalve";
            this.btnSalve.Size = new System.Drawing.Size(101, 24);
            this.btnSalve.TabIndex = 15;
            this.btnSalve.Text = "Salvar";
            this.btnSalve.UseVisualStyleBackColor = true;
            this.btnSalve.Click += new System.EventHandler(this.btnSalve_Click);
            // 
            // txtCodProduct
            // 
            this.txtCodProduct.Location = new System.Drawing.Point(399, 68);
            this.txtCodProduct.Name = "txtCodProduct";
            this.txtCodProduct.Size = new System.Drawing.Size(37, 20);
            this.txtCodProduct.TabIndex = 19;
            // 
            // lblCodProduct
            // 
            this.lblCodProduct.AutoSize = true;
            this.lblCodProduct.Location = new System.Drawing.Point(367, 71);
            this.lblCodProduct.Name = "lblCodProduct";
            this.lblCodProduct.Size = new System.Drawing.Size(29, 13);
            this.lblCodProduct.TabIndex = 18;
            this.lblCodProduct.Text = "Cod:";
            // 
            // txtSpot
            // 
            this.txtSpot.Location = new System.Drawing.Point(83, 171);
            this.txtSpot.Name = "txtSpot";
            this.txtSpot.Size = new System.Drawing.Size(49, 20);
            this.txtSpot.TabIndex = 21;
            // 
            // lblSpot
            // 
            this.lblSpot.AutoSize = true;
            this.lblSpot.Location = new System.Drawing.Point(44, 174);
            this.lblSpot.Name = "lblSpot";
            this.lblSpot.Size = new System.Drawing.Size(39, 13);
            this.lblSpot.TabIndex = 20;
            this.lblSpot.Text = "Á vista";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(656, 294);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total:";
            // 
            // rbSpot
            // 
            this.rbSpot.AutoSize = true;
            this.rbSpot.Location = new System.Drawing.Point(535, 137);
            this.rbSpot.Name = "rbSpot";
            this.rbSpot.Size = new System.Drawing.Size(58, 17);
            this.rbSpot.TabIndex = 24;
            this.rbSpot.TabStop = true;
            this.rbSpot.Text = "Á Vista";
            this.rbSpot.UseVisualStyleBackColor = true;
            this.rbSpot.CheckedChanged += new System.EventHandler(this.rbSpot_CheckedChanged);
            // 
            // rbTerm
            // 
            this.rbTerm.AutoSize = true;
            this.rbTerm.Location = new System.Drawing.Point(535, 160);
            this.rbTerm.Name = "rbTerm";
            this.rbTerm.Size = new System.Drawing.Size(62, 17);
            this.rbTerm.TabIndex = 25;
            this.rbTerm.TabStop = true;
            this.rbTerm.Text = "Á Prazo";
            this.rbTerm.UseVisualStyleBackColor = true;
            this.rbTerm.CheckedChanged += new System.EventHandler(this.rbTerm_CheckedChanged);
            // 
            // txtCodEpi
            // 
            this.txtCodEpi.Location = new System.Drawing.Point(44, 12);
            this.txtCodEpi.Name = "txtCodEpi";
            this.txtCodEpi.Size = new System.Drawing.Size(37, 20);
            this.txtCodEpi.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(696, 291);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(46, 20);
            this.txtTotal.TabIndex = 26;
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(196, 171);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(61, 20);
            this.txtTerm.TabIndex = 28;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(151, 174);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(44, 13);
            this.lblTerm.TabIndex = 27;
            this.lblTerm.Text = "Á Prazo";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(301, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 24);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintOut
            // 
            this.btnPrintOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintOut.Location = new System.Drawing.Point(408, 351);
            this.btnPrintOut.Name = "btnPrintOut";
            this.btnPrintOut.Size = new System.Drawing.Size(101, 24);
            this.btnPrintOut.TabIndex = 31;
            this.btnPrintOut.Text = "Imprimir";
            this.btnPrintOut.UseVisualStyleBackColor = true;
            this.btnPrintOut.Click += new System.EventHandler(this.btnPrintOut_Click);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(87, 237);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(397, 69);
            this.txtObs.TabIndex = 33;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(16, 240);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(68, 13);
            this.lblObs.TabIndex = 32;
            this.lblObs.Text = "Observação:";
            // 
            // btnConsultEmployee
            // 
            this.btnConsultEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultEmployee.Location = new System.Drawing.Point(440, 12);
            this.btnConsultEmployee.Name = "btnConsultEmployee";
            this.btnConsultEmployee.Size = new System.Drawing.Size(32, 24);
            this.btnConsultEmployee.TabIndex = 34;
            this.btnConsultEmployee.UseVisualStyleBackColor = true;
            this.btnConsultEmployee.Click += new System.EventHandler(this.btnConsultEmployee_Click);
            // 
            // btnConsultProduct
            // 
            this.btnConsultProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultProduct.Location = new System.Drawing.Point(442, 66);
            this.btnConsultProduct.Name = "btnConsultProduct";
            this.btnConsultProduct.Size = new System.Drawing.Size(36, 24);
            this.btnConsultProduct.TabIndex = 35;
            this.btnConsultProduct.UseVisualStyleBackColor = true;
            this.btnConsultProduct.Click += new System.EventHandler(this.btnConsultProduct_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 36;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(76, 69);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(280, 20);
            this.txtProduct.TabIndex = 37;
            // 
            // frmInsertEPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 413);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnConsultProduct);
            this.Controls.Add(this.btnConsultEmployee);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnPrintOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.rbTerm);
            this.Controls.Add(this.rbSpot);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSpot);
            this.Controls.Add(this.lblSpot);
            this.Controls.Add(this.txtCodProduct);
            this.Controls.Add(this.lblCodProduct);
            this.Controls.Add(this.btnSalve);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtCodEpi);
            this.Controls.Add(this.lblCodEpi);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgEPI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInsertEPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar EPI";
            this.Load += new System.EventHandler(this.frmInsertEPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCodEpi;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSalve;
        private System.Windows.Forms.Label lblCodProduct;
        public System.Windows.Forms.TextBox txtCodProduct;
        public System.Windows.Forms.DataGridView dgEPI;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.MaskedTextBox mtbDate;
        public System.Windows.Forms.TextBox txtSpot;
        private System.Windows.Forms.Label lblSpot;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.TextBox txtCodEpi;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrintOut;
        public System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        public System.Windows.Forms.RadioButton rbSpot;
        public System.Windows.Forms.RadioButton rbTerm;
        private System.Windows.Forms.Button btnConsultEmployee;
        private System.Windows.Forms.Button btnConsultProduct;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtProduct;
    }
}