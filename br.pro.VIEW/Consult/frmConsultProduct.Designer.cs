namespace Holerite.br.pro.VIEW.Consult
{
    partial class frmConsultProduct
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
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.AutoSize = true;
            this.lblShortDescription.Location = new System.Drawing.Point(54, 76);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(103, 13);
            this.lblShortDescription.TabIndex = 0;
            this.lblShortDescription.Text = "Descrição resumida:";
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(158, 73);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(225, 20);
            this.txtShortDescription.TabIndex = 1;
            this.txtShortDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShortDescription_KeyPress);
            // 
            // dgProduct
            // 
            this.dgProduct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(12, 141);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.Size = new System.Drawing.Size(776, 297);
            this.dgProduct.TabIndex = 2;
            this.dgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(389, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmConsultProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgProduct);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.lblShortDescription);
            this.Name = "frmConsultProduct";
            this.Text = "Consulta Produto";
            this.Load += new System.EventHandler(this.frmConsultProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnSearch;
    }
}