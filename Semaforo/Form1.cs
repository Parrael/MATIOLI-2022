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

namespace Semaforo
{
    public partial class frmSemaforo : Form
    {
        int tempo = 0;
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath t = new GraphicsPath();
            t.AddEllipse(0, 0, 50, 50);
            pnlGreen.Region = new Region(t);
            pnlRed.Region = new Region(t);
            pnlYellow.Region = new Region(t);

        }
        public frmSemaforo()
        {
            InitializeComponent();
        }

        private void frmSemaforo_Load(object sender, EventArgs e)
        {

        }

        private void frmSemaforo_Activated(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo++;
                if(tempo <= 10)
            {
                pnlGreen.BackColor = Color.Black;
                pnlRed.BackColor = Color.Red;
                pnlYellow.BackColor = Color.Black; 
            }
                else if ((tempo < 15) && (tempo > 10))
            {
                pnlGreen.BackColor = Color.Green;
                pnlRed.BackColor = Color.Black;
                pnlYellow.BackColor = Color.Black;
            } 
                else if ((tempo < 17) && (tempo >= 15))
            {
                pnlGreen.BackColor = Color.Black;
                pnlRed.BackColor = Color.Black;
                pnlYellow.BackColor = Color.Yellow;
            }
        }
    }
}
