using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{   class Turma
    {
        private String professor, dia_semana, hora, alunosMatriculados;
        private int modalidade;

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
        public string AlunosMatriculados { get => alunosMatriculados; set => alunosMatriculados = value; }

        public Turma(int modalidade, string professor, string dia_semana, string hora, string alunosMatriculados)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
            this.alunosMatriculados = alunosMatriculados;
        }

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(int modalidade, String dia_semana, String hora)
        {
            this.modalidade = modalidade;
            this.dia_semana = dia_semana;
            this.hora = hora;
        }

        public Turma(string dia_semana, int modalidade)
        {
            this.dia_semana = dia_semana;
            this.modalidade = modalidade;
        }

        public bool cadastrarTurma()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand cadastra = new MySqlCommand("INSERT INTO Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma, ativa) VALUES ('" + modalidade + "','" + professor + "','" + dia_semana + "','" + hora + "','" + alunosMatriculados + "','" + 0 + "')", DAO_Conexao.con);
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

        public bool excluirTurma()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("UPDATE Estudio_Turma SET ativa=1 WHERE idModalidade LIKE '" + modalidade + "'AND diasemanaTurma LIKE '" + dia_semana + "'AND horaTurmac LIKE'" + hora + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public MySqlDataReader consultaTodasTurma()
        {
            MySqlDataReader buscar = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand busca = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE ativa=0", DAO_Conexao.con);
                buscar = busca.ExecuteReader();
                return buscar;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                /*DAO_Conexao.con.Close();*/
            }
        }

        public MySqlDataReader consultaTurma()
        {
            //pelo idModalidade
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE ativa=0 AND idModalidade LIKE '" + modalidade + "'", DAO_Conexao.con);
                MySqlDataReader resultado = buscar.ExecuteReader();
                return resultado;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                /*DAO_Conexao.con.Close();*/
            }
        }
    }
}
