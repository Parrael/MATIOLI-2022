using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class frmCronometro : Form
    {
        DateTime inicio, fim;

        public frmCronometro()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath redondo = new GraphicsPath();
            redondo.AddEllipse(0, 0, 50, 50);
            btnPausar.Region = new Region(redondo);
            btnStart.Region = new Region(redondo);
            btnZerar.Region = new Region(redondo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fim = DateTime.Now;
            TimeSpan dif = fim.Subtract(inicio);
            lblCronometro.Text = dif.ToString("hh\\:mm\\:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        { 
                inicio = DateTime.Now;
                timer1.Start();

        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            
            lblCronometro.Text = "00:00:00";
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
