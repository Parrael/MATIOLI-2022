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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201286", "cl201286", "cl*08082005"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(txtLogin.Text, txtSenha.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                gpbValidacao.Visible = false;
                menuStrip1.Enabled = true;
                //menuStrip1.Enabled = true;
            }
            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito");
                gpbValidacao.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;
            }
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraUsuario frmCadastraUsuario = new frmCadastraUsuario();
            frmCadastraUsuario.MdiParent = this;
            frmCadastraUsuario.Show();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraAluno frmCadastraAluno = new frmCadastraAluno();
            frmCadastraAluno.MdiParent = this;
            frmCadastraAluno.Show();
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcluir frmExcluir = new FrmExcluir();
            frmExcluir.MdiParent = this;
            frmExcluir.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraModalidade frmCadastraModalidade = new frmCadastraModalidade();
            frmCadastraModalidade.MdiParent = this;
            frmCadastraModalidade.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtualizarModalidade frmAtualizarModalidade = new frmAtualizarModalidade();
            frmAtualizarModalidade.MdiParent = this;
            frmAtualizarModalidade.Show();

        }
    }
}
