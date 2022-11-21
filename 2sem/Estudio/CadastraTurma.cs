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
            Modalidade modalidade = new Modalidade();
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();
            while (resultado.Read())
            {
                dgModalidade.Rows.Add(resultado["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
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

        }
       /* public void atualizaGrid()
        {
            DAO_Conexao.con.Open();
            //tem um erro aqui e eu não sei onde 
            MySqlCommand busca = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE ativa=0 AND descricao LIKE '" + dgModalidade.SelectedRows.ToString() + "'", DAO_Conexao.con);
            MySqlDataReader resultado = busca.ExecuteReader();
            while (resultado.Read())
            {
                txtModalidade.Text = resultado["descricao"].ToString();
                //claramente tem um erro 
                idModalidade = Convert.ToInt32(resultado["idEstudio"]);
            }
            DAO_Conexao.con.Close();
        }*/
        private void dgModalidade_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void frmCadastraTurma_Load(object sender, EventArgs e)
        {

        }

        private void dgModalidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModalidade.Text = dgModalidade.CurrentCell.Value.ToString();
            Modalidade modalidade = new Modalidade(dgModalidade.CurrentCell.Value.ToString());
            MySqlDataReader resultado = modalidade.consultarModalidade();
            while (resultado.Read())
            {
                idModalidade = int.Parse(resultado["idEstudio"].ToString());
                DAO_Conexao.con.Close();
            }
        }
    }
}
