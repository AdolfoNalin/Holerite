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
            this.txtCodEmp = new System.Windows.Forms.TextBox();
            this.lblCodEmp = new System.Windows.Forms.Label();
            this.txtCodProduct = new System.Windows.Forms.TextBox();
            this.lblCodProduct = new System.Windows.Forms.Label();
            this.txtSpot = new System.Windows.Forms.TextBox();
            this.lblSpot = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.rbSpot = new System.Windows.Forms.RadioButton();
            this.rbTerm = new System.Windows.Forms.RadioButton();
            this.txtCodEpi = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintOut = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEPI)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEPI
            // 
            this.dgEPI.AllowUserToAddRows = false;
            this.dgEPI.AllowUserToDeleteRows = false;
            this.dgEPI.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgEPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEPI.Location = new System.Drawing.Point(599, 12);
            this.dgEPI.Name = "dgEPI";
            this.dgEPI.ReadOnly = true;
            this.dgEPI.Size = new System.Drawing.Size(296, 219);
            this.dgEPI.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(518, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(518, 41);
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
            this.lblName.Location = new System.Drawing.Point(46, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome:";
            // 
            // lblCodEpi
            // 
            this.lblCodEpi.AutoSize = true;
            this.lblCodEpi.Location = new System.Drawing.Point(55, 9);
            this.lblCodEpi.Name = "lblCodEpi";
            this.lblCodEpi.Size = new System.Drawing.Size(29, 13);
            this.lblCodEpi.TabIndex = 5;
            this.lblCodEpi.Text = "Cod:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(46, 134);
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
            this.mtbDate.Location = new System.Drawing.Point(405, 15);
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
            // txtCodEmp
            // 
            this.txtCodEmp.Location = new System.Drawing.Point(405, 63);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.Size = new System.Drawing.Size(37, 20);
            this.txtCodEmp.TabIndex = 17;
            // 
            // lblCodEmp
            // 
            this.lblCodEmp.AutoSize = true;
            this.lblCodEmp.Location = new System.Drawing.Point(373, 66);
            this.lblCodEmp.Name = "lblCodEmp";
            this.lblCodEmp.Size = new System.Drawing.Size(29, 13);
            this.lblCodEmp.TabIndex = 16;
            this.lblCodEmp.Text = "Cod:";
            // 
            // txtCodProduct
            // 
            this.txtCodProduct.Location = new System.Drawing.Point(405, 131);
            this.txtCodProduct.Name = "txtCodProduct";
            this.txtCodProduct.Size = new System.Drawing.Size(37, 20);
            this.txtCodProduct.TabIndex = 19;
            // 
            // lblCodProduct
            // 
            this.lblCodProduct.AutoSize = true;
            this.lblCodProduct.Location = new System.Drawing.Point(373, 134);
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
            this.lblTotal.Location = new System.Drawing.Point(656, 240);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total:";
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(87, 131);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(276, 21);
            this.cbProduct.TabIndex = 23;
            this.cbProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbServece_KeyPress);
            // 
            // rbSpot
            // 
            this.rbSpot.AutoSize = true;
            this.rbSpot.Location = new System.Drawing.Point(535, 83);
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
            this.rbTerm.Location = new System.Drawing.Point(535, 106);
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
            this.txtCodEpi.Location = new System.Drawing.Point(87, 6);
            this.txtCodEpi.Name = "txtCodEpi";
            this.txtCodEpi.Size = new System.Drawing.Size(37, 20);
            this.txtCodEpi.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(696, 237);
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
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(87, 66);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(276, 21);
            this.cbEmployee.TabIndex = 29;
            this.cbEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEmployee_KeyPress);
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
            // frmInsertEPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 413);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnPrintOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.rbTerm);
            this.Controls.Add(this.rbSpot);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSpot);
            this.Controls.Add(this.lblSpot);
            this.Controls.Add(this.txtCodProduct);
            this.Controls.Add(this.lblCodProduct);
            this.Controls.Add(this.txtCodEmp);
            this.Controls.Add(this.lblCodEmp);
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
        private System.Windows.Forms.Label lblCodEmp;
        private System.Windows.Forms.Label lblCodProduct;
        public System.Windows.Forms.TextBox txtCodEmp;
        public System.Windows.Forms.TextBox txtCodProduct;
        public System.Windows.Forms.DataGridView dgEPI;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.MaskedTextBox mtbDate;
        public System.Windows.Forms.TextBox txtSpot;
        private System.Windows.Forms.Label lblSpot;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cbProduct;
        public System.Windows.Forms.TextBox txtCodEpi;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label lblTerm;
        public System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrintOut;
        public System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        public System.Windows.Forms.RadioButton rbSpot;
        public System.Windows.Forms.RadioButton rbTerm;
    }
}