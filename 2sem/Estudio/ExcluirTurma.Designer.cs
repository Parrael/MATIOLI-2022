namespace Estudio
{
    partial class frmExcluirTurma
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
            this.gpTurmas = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.gpTurmas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTurmas
            // 
            this.gpTurmas.Controls.Add(this.btnExcluir);
            this.gpTurmas.Controls.Add(this.cbHora);
            this.gpTurmas.Controls.Add(this.cbDias);
            this.gpTurmas.Controls.Add(this.cbModalidade);
            this.gpTurmas.Controls.Add(this.lblHora);
            this.gpTurmas.Controls.Add(this.lblDias);
            this.gpTurmas.Controls.Add(this.lblModalidade);
            this.gpTurmas.Location = new System.Drawing.Point(22, 21);
            this.gpTurmas.Name = "gpTurmas";
            this.gpTurmas.Size = new System.Drawing.Size(505, 235);
            this.gpTurmas.TabIndex = 0;
            this.gpTurmas.TabStop = false;
            this.gpTurmas.Text = "Turmas";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(49, 184);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(406, 30);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cbHora
            // 
            this.cbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Location = new System.Drawing.Point(169, 127);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(107, 28);
            this.cbHora.TabIndex = 5;
            // 
            // cbDias
            // 
            this.cbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(169, 85);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(275, 28);
            this.cbDias.TabIndex = 4;
            this.cbDias.SelectedIndexChanged += new System.EventHandler(this.cbDias_SelectedIndexChanged);
            // 
            // cbModalidade
            // 
            this.cbModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Location = new System.Drawing.Point(169, 41);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(275, 28);
            this.cbModalidade.TabIndex = 3;
            this.cbModalidade.SelectedIndexChanged += new System.EventHandler(this.cbModalidade_SelectedIndexChanged_1);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(109, 130);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(48, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(26, 88);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(131, 20);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Dias da Semana:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidade.Location = new System.Drawing.Point(62, 44);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(95, 20);
            this.lblModalidade.TabIndex = 0;
            this.lblModalidade.Text = "Modalidade:";
            // 
            // frmExcluirTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(553, 268);
            this.Controls.Add(this.gpTurmas);
            this.Name = "frmExcluirTurma";
            this.Text = "Excluir Turma";
            this.Load += new System.EventHandler(this.frmExcluirTurma_Load);
            this.gpTurmas.ResumeLayout(false);
            this.gpTurmas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTurmas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.ComboBox cbModalidade;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblModalidade;
    }
}