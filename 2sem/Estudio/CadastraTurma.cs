using MySql.Data.MySqlClient;
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
    public partial class frmCadastraTurma: Form
    {
        int idModalidade;
        public frmCadastraTurma()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int modalidade = Convert.ToInt32(txtModalidade.Text);
            String professor = txtProfessor.Text;
            String dia_semana = txtDiaSemana.Text;
            String hora = txtHora.Text;
            String alunosMatriculados = txtNoAluno.Text;
            Turma turma = new Turma(modalidade, professor, dia_semana, hora, alunosMatriculados);
            if (turma.cadastrarTurma())
                MessageBox.Show("Cadastro realizado com sucesso!");
            else
                MessageBox.Show("Falha no cadastro!");

            cbDesejado.Refresh();
            txtDiaSemana.Text = "";
            txtHora.Text = "";
            txtModalidade.Text = "";
            txtNoAluno.Text = "";
            txtProfessor.Text = "";

            Modalidade modalidade1 = new Modalidade();
            MySqlDataReader resultado4 = modalidade1.consultarTodasModalidade();
            while (resultado4.Read())
            {
                cbDesejado.Items.Add(resultado4["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void cbDesejado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int desejado = 0;
            Modalidade modalidade = new Modalidade(cbDesejado.Text);
            MySqlDataReader resultado = modalidade.consultarModalidade();
            if (resultado.Read())
            {
                desejado = Convert.ToInt32(resultado["idEstudio"]);
            }
            DAO_Conexao.con.Close();

            txtModalidade.Text = desejado.ToString();

        }

        private void frmCadastraTurma_Load(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade();
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();
            while (resultado.Read())
            {
                cbDesejado.Items.Add(resultado["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
            txtModalidade.Enabled = false;
        }
    }
}
