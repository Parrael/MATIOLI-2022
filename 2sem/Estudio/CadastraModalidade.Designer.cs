
namespace Estudio
{
    partial class frmCadastraModalidade
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.lblQtdAula = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQtdAluno = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.grpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.txtQtdAula);
            this.grpCadastro.Controls.Add(this.txtQtdAluno);
            this.grpCadastro.Controls.Add(this.txtPreco);
            this.grpCadastro.Controls.Add(this.txtDescricao);
            this.grpCadastro.Controls.Add(this.btnCadastra);
            this.grpCadastro.Controls.Add(this.lblQtdAula);
            this.grpCadastro.Controls.Add(this.lblDescricao);
            this.grpCadastro.Controls.Add(this.lblQtdAluno);
            this.grpCadastro.Controls.Add(this.lblPreco);
            this.grpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastro.Location = new System.Drawing.Point(29, 25);
            this.grpCadastro.Name = "grpCadastro";
            this.grpCadastro.Size = new System.Drawing.Size(410, 234);
            this.grpCadastro.TabIndex = 0;
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
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(114, 34);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(269, 26);
            this.txtDescricao.TabIndex = 5;
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(22, 190);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(361, 28);
            this.btnCadastra.TabIndex = 4;
            this.btnCadastra.Text = "Cadastrar";
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
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
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(18, 73);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preco";
            // 
            // frmCadastraModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 285);
            this.Controls.Add(this.grpCadastro);
            this.Name = "frmCadastraModalidade";
            this.Text = "Cadastrar Modalidade";
            this.Load += new System.EventHandler(this.frmCadastraModalidade_Load);
            this.grpCadastro.ResumeLayout(false);
            this.grpCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastro;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQtdAluno;
        private System.Windows.Forms.Label lblQtdAula;
        private System.Windows.Forms.TextBox txtQtdAula;
        private System.Windows.Forms.TextBox txtQtdAluno;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCadastra;
    }
}