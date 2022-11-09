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

        public bool cadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand cadastra = new MySqlCommand("INSERT INTO Estudio_Modalidade (descricao, preco, qtdAlunos, qtdAulas, ativa) VALUES ('" + descricao + "','" + preco + "','" + qtdAluno + "','" + qtdAula +"','"+ 0 +"')" + DAO_Conexao.con);
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
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand busca = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE descricao LIKE '" + descricao + "'", DAO_Conexao.con);
                MySqlDataReader buscar = busca.ExecuteReader();
                return buscar;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }

        public MySqlDataReader consultarTodasModalidade()
        {
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand busca = new MySqlCommand("SELECT * FROM Estudio_Modalidade");
                MySqlDataReader buscar = busca.ExecuteReader();
                return buscar;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

        }

        public bool atualizarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("UPDATE INTO Estudio_Modalidade (descricao, preco, qtdAlunos, qtdAulas) VALUES ('" + descricao + "','" + preco + "','" + qtdAluno + "','" + qtdAula + "')" + DAO_Conexao.con);
                //deve ter erro nessa linha de SQL
                atualiza.ExecuteNonQuery();
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

        public bool excluirModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("UPDATE ativa=1 INTO Estudio_Modalidade WHERE descricao LIKE '"+ descricao + "'" + DAO_Conexao.con);
                //deve ter erro nessa linha de SQL
                exclui.ExecuteNonQuery();
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
    }
}
