
namespace Estudio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbValidacao = new System.Windows.Forms.GroupBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTurmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gpbValidacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.modalidadeToolStripMenuItem,
            this.turmaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.cadastrarLoginToolStripMenuItem,
            this.excluirAlunoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // cadastrarLoginToolStripMenuItem
            // 
            this.cadastrarLoginToolStripMenuItem.Name = "cadastrarLoginToolStripMenuItem";
            this.cadastrarLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarLoginToolStripMenuItem.Text = "Cadastrar Login";
            this.cadastrarLoginToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLoginToolStripMenuItem_Click);
            // 
            // excluirAlunoToolStripMenuItem
            // 
            this.excluirAlunoToolStripMenuItem.Name = "excluirAlunoToolStripMenuItem";
            this.excluirAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirAlunoToolStripMenuItem.Text = "Excluir Aluno";
            this.excluirAlunoToolStripMenuItem.Click += new System.EventHandler(this.excluirAlunoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // modalidadeToolStripMenuItem
            // 
            this.modalidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.modalidadeToolStripMenuItem.Name = "modalidadeToolStripMenuItem";
            this.modalidadeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.modalidadeToolStripMenuItem.Text = "Modalidade";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // gpbValidacao
            // 
            this.gpbValidacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbValidacao.Controls.Add(this.btnLogar);
            this.gpbValidacao.Controls.Add(this.txtSenha);
            this.gpbValidacao.Controls.Add(this.txtLogin);
            this.gpbValidacao.Controls.Add(this.lblLogin);
            this.gpbValidacao.Controls.Add(this.lblSenha);
            this.gpbValidacao.Location = new System.Drawing.Point(140, 100);
            this.gpbValidacao.Name = "gpbValidacao";
            this.gpbValidacao.Size = new System.Drawing.Size(483, 259);
            this.gpbValidacao.TabIndex = 2;
            this.gpbValidacao.TabStop = false;
            this.gpbValidacao.Text = "Validação";
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogar.Location = new System.Drawing.Point(63, 185);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(348, 54);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(144, 130);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(167, 29);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "12345";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(145, 72);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(166, 29);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.Text = "catarina";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogin.Location = new System.Drawing.Point(46, 61);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(80, 31);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenha.Location = new System.Drawing.Point(46, 120);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(92, 31);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTurmToolStripMenuItem,
            this.excluirTuraToolStripMenuItem});
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // cadastrarTurmToolStripMenuItem
            // 
            this.cadastrarTurmToolStripMenuItem.Name = "cadastrarTurmToolStripMenuItem";
            this.cadastrarTurmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarTurmToolStripMenuItem.Text = "Cadastrar Turma";
            this.cadastrarTurmToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTurmToolStripMenuItem_Click);
            // 
            // excluirTuraToolStripMenuItem
            // 
            this.excluirTuraToolStripMenuItem.Name = "excluirTuraToolStripMenuItem";
            this.excluirTuraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirTuraToolStripMenuItem.Text = "Excluir Turma";
            this.excluirTuraToolStripMenuItem.Click += new System.EventHandler(this.excluirTuraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbValidacao);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Estudio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbValidacao.ResumeLayout(false);
            this.gpbValidacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbValidacao;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTurmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTuraToolStripMenuItem;
    }
}

