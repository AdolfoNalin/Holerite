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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertPoint));
            this.dgPoint = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchEntrance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.txtCodEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeletePoint = new System.Windows.Forms.Button();
            this.btnGenarete = new System.Windows.Forms.Button();
            this.txtCodCompany = new System.Windows.Forms.TextBox();
            this.lblCodCompany = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoint)).BeginInit();
            this.gbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPoint
            // 
            this.dgPoint.AllowUserToOrderColumns = true;
            this.dgPoint.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPoint.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPoint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.entryTime,
            this.lunchDeparture,
            this.lunchEntrance,
            this.exitTime,
            this.extraEntry,
            this.extraOutput});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPoint.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.dgPoint, "dgPoint");
            this.dgPoint.Name = "dgPoint";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Format = "d";
            this.date.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // entryTime
            // 
            resources.ApplyResources(this.entryTime, "entryTime");
            this.entryTime.Name = "entryTime";
            // 
            // lunchDeparture
            // 
            resources.ApplyResources(this.lunchDeparture, "lunchDeparture");
            this.lunchDeparture.Name = "lunchDeparture";
            // 
            // lunchEntrance
            // 
            resources.ApplyResources(this.lunchEntrance, "lunchEntrance");
            this.lunchEntrance.Name = "lunchEntrance";
            // 
            // exitTime
            // 
            resources.ApplyResources(this.exitTime, "exitTime");
            this.exitTime.Name = "exitTime";
            // 
            // extraEntry
            // 
            resources.ApplyResources(this.extraEntry, "extraEntry");
            this.extraEntry.Name = "extraEntry";
            // 
            // extraOutput
            // 
            resources.ApplyResources(this.extraOutput, "extraOutput");
            this.extraOutput.Name = "extraOutput";
            // 
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.txtCodEmployee);
            this.gbEmployee.Controls.Add(this.label2);
            this.gbEmployee.Controls.Add(this.txtFunction);
            this.gbEmployee.Controls.Add(this.lblFunction);
            this.gbEmployee.Controls.Add(this.txtAddress);
            this.gbEmployee.Controls.Add(this.lblAddress);
            this.gbEmployee.Controls.Add(this.lblCPF);
            this.gbEmployee.Controls.Add(this.mtbCPF);
            this.gbEmployee.Controls.Add(this.btnSearchEmp);
            this.gbEmployee.Controls.Add(this.txtNameEmployee);
            this.gbEmployee.Controls.Add(this.lblName);
            resources.ApplyResources(this.gbEmployee, "gbEmployee");
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.TabStop = false;
            // 
            // txtCodEmployee
            // 
            resources.ApplyResources(this.txtCodEmployee, "txtCodEmployee");
            this.txtCodEmployee.Name = "txtCodEmployee";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtFunction
            // 
            resources.ApplyResources(this.txtFunction, "txtFunction");
            this.txtFunction.Name = "txtFunction";
            // 
            // lblFunction
            // 
            resources.ApplyResources(this.lblFunction, "lblFunction");
            this.lblFunction.Name = "lblFunction";
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            // 
            // lblAddress
            // 
            resources.ApplyResources(this.lblAddress, "lblAddress");
            this.lblAddress.Name = "lblAddress";
            // 
            // lblCPF
            // 
            resources.ApplyResources(this.lblCPF, "lblCPF");
            this.lblCPF.Name = "lblCPF";
            // 
            // mtbCPF
            // 
            resources.ApplyResources(this.mtbCPF, "mtbCPF");
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCPF_KeyPress);
            // 
            // btnSearchEmp
            // 
            resources.ApplyResources(this.btnSearchEmp, "btnSearchEmp");
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // txtNameEmployee
            // 
            resources.ApplyResources(this.txtNameEmployee, "txtNameEmployee");
            this.txtNameEmployee.Name = "txtNameEmployee";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // txtCod
            // 
            resources.ApplyResources(this.txtCod, "txtCod");
            this.txtCod.Name = "txtCod";
            // 
            // lblCod
            // 
            resources.ApplyResources(this.lblCod, "lblCod");
            this.lblCod.Name = "lblCod";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // mtbDate
            // 
            resources.ApplyResources(this.mtbDate, "mtbDate");
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeletePoint
            // 
            resources.ApplyResources(this.btnDeletePoint, "btnDeletePoint");
            this.btnDeletePoint.Name = "btnDeletePoint";
            this.btnDeletePoint.UseVisualStyleBackColor = true;
            this.btnDeletePoint.Click += new System.EventHandler(this.btnDeletePoint_Click);
            // 
            // btnGenarete
            // 
            resources.ApplyResources(this.btnGenarete, "btnGenarete");
            this.btnGenarete.Name = "btnGenarete";
            this.btnGenarete.UseVisualStyleBackColor = true;
            this.btnGenarete.Click += new System.EventHandler(this.btnGenarete_Click);
            // 
            // txtCodCompany
            // 
            resources.ApplyResources(this.txtCodCompany, "txtCodCompany");
            this.txtCodCompany.Name = "txtCodCompany";
            // 
            // lblCodCompany
            // 
            resources.ApplyResources(this.lblCodCompany, "lblCodCompany");
            this.lblCodCompany.Name = "lblCodCompany";
            // 
            // frmInsertPoint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCodCompany);
            this.Controls.Add(this.lblCodCompany);
            this.Controls.Add(this.btnGenarete);
            this.Controls.Add(this.btnDeletePoint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.gbEmployee);
            this.Controls.Add(this.dgPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInsertPoint";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.Label lblCod;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.DataGridView dgPoint;
        public System.Windows.Forms.TextBox txtNameEmployee;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.MaskedTextBox mtbCPF;
        public System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunchDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunchEntrance;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraOutput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeletePoint;
        private System.Windows.Forms.Button btnGenarete;
        public System.Windows.Forms.TextBox txtCodCompany;
        private System.Windows.Forms.Label lblCodCompany;
        public System.Windows.Forms.TextBox txtCodEmployee;
        private System.Windows.Forms.Label label2;
    }
}