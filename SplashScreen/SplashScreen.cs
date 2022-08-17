using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //incremento de 1 em 1 da barra de progresso
            progressBar1.Increment(1);

            //quando a barra estiver completa
            if (progressBar1.Value == 100)
            {
                timer.Stop();
            }
        }
    }
}
