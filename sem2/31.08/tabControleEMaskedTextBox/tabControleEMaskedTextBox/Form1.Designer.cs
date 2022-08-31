
namespace tabControleEMaskedTextBox
{
    partial class Exemplo1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpResultados = new System.Windows.Forms.GroupBox();
            this.txtResult3 = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.gpCandidatos = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVotar = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gpResultados.SuspendLayout();
            this.gpCandidatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 605);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.mskData);
            this.tabPage1.Controls.Add(this.txtEvento);
            this.tabPage1.Controls.Add(this.lblData);
            this.tabPage1.Controls.Add(this.lblEvento);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(322, 183);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(253, 303);
            this.listBox2.TabIndex = 5;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 303);
            this.listBox1.TabIndex = 4;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(98, 83);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(220, 20);
            this.mskData.TabIndex = 3;
            this.mskData.ValidatingType = typeof(System.DateTime);
            this.mskData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskData_KeyPress);
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(98, 40);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(221, 20);
            this.txtEvento.TabIndex = 2;
            this.txtEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvento_KeyPress);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(29, 83);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(48, 20);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(29, 38);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(63, 20);
            this.lblEvento.TabIndex = 0;
            this.lblEvento.Text = "Evento:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gpResultados);
            this.tabPage2.Controls.Add(this.gpCandidatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Votação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gpResultados
            // 
            this.gpResultados.Controls.Add(this.txtResult3);
            this.gpResultados.Controls.Add(this.txtResult2);
            this.gpResultados.Controls.Add(this.txtResult1);
            this.gpResultados.Controls.Add(this.lblResult3);
            this.gpResultados.Controls.Add(this.lblResult2);
            this.gpResultados.Controls.Add(this.lblResult1);
            this.gpResultados.Location = new System.Drawing.Point(64, 341);
            this.gpResultados.Name = "gpResultados";
            this.gpResultados.Size = new System.Drawing.Size(487, 214);
            this.gpResultados.TabIndex = 1;
            this.gpResultados.TabStop = false;
            this.gpResultados.Text = "Resultados";
            // 
            // txtResult3
            // 
            this.txtResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult3.Location = new System.Drawing.Point(128, 150);
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.Size = new System.Drawing.Size(243, 26);
            this.txtResult3.TabIndex = 5;
            this.txtResult3.Text = "0";
            // 
            // txtResult2
            // 
            this.txtResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult2.Location = new System.Drawing.Point(128, 91);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(243, 26);
            this.txtResult2.TabIndex = 4;
            this.txtResult2.Text = "0";
            // 
            // txtResult1
            // 
            this.txtResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult1.Location = new System.Drawing.Point(128, 36);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.Size = new System.Drawing.Size(243, 26);
            this.txtResult1.TabIndex = 3;
            this.txtResult1.Text = "0";
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult3.Location = new System.Drawing.Point(27, 152);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(95, 20);
            this.lblResult3.TabIndex = 2;
            this.lblResult3.Text = "Candidato3:";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult2.Location = new System.Drawing.Point(27, 94);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(95, 20);
            this.lblResult2.TabIndex = 1;
            this.lblResult2.Text = "Candidato2:";
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult1.Location = new System.Drawing.Point(27, 39);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(95, 20);
            this.lblResult1.TabIndex = 0;
            this.lblResult1.Text = "Candidato1:";
            // 
            // gpCandidatos
            // 
            this.gpCandidatos.Controls.Add(this.btnLimpar);
            this.gpCandidatos.Controls.Add(this.btnVotar);
            this.gpCandidatos.Controls.Add(this.listBox3);
            this.gpCandidatos.Location = new System.Drawing.Point(66, 44);
            this.gpCandidatos.Name = "gpCandidatos";
            this.gpCandidatos.Size = new System.Drawing.Size(486, 230);
            this.gpCandidatos.TabIndex = 0;
            this.gpCandidatos.TabStop = false;
            this.gpCandidatos.Text = "Candidatos";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(16, 185);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(441, 26);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Zerar Votos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnVotar.Location = new System.Drawing.Point(16, 135);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(441, 33);
            this.btnVotar.TabIndex = 1;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "Candidato 1",
            "Candidato 2",
            "Candidato 3"});
            this.listBox3.Location = new System.Drawing.Point(16, 34);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(442, 84);
            this.listBox3.TabIndex = 0;
            // 
            // Exemplo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 629);
            this.Controls.Add(this.tabControl1);
            this.Name = "Exemplo1";
            this.Text = "Exemplo1";
            this.Load += new System.EventHandler(this.Exemplo1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gpResultados.ResumeLayout(false);
            this.gpResultados.PerformLayout();
            this.gpCandidatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.GroupBox gpResultados;
        private System.Windows.Forms.TextBox txtResult3;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.GroupBox gpCandidatos;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnLimpar;
    }
}

