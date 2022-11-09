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
        
        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(txtDescricao.Text, double.Parse(txtPreco.Text), int.Parse(txtQtdAluno.Text), int.Parse(txtQtdAula.Text) );
            if (modalidade.atualizarModalidade())
                MessageBox.Show("Atualização bem sucedida!");
            else
                MessageBox.Show("Não foi possível atualizar!");
        }

        private void frmAtualizarModalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
