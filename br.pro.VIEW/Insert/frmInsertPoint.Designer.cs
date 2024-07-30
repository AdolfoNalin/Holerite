namespace Holerite.br.pro.VIEW
{
    partial class frmInsertPoint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgPoint = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchEntrance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrntOut = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoint)).BeginInit();
            this.gbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPoint
            // 
            this.dgPoint.AllowUserToOrderColumns = true;
            this.dgPoint.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.entryTime,
            this.lunchDeparture,
            this.lunchEntrance,
            this.exitTime,
            this.extraEntry,
            this.extraOutput});
            this.dgPoint.Location = new System.Drawing.Point(12, 210);
            this.dgPoint.Name = "dgPoint";
            this.dgPoint.Size = new System.Drawing.Size(793, 317);
            this.dgPoint.TabIndex = 0;
            // 
            // date
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle1;
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // entryTime
            // 
            this.entryTime.HeaderText = "Hora Entrada";
            this.entryTime.Name = "entryTime";
            // 
            // lunchDeparture
            // 
            this.lunchDeparture.HeaderText = "Saida Almoço";
            this.lunchDeparture.Name = "lunchDeparture";
            // 
            // lunchEntrance
            // 
            this.lunchEntrance.HeaderText = "Entrada  Almoço";
            this.lunchEntrance.Name = "lunchEntrance";
            this.lunchEntrance.Width = 150;
            // 
            // exitTime
            // 
            this.exitTime.HeaderText = "Hora Saida";
            this.exitTime.Name = "exitTime";
            // 
            // extraEntry
            // 
            this.extraEntry.HeaderText = "Entrada Extra";
            this.extraEntry.Name = "extraEntry";
            // 
            // extraOutput
            // 
            this.extraOutput.HeaderText = "Saida Extra";
            this.extraOutput.Name = "extraOutput";
            // 
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.txtFunction);
            this.gbEmployee.Controls.Add(this.lblFunction);
            this.gbEmployee.Controls.Add(this.txtAddress);
            this.gbEmployee.Controls.Add(this.lblAddress);
            this.gbEmployee.Controls.Add(this.lblCPF);
            this.gbEmployee.Controls.Add(this.mtbCPF);
            this.gbEmployee.Controls.Add(this.btnSearchEmp);
            this.gbEmployee.Controls.Add(this.txtNameEmployee);
            this.gbEmployee.Controls.Add(this.lblName);
            this.gbEmployee.Location = new System.Drawing.Point(12, 34);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(793, 141);
            this.gbEmployee.TabIndex = 2;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "Funcionário";
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(632, 22);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(130, 20);
            this.txtFunction.TabIndex = 8;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(592, 25);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(38, 13);
            this.lblFunction.TabIndex = 7;
            this.lblFunction.Text = "Cargo:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(73, 79);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(595, 51);
            this.txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 80);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Endereço:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(459, 26);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(490, 22);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(83, 20);
            this.mtbCPF.TabIndex = 3;
            this.mtbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCPF_KeyPress);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Location = new System.Drawing.Point(347, 20);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(75, 23);
            this.btnSearchEmp.TabIndex = 2;
            this.btnSearchEmp.Text = "Pesquisar";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Location = new System.Drawing.Point(55, 22);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(288, 20);
            this.txtNameEmployee.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(399, 576);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 73);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(222, 576);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 73);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrntOut
            // 
            this.btnPrntOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrntOut.Location = new System.Drawing.Point(592, 576);
            this.btnPrntOut.Name = "btnPrntOut";
            this.btnPrntOut.Size = new System.Drawing.Size(133, 73);
            this.btnPrntOut.TabIndex = 6;
            this.btnPrntOut.Text = "Imprimir";
            this.btnPrntOut.UseVisualStyleBackColor = true;
            this.btnPrntOut.Click += new System.EventHandler(this.btnPrntOut_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(56, 576);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(133, 73);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Cadastrar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(71, 8);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(38, 20);
            this.txtCod.TabIndex = 10;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(27, 11);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 9;
            this.lblCod.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(691, 8);
            this.maskedTextBox1.Mask = "00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(52, 20);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // frmInsertPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnPrntOut);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbEmployee);
            this.Controls.Add(this.dgPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInsertPoint";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmInsertPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPoint)).EndInit();
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrntOut;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunchDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunchEntrance;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraOutput;
        private System.Windows.Forms.Label lblCod;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.DataGridView dgPoint;
        public System.Windows.Forms.TextBox txtNameEmployee;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.MaskedTextBox mtbCPF;
        public System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}