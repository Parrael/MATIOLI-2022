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
        private String atualiza;

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
            if (Application.OpenForms.OfType<frmCadastraUsuario>().Count() == 0)
            {
                frmCadastraUsuario frmCadastraUsuario = new frmCadastraUsuario();
                frmCadastraUsuario.MdiParent = this;
                frmCadastraUsuario.Show();
            }
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastraAluno>().Count() == 0)
            {
                frmCadastraAluno frmCadastraAluno = new frmCadastraAluno();
                frmCadastraAluno.MdiParent = this;
                frmCadastraAluno.Show();
            }
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExcluir>().Count() == 0)
            {
                FrmExcluir frmExcluir = new FrmExcluir();
                frmExcluir.MdiParent = this;
                frmExcluir.Show();
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastraModalidade>().Count() == 0)
            {
                frmCadastraModalidade frmCadastraModalidade = new frmCadastraModalidade();
                frmCadastraModalidade.MdiParent = this;
                frmCadastraModalidade.Show();
            }
        }

        public void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAtualizarModalidade>().Count() == 0)
            {
                frmAtualizarModalidade frmAtualizarModalidade = new frmAtualizarModalidade(atualiza = "c");
                frmAtualizarModalidade.MdiParent = this;
                frmAtualizarModalidade.Show();
                
            }
        }

        public void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAtualizarModalidade>().Count() == 0)
            {
                frmAtualizarModalidade frmAtualizarModalidade = new frmAtualizarModalidade(atualiza = "a");
                frmAtualizarModalidade.MdiParent = this;
                frmAtualizarModalidade.Show();
                
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAtualizarModalidade>().Count() == 0)
            {
                frmExcluiModalidade frmExcluiModalidade = new frmExcluiModalidade();
                frmExcluiModalidade.MdiParent = this;
                frmExcluiModalidade.Show();
            }
        }
    }
}
