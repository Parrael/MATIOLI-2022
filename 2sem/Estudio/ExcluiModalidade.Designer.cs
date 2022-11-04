
namespace Estudio
{
    partial class frmExcluiModalidade
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
            this.grpModalidade = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpModalidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModalidade
            // 
            this.grpModalidade.Controls.Add(this.btnExcluir);
            this.grpModalidade.Controls.Add(this.lblDescricao);
            this.grpModalidade.Controls.Add(this.comboBox1);
            this.grpModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModalidade.Location = new System.Drawing.Point(22, 22);
            this.grpModalidade.Name = "grpModalidade";
            this.grpModalidade.Size = new System.Drawing.Size(378, 140);
            this.grpModalidade.TabIndex = 0;
            this.grpModalidade.TabStop = false;
            this.grpModalidade.Text = "Modalidades";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(27, 90);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(316, 29);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 38);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descricao";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // frmExcluiModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 183);
            this.Controls.Add(this.grpModalidade);
            this.Name = "frmExcluiModalidade";
            this.Text = "Excluir Modalidade";
            this.grpModalidade.ResumeLayout(false);
            this.grpModalidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModalidade;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnExcluir;
    }
}