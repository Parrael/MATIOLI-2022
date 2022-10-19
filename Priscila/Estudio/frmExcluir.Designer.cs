
namespace Estudio
{
    partial class FrmExcluir
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
            this.txtExcluir = new System.Windows.Forms.MaskedTextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExcluir
            // 
            this.txtExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcluir.Location = new System.Drawing.Point(107, 38);
            this.txtExcluir.Mask = "000.000.000-00";
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(131, 29);
            this.txtExcluir.TabIndex = 0;
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.Location = new System.Drawing.Point(36, 41);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(52, 24);
            this.lblExcluir.TabIndex = 1;
            this.lblExcluir.Text = "CPF:";
            // 
            // FrmExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 110);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.txtExcluir);
            this.Name = "FrmExcluir";
            this.Text = "FrmExcluir";
            this.Load += new System.EventHandler(this.FrmExcluir_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmExcluir_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtExcluir;
        private System.Windows.Forms.Label lblExcluir;
    }
}