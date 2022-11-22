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
            
        public frmExcluirTurma()
        {
            InitializeComponent();
            

        }     

        private void cbModalidade_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbDias.Items.Clear();

            int modalidade2=0;
            Modalidade modalidade = new Modalidade(cbModalidade.Text);
            MySqlDataReader resultado = modalidade.consultarModalidade();
            if (resultado.Read())
            {
                modalidade2 = Convert.ToInt32(resultado["idEstudio"]);
            }
            DAO_Conexao.con.Close();
            Turma turma = new Turma(modalidade2);
            MySqlDataReader resultado2 = turma.consultaTurma();
            if (resultado2.Read())
            {
                cbDias.Items.Add((resultado2["diasemanaTurma"]).ToString());
            } 
            DAO_Conexao.con.Close();

            cbDias.Refresh();

        }

        public void consultaId()
        {
            int modalidade2 = 0;
            Modalidade modalidade = new Modalidade(cbModalidade.Text);
            MySqlDataReader resultado = modalidade.consultarModalidade();
            while (resultado.Read())
            {
                modalidade2 = Convert.ToInt32((resultado["idEstudio"]));
            }
            DAO_Conexao.con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int modalidade3 = 0;

            Modalidade modalidade2 = new Modalidade(cbModalidade.Text);
            MySqlDataReader resultado3 = modalidade2.consultarModalidade();
            if (resultado3.Read())
            {
                modalidade3 = Convert.ToInt32(resultado3["idEstudio"]);
            }
            DAO_Conexao.con.Close();


            String dia_semana = cbDias.Text;
            String hora = cbHora.Text;

            Turma turma = new Turma(modalidade3, dia_semana, hora);
            if (turma.excluirTurma())
                MessageBox.Show("Exclusão concluída com sucesso!");
            else
                MessageBox.Show("Falha na exclusão!");


            cbModalidade.Items.Clear();
            cbDias.Items.Clear();
            cbHora.Items.Clear();

            cbModalidade.Refresh();
            cbHora.Refresh();
            cbDias.Refresh();
        }

        private void cbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHora.Items.Clear();
            String diaSemana= "";
            int modalidade2 = 0;
            Modalidade modalidade = new Modalidade(cbModalidade.Text);
            MySqlDataReader resultado = modalidade.consultarModalidade();
            if (resultado.Read())
            {
                modalidade2 = Convert.ToInt32(resultado["idEstudio"]);
            }
            DAO_Conexao.con.Close();

            diaSemana = cbDias.Text;

            Turma turma1 = new Turma(diaSemana, modalidade2);
            MySqlDataReader resultado3 = turma1.consultaTurmaDia();
            while (resultado3.Read())
            {
                cbHora.Items.Add((resultado3["horaTurma"]).ToString());
            }
            DAO_Conexao.con.Close();

        }

        private void frmExcluirTurma_Load(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade();
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();
            while (resultado.Read())
            {
                cbModalidade.Items.Add(resultado["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        
           
        }
    }
}
