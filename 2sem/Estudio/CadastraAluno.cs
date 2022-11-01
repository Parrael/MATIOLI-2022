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
    public partial class frmCadastraAluno : Form
    {
        public frmCadastraAluno()
        {
            InitializeComponent();
        }

        private void frmCadastraAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCpf.Text, txtNome.Text, txtRua.Text, txtNo.Text, txtBairro.Text, txtComplemento.Text, txtCep.Text, txtCidade.Text, txtEstado.Text, txtTelefone.Text, txtEmail.Text);
            if (aluno.CadastraAluno())
                MessageBox.Show("Cadastro realizado com sucesso!");
            else
                MessageBox.Show("Erro de Cadastro!");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCpf.Text);
            if(e.KeyChar == 13)
            {
                if (aluno.consultaAluno())
                {
                    MessageBox.Show("Aluno já cadastrado");
                }
                else
                {
                    txtNome.Focus();
                }
            }
        }
    }
}
