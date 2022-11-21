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
    public partial class frmExcluirTurma : Form
    {
            int idModalidade = 0;
        public frmExcluirTurma()
        {
            InitializeComponent();
            Modalidade modalidade = new Modalidade();
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();
            while (resultado.Read())
            {
                cbModalidade.Items.Add(resultado["descricao"].ToString());
                idModalidade = Convert.ToInt32(resultado["idEstudio"]);
            }
            DAO_Conexao.con.Close();

        }

        private void frmExcluirTurma_Load(object sender, EventArgs e)
        {

        }

        private void cbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void cbModalidade_SelectedIndexChanged_1(object sender, EventArgs e)
        { 
            Turma turma = new Turma(idModalidade);
            MySqlDataReader resultado2 = turma.consultaTurma();
            while (resultado2.Read())
            {
                cbDias.Items.Add(Convert.ToInt32(resultado2["diasemanaTurma"]));
                cbHora.Items.Add(Convert.ToInt32(resultado2["horaTurma"]));
            }
            DAO_Conexao.con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int modalidade =  Convert.ToInt32(cbModalidade.Text);
            String dia_semana = cbDias.Text;
            String hora = cbHora.Text;
            Turma turma = new Turma(modalidade, dia_semana, hora);
            if (turma.excluirTurma())
                MessageBox.Show("Exclusão concluída com sucesso!");
            else
                MessageBox.Show("Falha na exclusão!");


            cbModalidade.Items.Clear();
            cbDias.Items.Clear();
            cbHora.Items.Clear();
            Modalidade modalidade2 = new Modalidade();
            MySqlDataReader resultado3 = modalidade2.consultarTodasModalidade();
            while (resultado3.Read())
            {
                cbModalidade.Items.Add(resultado3["descricao"].ToString());
                idModalidade = Convert.ToInt32(resultado3["idEstudio"]);
            }
            DAO_Conexao.con.Close();
        }
    }
}
