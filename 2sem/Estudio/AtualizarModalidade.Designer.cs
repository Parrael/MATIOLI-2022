
namespace Estudio
{
    partial class frmAtualizarModalidade
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
            this.grpCadastro = new System.Windows.Forms.GroupBox();
            this.txtQtdAula = new System.Windows.Forms.TextBox();
            this.txtQtdAluno = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.lblQtdAula = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQtdAluno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDescricao = new System.Windows.Forms.ComboBox();
            this.grpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.cbDescricao);
            this.grpCadastro.Controls.Add(this.txtQtdAula);
            this.grpCadastro.Controls.Add(this.txtQtdAluno);
            this.grpCadastro.Controls.Add(this.txtPreco);
            this.grpCadastro.Controls.Add(this.btnAtualiza);
            this.grpCadastro.Controls.Add(this.lblQtdAula);
            this.grpCadastro.Controls.Add(this.lblDescricao);
            this.grpCadastro.Controls.Add(this.lblQtdAluno);
            this.grpCadastro.Controls.Add(this.label1);
            this.grpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastro.Location = new System.Drawing.Point(28, 32);
            this.grpCadastro.Name = "grpCadastro";
            this.grpCadastro.Size = new System.Drawing.Size(404, 228);
            this.grpCadastro.TabIndex = 1;
            this.grpCadastro.TabStop = false;
            this.grpCadastro.Text = "Modalidades";
            // 
            // txtQtdAula
            // 
            this.txtQtdAula.Location = new System.Drawing.Point(105, 155);
            this.txtQtdAula.Name = "txtQtdAula";
            this.txtQtdAula.Size = new System.Drawing.Size(278, 26);
            this.txtQtdAula.TabIndex = 8;
            // 
            // txtQtdAluno
            // 
            this.txtQtdAluno.Location = new System.Drawing.Point(114, 110);
            this.txtQtdAluno.Name = "txtQtdAluno";
            this.txtQtdAluno.Size = new System.Drawing.Size(269, 26);
            this.txtQtdAluno.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(83, 73);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(300, 26);
            this.txtPreco.TabIndex = 6;
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Location = new System.Drawing.Point(22, 187);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(361, 28);
            this.btnAtualiza.TabIndex = 4;
            this.btnAtualiza.Text = "Atualizar";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            // 
            // lblQtdAula
            // 
            this.lblQtdAula.AutoSize = true;
            this.lblQtdAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdAula.Location = new System.Drawing.Point(18, 155);
            this.lblQtdAula.Name = "lblQtdAula";
            this.lblQtdAula.Size = new System.Drawing.Size(71, 20);
            this.lblQtdAula.TabIndex = 3;
            this.lblQtdAula.Text = "Qtd Aula";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(18, 34);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descricao";
            // 
            // lblQtdAluno
            // 
            this.lblQtdAluno.AutoSize = true;
            this.lblQtdAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdAluno.Location = new System.Drawing.Point(18, 113);
            this.lblQtdAluno.Name = "lblQtdAluno";
            this.lblQtdAluno.Size = new System.Drawing.Size(84, 20);
            this.lblQtdAluno.TabIndex = 2;
            this.lblQtdAluno.Text = "Qtd Aluno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preco";
            // 
            // cbDescricao
            // 
            this.cbDescricao.FormattingEnabled = true;
            this.cbDescricao.Location = new System.Drawing.Point(114, 32);
            this.cbDescricao.Name = "cbDescricao";
            this.cbDescricao.Size = new System.Drawing.Size(269, 28);
            this.cbDescricao.TabIndex = 9;
            // 
            // frmAtualizarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 294);
            this.Controls.Add(this.grpCadastro);
            this.Name = "frmAtualizarModalidade";
            this.Text = "AtualizarModalidade";
            this.Load += new System.EventHandler(this.frmAtualizarModalidade_Load);
            this.grpCadastro.ResumeLayout(false);
            this.grpCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastro;
        private System.Windows.Forms.TextBox txtQtdAula;
        private System.Windows.Forms.TextBox txtQtdAluno;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Label lblQtdAula;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblQtdAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDescricao;
    }
}