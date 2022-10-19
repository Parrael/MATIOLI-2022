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
    public partial class FrmExcluir : Form
    {
        public FrmExcluir()
        {
            InitializeComponent();
        }

        private void FrmExcluir_Load(object sender, EventArgs e)
        {

        }

        private void FrmExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtExcluir.Text);
            if(e.KeyChar == 13)
            {
                if (aluno.consultaAluno())
                {
                    if (aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno Excluido");
                    }
                }
            }
        }
    }
}
