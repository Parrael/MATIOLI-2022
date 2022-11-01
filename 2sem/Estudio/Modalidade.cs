using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidade
    {
        protected String descricao;
        protected double preco;
        protected int qtdAula;
        protected int qtdAluno;

        protected string Descricao { get => descricao; set => descricao = value; }
        protected double Preco { get => preco; set => preco = value; }
        protected int QtdAula { get => qtdAula; set => qtdAula = value; }
        protected int QtdAluno { get => qtdAluno; set => qtdAluno = value; }

        public Modalidade(string descricao, double preco, int qtdAula, int qtdAluno)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtdAula = qtdAula;
            this.qtdAluno = qtdAluno;
        }

        public Modalidade()
        {
        }

        public Modalidade(string descricao)
        {
            this.descricao = descricao;
        }

        public bool cadastrarModalidade(String descricao, double preco, int qtdAluno, int qtdAula)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand cadastra = new MySqlCommand("insert into Estudio_Modalidade (descricao, preco, qtdAlunos, qtdAulas) values (" + descricao + "','" + preco + "','" + qtdAluno + "','" + qtdAula + ")" + DAO_Conexao.con);
                cadastra.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public MySqlDataReader consultarModalidade()
        {

        }

        public MySqlDataReader consultarTodasModalidade()
        {

        }

        public bool atualizarModalidade()
        {

        }

        public bool excluirModalidade()
        {

        }
    }
}
