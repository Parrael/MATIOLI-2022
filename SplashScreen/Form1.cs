using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            Thread thread = new Thread(new ThreadStart(splashScreen));
            thread.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            thread.Abort();
        }

        private void splashScreen()
        {
            Application.Run(new frmSplashScreen());
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
