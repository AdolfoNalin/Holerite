namespace Holerite.br.pro.VIEW.Insert
{
    partial class frmGenerateEPI
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
            this.dgEpi = new System.Windows.Forms.DataGridView();
            this.btnGerate = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEpi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(399, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgEpi
            // 
            this.dgEpi.AllowUserToAddRows = false;
            this.dgEpi.AllowUserToDeleteRows = false;
            this.dgEpi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgEpi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEpi.Location = new System.Drawing.Point(35, 101);
            this.dgEpi.Name = "dgEpi";
            this.dgEpi.ReadOnly = true;
            this.dgEpi.Size = new System.Drawing.Size(723, 324);
            this.dgEpi.TabIndex = 3;
            // 
            // btnGerate
            // 
            this.btnGerate.Location = new System.Drawing.Point(657, 42);
            this.btnGerate.Name = "btnGerate";
            this.btnGerate.Size = new System.Drawing.Size(75, 23);
            this.btnGerate.TabIndex = 4;
            this.btnGerate.Text = "Gerar";
            this.btnGerate.UseVisualStyleBackColor = true;
            this.btnGerate.Click += new System.EventHandler(this.btnGerate_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(617, 43);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(34, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(547, 46);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 13);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Quantidade:";
            // 
            // frmGenerateEPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnGerate);
            this.Controls.Add(this.dgEpi);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGenerateEPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar EPI";
            this.Load += new System.EventHandler(this.frmGenerateEPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEpi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgEpi;
        private System.Windows.Forms.Button btnGerate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
    }
}