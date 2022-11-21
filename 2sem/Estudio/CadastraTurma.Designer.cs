namespace Estudio
{
    partial class frmCadastraTurma
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
            this.gpbTurmas = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.dgModalidade = new System.Windows.Forms.DataGridView();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.lblNoAluno = new System.Windows.Forms.Label();
            this.txtNoAluno = new System.Windows.Forms.TextBox();
            this.gpbTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbTurmas
            // 
            this.gpbTurmas.Controls.Add(this.txtNoAluno);
            this.gpbTurmas.Controls.Add(this.lblNoAluno);
            this.gpbTurmas.Controls.Add(this.txtHora);
            this.gpbTurmas.Controls.Add(this.dgModalidade);
            this.gpbTurmas.Controls.Add(this.btnCadastrar);
            this.gpbTurmas.Controls.Add(this.lblHora);
            this.gpbTurmas.Controls.Add(this.txtDiaSemana);
            this.gpbTurmas.Controls.Add(this.lblDia);
            this.gpbTurmas.Controls.Add(this.txtProfessor);
            this.gpbTurmas.Controls.Add(this.lblProfessor);
            this.gpbTurmas.Controls.Add(this.lblModalidade);
            this.gpbTurmas.Controls.Add(this.txtModalidade);
            this.gpbTurmas.Location = new System.Drawing.Point(21, 12);
            this.gpbTurmas.Name = "gpbTurmas";
            this.gpbTurmas.Size = new System.Drawing.Size(502, 492);
            this.gpbTurmas.TabIndex = 0;
            this.gpbTurmas.TabStop = false;
            this.gpbTurmas.Text = "Turmas";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(151, 195);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 26);
            this.txtHora.TabIndex = 10;
            // 
            // dgModalidade
            // 
            this.dgModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modalidade});
            this.dgModalidade.Location = new System.Drawing.Point(29, 312);
            this.dgModalidade.Name = "dgModalidade";
            this.dgModalidade.Size = new System.Drawing.Size(446, 164);
            this.dgModalidade.TabIndex = 9;
            this.dgModalidade.SelectionChanged += new System.EventHandler(this.dgModalidade_SelectionChanged);
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.Name = "modalidade";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(46, 264);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(415, 29);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(97, 198);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(48, 20);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora:";
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaSemana.Location = new System.Drawing.Point(151, 112);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(310, 26);
            this.txtDiaSemana.TabIndex = 5;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(25, 112);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(120, 20);
            this.lblDia.TabIndex = 4;
            this.lblDia.Text = "Dia da semana:";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(151, 66);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(310, 26);
            this.txtProfessor.TabIndex = 3;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(60, 69);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(85, 20);
            this.lblProfessor.TabIndex = 2;
            this.lblProfessor.Text = "Professor: ";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidade.Location = new System.Drawing.Point(50, 25);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(95, 20);
            this.lblModalidade.TabIndex = 1;
            this.lblModalidade.Text = "Modalidade:";
            // 
            // txtModalidade
            // 
            this.txtModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModalidade.Location = new System.Drawing.Point(151, 22);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(310, 26);
            this.txtModalidade.TabIndex = 0;
            // 
            // lblNoAluno
            // 
            this.lblNoAluno.AutoSize = true;
            this.lblNoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAluno.Location = new System.Drawing.Point(37, 156);
            this.lblNoAluno.Name = "lblNoAluno";
            this.lblNoAluno.Size = new System.Drawing.Size(108, 20);
            this.lblNoAluno.TabIndex = 11;
            this.lblNoAluno.Text = "No de Alunos:";
            // 
            // txtNoAluno
            // 
            this.txtNoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoAluno.Location = new System.Drawing.Point(152, 156);
            this.txtNoAluno.Name = "txtNoAluno";
            this.txtNoAluno.Size = new System.Drawing.Size(99, 26);
            this.txtNoAluno.TabIndex = 12;
            // 
            // frmCadastraTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 516);
            this.Controls.Add(this.gpbTurmas);
            this.Name = "frmCadastraTurma";
            this.Text = "Cadastrar Turmas";
            this.Load += new System.EventHandler(this.frmCadastraTurma_Load);
            this.gpbTurmas.ResumeLayout(false);
            this.gpbTurmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModalidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTurmas;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.DataGridView dgModalidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
        private System.Windows.Forms.TextBox txtNoAluno;
        private System.Windows.Forms.Label lblNoAluno;
    }
}