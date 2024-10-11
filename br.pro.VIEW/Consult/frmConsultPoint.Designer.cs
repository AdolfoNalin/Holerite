namespace Holerite.br.pro.VIEW.Consult
{
    partial class frmConsultPoint
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgPoint = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.btnSearchDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 1;
            // 
            // dgPoint
            // 
            this.dgPoint.AllowUserToAddRows = false;
            this.dgPoint.AllowUserToDeleteRows = false;
            this.dgPoint.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoint.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgPoint.Location = new System.Drawing.Point(34, 106);
            this.dgPoint.Name = "dgPoint";
            this.dgPoint.ReadOnly = true;
            this.dgPoint.Size = new System.Drawing.Size(363, 332);
            this.dgPoint.TabIndex = 2;
            this.dgPoint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPoint_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(287, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(456, 39);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(98, 20);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(456, 64);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(98, 20);
            this.dtpEndDate.TabIndex = 5;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(393, 41);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(61, 13);
            this.lblDateStart.TabIndex = 6;
            this.lblDateStart.Text = "Data Inicio:";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(398, 67);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(52, 13);
            this.lblDateEnd.TabIndex = 7;
            this.lblDateEnd.Text = "Data Fim:";
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(466, 96);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDate.TabIndex = 8;
            this.btnSearchDate.Text = "Pesquisar";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // frmConsultPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgPoint);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Ponto";
            this.Load += new System.EventHandler(this.frmConsultPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgPoint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Button btnSearchDate;
    }
}