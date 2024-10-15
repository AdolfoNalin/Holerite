namespace Holerite.br.pro.VIEW.Insert
{
    partial class frmInsertBudget
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
            this.dgBudget = new System.Windows.Forms.DataGridView();
            this.lblFuncionário = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblSeverce = new System.Windows.Forms.Label();
            this.rbSpot = new System.Windows.Forms.RadioButton();
            this.rbTerm = new System.Windows.Forms.RadioButton();
            this.lblSpot = new System.Windows.Forms.Label();
            this.txtSpot = new System.Windows.Forms.TextBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintOut = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCodService = new System.Windows.Forms.TextBox();
            this.lblUM = new System.Windows.Forms.Label();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCodBudget = new System.Windows.Forms.TextBox();
            this.lblOBS = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnConsultEmployee = new System.Windows.Forms.Button();
            this.btnConsultClient = new System.Windows.Forms.Button();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.btnConsultService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBudget
            // 
            this.dgBudget.AllowUserToAddRows = false;
            this.dgBudget.AllowUserToDeleteRows = false;
            this.dgBudget.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBudget.Location = new System.Drawing.Point(522, 57);
            this.dgBudget.Name = "dgBudget";
            this.dgBudget.ReadOnly = true;
            this.dgBudget.Size = new System.Drawing.Size(551, 360);
            this.dgBudget.TabIndex = 0;
            // 
            // lblFuncionário
            // 
            this.lblFuncionário.AutoSize = true;
            this.lblFuncionário.Location = new System.Drawing.Point(32, 62);
            this.lblFuncionário.Name = "lblFuncionário";
            this.lblFuncionário.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionário.TabIndex = 1;
            this.lblFuncionário.Text = "Funcionário:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(57, 99);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblSeverce
            // 
            this.lblSeverce.AutoSize = true;
            this.lblSeverce.Location = new System.Drawing.Point(53, 164);
            this.lblSeverce.Name = "lblSeverce";
            this.lblSeverce.Size = new System.Drawing.Size(46, 13);
            this.lblSeverce.TabIndex = 6;
            this.lblSeverce.Text = "Serviço:";
            // 
            // rbSpot
            // 
            this.rbSpot.AutoSize = true;
            this.rbSpot.Location = new System.Drawing.Point(522, 34);
            this.rbSpot.Name = "rbSpot";
            this.rbSpot.Size = new System.Drawing.Size(58, 17);
            this.rbSpot.TabIndex = 8;
            this.rbSpot.TabStop = true;
            this.rbSpot.Text = "Á Vista";
            this.rbSpot.UseVisualStyleBackColor = true;
            this.rbSpot.CheckedChanged += new System.EventHandler(this.rbSpot_CheckedChanged);
            // 
            // rbTerm
            // 
            this.rbTerm.AutoSize = true;
            this.rbTerm.Location = new System.Drawing.Point(613, 34);
            this.rbTerm.Name = "rbTerm";
            this.rbTerm.Size = new System.Drawing.Size(61, 17);
            this.rbTerm.TabIndex = 9;
            this.rbTerm.TabStop = true;
            this.rbTerm.Text = "Á prazo";
            this.rbTerm.UseVisualStyleBackColor = true;
            this.rbTerm.CheckedChanged += new System.EventHandler(this.rbTerm_CheckedChanged);
            // 
            // lblSpot
            // 
            this.lblSpot.AutoSize = true;
            this.lblSpot.Location = new System.Drawing.Point(56, 199);
            this.lblSpot.Name = "lblSpot";
            this.lblSpot.Size = new System.Drawing.Size(42, 13);
            this.lblSpot.TabIndex = 11;
            this.lblSpot.Text = "Á vista:";
            // 
            // txtSpot
            // 
            this.txtSpot.Location = new System.Drawing.Point(100, 196);
            this.txtSpot.Name = "txtSpot";
            this.txtSpot.Size = new System.Drawing.Size(58, 20);
            this.txtSpot.TabIndex = 10;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(53, 225);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(46, 13);
            this.lblTerm.TabIndex = 13;
            this.lblTerm.Text = "Á prazo:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(100, 222);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(58, 20);
            this.txtTerm.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(327, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(327, 227);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 33);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(839, 467);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(873, 464);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(79, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(826, 441);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 18;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(873, 438);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(71, 20);
            this.txtSubtotal.TabIndex = 17;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(286, 492);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(102, 44);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Cadastrar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(40, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 44);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintOut
            // 
            this.btnPrintOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintOut.Location = new System.Drawing.Point(163, 492);
            this.btnPrintOut.Name = "btnPrintOut";
            this.btnPrintOut.Size = new System.Drawing.Size(102, 44);
            this.btnPrintOut.TabIndex = 25;
            this.btnPrintOut.Text = "Emprimir";
            this.btnPrintOut.UseVisualStyleBackColor = true;
            this.btnPrintOut.Click += new System.EventHandler(this.btnPrintOut_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(332, 165);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(29, 13);
            this.lblCod.TabIndex = 28;
            this.lblCod.Text = "Cod:";
            //
            // txtCodService
            // 
            this.txtCodService.Location = new System.Drawing.Point(362, 162);
            this.txtCodService.Name = "txtCodService";
            this.txtCodService.Size = new System.Drawing.Size(32, 20);
            this.txtCodService.TabIndex = 27;
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Location = new System.Drawing.Point(176, 198);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(64, 13);
            this.lblUM.TabIndex = 30;
            this.lblUM.Text = "Uni. Medida";
            this.lblUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(243, 196);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(59, 20);
            this.txtUM.TabIndex = 29;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(176, 227);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 13);
            this.lblAmount.TabIndex = 32;
            this.lblAmount.Text = "Quantidade:";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(243, 225);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(59, 20);
            this.txtAmount.TabIndex = 31;
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(1006, 23);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(67, 20);
            this.mtbDate.TabIndex = 33;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(970, 26);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 34;
            this.lblData.Text = "Data:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(69, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(29, 13);
            this.lbl.TabIndex = 36;
            this.lbl.Text = "Cod:";
            // 
            // txtCodBudget
            // 
            this.txtCodBudget.Location = new System.Drawing.Point(99, 12);
            this.txtCodBudget.Name = "txtCodBudget";
            this.txtCodBudget.Size = new System.Drawing.Size(58, 20);
            this.txtCodBudget.TabIndex = 35;
            // 
            // lblOBS
            // 
            this.lblOBS.AutoSize = true;
            this.lblOBS.Location = new System.Drawing.Point(69, 325);
            this.lblOBS.Name = "lblOBS";
            this.lblOBS.Size = new System.Drawing.Size(29, 13);
            this.lblOBS.TabIndex = 40;
            this.lblOBS.Text = "Obs:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(99, 322);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(317, 95);
            this.txtObs.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(413, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 44);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(536, 492);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(102, 44);
            this.btnClean.TabIndex = 42;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnConsultEmployee
            // 
            this.btnConsultEmployee.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnConsultEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultEmployee.Location = new System.Drawing.Point(367, 57);
            this.btnConsultEmployee.Name = "btnConsultEmployee";
            this.btnConsultEmployee.Size = new System.Drawing.Size(43, 23);
            this.btnConsultEmployee.TabIndex = 43;
            this.btnConsultEmployee.UseVisualStyleBackColor = true;
            this.btnConsultEmployee.Click += new System.EventHandler(this.btnConsultEmployee_Click);
            // 
            // btnConsultClient
            // 
            this.btnConsultClient.Location = new System.Drawing.Point(367, 94);
            this.btnConsultClient.Name = "btnConsultClient";
            this.btnConsultClient.Size = new System.Drawing.Size(43, 23);
            this.btnConsultClient.TabIndex = 44;
            this.btnConsultClient.UseVisualStyleBackColor = true;
            this.btnConsultClient.Click += new System.EventHandler(this.btnConsultClient_Click);
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(100, 59);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(261, 20);
            this.txtEmployee.TabIndex = 45;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(100, 95);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(261, 20);
            this.txtClient.TabIndex = 46;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(105, 162);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(210, 20);
            this.txtService.TabIndex = 47;
            // 
            // btnConsultService
            // 
            this.btnConsultService.Location = new System.Drawing.Point(400, 160);
            this.btnConsultService.Name = "btnConsultService";
            this.btnConsultService.Size = new System.Drawing.Size(43, 23);
            this.btnConsultService.TabIndex = 48;
            this.btnConsultService.UseVisualStyleBackColor = true;
            this.btnConsultService.Click += new System.EventHandler(this.btnConsultService_Click);
            // 
            // frmInsertBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 580);
            this.Controls.Add(this.btnConsultService);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.btnConsultClient);
            this.Controls.Add(this.btnConsultEmployee);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblOBS);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtCodBudget);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblUM);
            this.Controls.Add(this.txtUM);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtCodService);
            this.Controls.Add(this.btnPrintOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblSpot);
            this.Controls.Add(this.txtSpot);
            this.Controls.Add(this.rbTerm);
            this.Controls.Add(this.rbSpot);
            this.Controls.Add(this.lblSeverce);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFuncionário);
            this.Controls.Add(this.dgBudget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInsertBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Orçamento";
            this.Load += new System.EventHandler(this.frmInsertBudget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFuncionário;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblSeverce;
        private System.Windows.Forms.Label lblSpot;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintOut;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblUM;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox txtSpot;
        public System.Windows.Forms.TextBox txtTerm;
        public System.Windows.Forms.TextBox txtCodService;
        public System.Windows.Forms.TextBox txtUM;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblOBS;
        public System.Windows.Forms.RadioButton rbSpot;
        public System.Windows.Forms.RadioButton rbTerm;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtSubtotal;
        public System.Windows.Forms.MaskedTextBox mtbDate;
        public System.Windows.Forms.TextBox txtCodBudget;
        public System.Windows.Forms.TextBox txtObs;
        public System.Windows.Forms.DataGridView dgBudget;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnConsultEmployee;
        private System.Windows.Forms.Button btnConsultClient;
        public System.Windows.Forms.TextBox txtEmployee;
        public System.Windows.Forms.TextBox txtClient;
        public System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button btnConsultService;
    }
}