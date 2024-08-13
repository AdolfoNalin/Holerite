namespace Holerite.br.pro.VIEW.Consult
{
    partial class frmConsultEmpGeneratePoint
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.Calender = new System.Windows.Forms.MonthCalendar();
            this.dgGeneratePoint = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneratePoint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(314, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(555, 99);
            this.Calender.MaxSelectionCount = 31;
            this.Calender.Name = "Calender";
            this.Calender.TabIndex = 3;
            // 
            // dgGeneratePoint
            // 
            this.dgGeneratePoint.AllowUserToAddRows = false;
            this.dgGeneratePoint.AllowUserToDeleteRows = false;
            this.dgGeneratePoint.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgGeneratePoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGeneratePoint.Location = new System.Drawing.Point(33, 99);
            this.dgGeneratePoint.Name = "dgGeneratePoint";
            this.dgGeneratePoint.ReadOnly = true;
            this.dgGeneratePoint.Size = new System.Drawing.Size(521, 317);
            this.dgGeneratePoint.TabIndex = 4;
            this.dgGeneratePoint.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGeneratePoint_CellDoubleClick);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(711, 376);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(82, 40);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Gerar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmConsultEmpGeneratePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgGeneratePoint);
            this.Controls.Add(this.Calender);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultEmpGeneratePoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Ponto";
            this.Load += new System.EventHandler(this.frmConsultEmpGeneratePoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneratePoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGenerate;
        public System.Windows.Forms.MonthCalendar Calender;
        public System.Windows.Forms.DataGridView dgGeneratePoint;
    }
}