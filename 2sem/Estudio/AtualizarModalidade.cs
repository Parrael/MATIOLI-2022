using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class frmAtualizarModalidade : Form
    {
        public frmAtualizarModalidade(bool atualiza)
        {
            InitializeComponent();
            if (!atualiza)
            {
                btnAtualiza.Enabled = false;
                txtPreco.Enabled = false;
                txtQtdAluno.Enabled = false;
                txtQtdAula.Enabled = false;
            }
        }

        private void frmAtualizarModalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
