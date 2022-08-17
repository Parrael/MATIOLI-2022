
namespace Semaforo
{
    partial class frmSemaforo
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
            this.components = new System.ComponentModel.Container();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlRed.Location = new System.Drawing.Point(162, 57);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(200, 100);
            this.pnlRed.TabIndex = 0;
            // 
            // pnlYellow
            // 
            this.pnlYellow.BackColor = System.Drawing.Color.Orange;
            this.pnlYellow.Location = new System.Drawing.Point(162, 204);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(200, 100);
            this.pnlYellow.TabIndex = 1;
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.Green;
            this.pnlGreen.Location = new System.Drawing.Point(162, 338);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(200, 100);
            this.pnlGreen.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSemaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGreen);
            this.Controls.Add(this.pnlYellow);
            this.Controls.Add(this.pnlRed);
            this.Name = "frmSemaforo";
            this.Text = "Semaforo";
            this.Activated += new System.EventHandler(this.frmSemaforo_Activated);
            this.Load += new System.EventHandler(this.frmSemaforo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Timer timer1;
    }
}

