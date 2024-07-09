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
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblSeverce = new System.Windows.Forms.Label();
            this.txtSeverve = new System.Windows.Forms.TextBox();
            this.btnSearchSeverce = new System.Windows.Forms.Button();
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
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnToRecord = new System.Windows.Forms.Button();
            this.btnConfirme = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBudget
            // 
            this.dgBudget.AllowUserToAddRows = false;
            this.dgBudget.AllowUserToDeleteRows = false;
            this.dgBudget.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBudget.Location = new System.Drawing.Point(522, 87);
            this.dgBudget.Name = "dgBudget";
            this.dgBudget.ReadOnly = true;
            this.dgBudget.Size = new System.Drawing.Size(551, 360);
            this.dgBudget.TabIndex = 0;
            // 
            // lblFuncionário
            // 
            this.lblFuncionário.AutoSize = true;
            this.lblFuncionário.Location = new System.Drawing.Point(29, 42);
            this.lblFuncionário.Name = "lblFuncionário";
            this.lblFuncionário.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionário.TabIndex = 1;
            this.lblFuncionário.Text = "Funcionário:";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(100, 76);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(211, 20);
            this.txtClient.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(56, 79);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblSeverce
            // 
            this.lblSeverce.AutoSize = true;
            this.lblSeverce.Location = new System.Drawing.Point(53, 203);
            this.lblSeverce.Name = "lblSeverce";
            this.lblSeverce.Size = new System.Drawing.Size(46, 13);
            this.lblSeverce.TabIndex = 6;
            this.lblSeverce.Text = "Serviço:";
            // 
            // txtSeverve
            // 
            this.txtSeverve.Location = new System.Drawing.Point(100, 200);
            this.txtSeverve.Name = "txtSeverve";
            this.txtSeverve.Size = new System.Drawing.Size(211, 20);
            this.txtSeverve.TabIndex = 5;
            // 
            // btnSearchSeverce
            // 
            this.btnSearchSeverce.Location = new System.Drawing.Point(317, 198);
            this.btnSearchSeverce.Name = "btnSearchSeverce";
            this.btnSearchSeverce.Size = new System.Drawing.Size(28, 23);
            this.btnSearchSeverce.TabIndex = 7;
            this.btnSearchSeverce.UseVisualStyleBackColor = true;
            this.btnSearchSeverce.Click += new System.EventHandler(this.btnSearchSeverce_Click);
            // 
            // rbSpot
            // 
            this.rbSpot.AutoSize = true;
            this.rbSpot.Location = new System.Drawing.Point(522, 64);
            this.rbSpot.Name = "rbSpot";
            this.rbSpot.Size = new System.Drawing.Size(61, 17);
            this.rbSpot.TabIndex = 8;
            this.rbSpot.TabStop = true;
            this.rbSpot.Text = "Á prazo";
            this.rbSpot.UseVisualStyleBackColor = true;
            // 
            // rbTerm
            // 
            this.rbTerm.AutoSize = true;
            this.rbTerm.Location = new System.Drawing.Point(613, 64);
            this.rbTerm.Name = "rbTerm";
            this.rbTerm.Size = new System.Drawing.Size(61, 17);
            this.rbTerm.TabIndex = 9;
            this.rbTerm.TabStop = true;
            this.rbTerm.Text = "Á prazo";
            this.rbTerm.UseVisualStyleBackColor = true;
            // 
            // lblSpot
            // 
            this.lblSpot.AutoSize = true;
            this.lblSpot.Location = new System.Drawing.Point(56, 238);
            this.lblSpot.Name = "lblSpot";
            this.lblSpot.Size = new System.Drawing.Size(42, 13);
            this.lblSpot.TabIndex = 11;
            this.lblSpot.Text = "Á vista:";
            // 
            // txtSpot
            // 
            this.txtSpot.Location = new System.Drawing.Point(100, 235);
            this.txtSpot.Name = "txtSpot";
            this.txtSpot.Size = new System.Drawing.Size(58, 20);
            this.txtSpot.TabIndex = 10;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(206, 238);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(46, 13);
            this.lblTerm.TabIndex = 13;
            this.lblTerm.Text = "Á prazo:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(253, 235);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(58, 20);
            this.txtTerm.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(427, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(427, 409);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 33);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
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
            this.lblSubtotal.Location = new System.Drawing.Point(686, 467);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 18;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(733, 464);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(71, 20);
            this.txtSubtotal.TabIndex = 17;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(100, 39);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(211, 21);
            this.cbEmployee.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(317, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnToRecord
            // 
            this.btnToRecord.Location = new System.Drawing.Point(56, 392);
            this.btnToRecord.Name = "btnToRecord";
            this.btnToRecord.Size = new System.Drawing.Size(102, 44);
            this.btnToRecord.TabIndex = 22;
            this.btnToRecord.Text = "Gravar";
            this.btnToRecord.UseVisualStyleBackColor = true;
            // 
            // btnConfirme
            // 
            this.btnConfirme.Location = new System.Drawing.Point(56, 442);
            this.btnConfirme.Name = "btnConfirme";
            this.btnConfirme.Size = new System.Drawing.Size(102, 44);
            this.btnConfirme.TabIndex = 23;
            this.btnConfirme.Text = "Comfirmar";
            this.btnConfirme.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(56, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 44);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnPrintOut
            // 
            this.btnPrintOut.Location = new System.Drawing.Point(56, 342);
            this.btnPrintOut.Name = "btnPrintOut";
            this.btnPrintOut.Size = new System.Drawing.Size(102, 44);
            this.btnPrintOut.TabIndex = 25;
            this.btnPrintOut.Text = "Emprimir";
            this.btnPrintOut.UseVisualStyleBackColor = true;
            // 
            // frmInsertBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 580);
            this.Controls.Add(this.btnPrintOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirme);
            this.Controls.Add(this.btnToRecord);
            this.Controls.Add(this.btnSearch);
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
            this.Controls.Add(this.btnSearchSeverce);
            this.Controls.Add(this.lblSeverce);
            this.Controls.Add(this.txtSeverve);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.lblFuncionário);
            this.Controls.Add(this.dgBudget);
            this.Name = "frmInsertBudget";
            this.Text = "Cadastrar Orçamento";
            this.Load += new System.EventHandler(this.frmInsertBudget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBudget;
        private System.Windows.Forms.Label lblFuncionário;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblSeverce;
        private System.Windows.Forms.TextBox txtSeverve;
        private System.Windows.Forms.Button btnSearchSeverce;
        private System.Windows.Forms.RadioButton rbSpot;
        private System.Windows.Forms.RadioButton rbTerm;
        private System.Windows.Forms.Label lblSpot;
        private System.Windows.Forms.TextBox txtSpot;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnToRecord;
        private System.Windows.Forms.Button btnConfirme;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintOut;
    }
}