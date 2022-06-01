
namespace SisFin
{
    partial class frmConta
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.dgConta = new System.Windows.Forms.DataGridView();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.grpConta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgConta)).BeginInit();
            this.grpConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 72);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(55, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(6, 88);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(516, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 133);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(551, 169);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 4;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // dgConta
            // 
            this.dgConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConta.Location = new System.Drawing.Point(24, 224);
            this.dgConta.Name = "dgConta";
            this.dgConta.Size = new System.Drawing.Size(613, 220);
            this.dgConta.TabIndex = 3;
            this.dgConta.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConta_RowEnter);

            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(6, 149);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(297, 21);
            this.cboCategoria.TabIndex = 3;
            // 
            // grpConta
            // 
            this.grpConta.Controls.Add(this.cboCategoria);
            this.grpConta.Controls.Add(this.chkStatus);
            this.grpConta.Controls.Add(this.txtDesc);
            this.grpConta.Controls.Add(this.txtNome);
            this.grpConta.Controls.Add(this.lblCategoria);
            this.grpConta.Controls.Add(this.lblDesc);
            this.grpConta.Controls.Add(this.lblNome);
            this.grpConta.Location = new System.Drawing.Point(24, 12);
            this.grpConta.Name = "grpConta";
            this.grpConta.Size = new System.Drawing.Size(613, 206);
            this.grpConta.TabIndex = 6;
            this.grpConta.TabStop = false;
            // 
            // frmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.grpConta);
            this.Controls.Add(this.dgConta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConta";
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.frmConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConta)).EndInit();
            this.grpConta.ResumeLayout(false);
            this.grpConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.DataGridView dgConta;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.GroupBox grpConta;
    }
}