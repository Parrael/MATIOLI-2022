
namespace Estudio
{
    partial class frmCadastraAluno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.lblComplemento);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.btnCadastrarAluno);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.lblRua);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados cadastrais";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(308, 278);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(361, 26);
            this.txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(249, 276);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(107, 273);
            this.txtTelefone.Mask = "(__)_____-____";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 26);
            this.txtTelefone.TabIndex = 20;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(518, 227);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(151, 26);
            this.txtEstado.TabIndex = 19;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(446, 229);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(296, 226);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(135, 26);
            this.txtCidade.TabIndex = 17;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(226, 227);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(107, 226);
            this.txtCep.Mask = "__.___-___";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 26);
            this.txtCep.TabIndex = 15;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(564, 180);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(105, 26);
            this.txtComplemento.TabIndex = 14;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(446, 183);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 20);
            this.lblComplemento.TabIndex = 13;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(107, 180);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(324, 26);
            this.txtBairro.TabIndex = 12;
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.Location = new System.Drawing.Point(583, 133);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(86, 26);
            this.txtNo.TabIndex = 11;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(548, 136);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(30, 20);
            this.lblNo.TabIndex = 10;
            this.lblNo.Text = "Nº:";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(107, 133);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(420, 26);
            this.txtRua.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(107, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(420, 26);
            this.txtNome.TabIndex = 8;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(107, 41);
            this.txtCpf.Mask = "___.___.___-__";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(125, 26);
            this.txtCpf.TabIndex = 7;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(97, 321);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(539, 37);
            this.btnCadastrarAluno.TabIndex = 6;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(6, 274);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(79, 20);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(29, 227);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(49, 20);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "CEP: ";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(26, 183);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 20);
            this.lblBairro.TabIndex = 3;
            this.lblBairro.Text = "Bairro: ";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(40, 133);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(43, 20);
            this.lblRua.TabIndex = 2;
            this.lblRua.Text = "Rua:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(29, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome: ";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(40, 41);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(48, 20);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF: ";
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picImagem.Location = new System.Drawing.Point(750, 34);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(177, 252);
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            // 
            // btnEscolher
            // 
            this.btnEscolher.Location = new System.Drawing.Point(772, 302);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(133, 34);
            this.btnEscolher.TabIndex = 2;
            this.btnEscolher.Text = "Escolher Foto";
            this.btnEscolher.UseVisualStyleBackColor = true;
            // 
            // frmCadastraAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 435);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastraAluno";
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.frmCadastraAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnEscolher;
    }
}