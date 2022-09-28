using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Aluno
    {
        protected String cpf;
        protected String nome;
        protected String rua;
        protected String numero;
        protected String bairro;
        protected String complemento;
        protected String cep;
        protected String cidade;
        protected String estado;
        protected String telefone;
        protected String email;
        protected byte[] foto;
        protected bool Ativo;

        public Aluno(String cpf, String nome, String rua, String numero, String bairro, String complemento, String CEP, String cidade, String estado, String telefone, String email)
        {
            DAO_Conexao.getConexao("143.106.241.3", "cl201286", "cl201286", "cl*08082005");
            setCpf(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
        }

        public Aluno()
        {
        }

        public bool CadastraAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values ('" + cpf + "','" + nome + "','" + rua + "','" + numero + "','" + bairro + "','" + complemento + "','" + cep + "','" + cidade + "','" + estado + "','" + telefone + "','" + email + ")" + DAO_Conexao.con);
                //insere.Parameters.AddWithValue("foto", this.foto);
                insere.ExecuteNonQuery();
                cad = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;

        }

        //Getters e setters
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setRua(string rua)
        {
            this.rua = rua;
        }
        public string getRua()
        {
            return this.rua;
        }
        public void setNumero(string numero)
        {
            this.numero = numero;
        }
        public string getNumero()
        {
            return this.numero;
        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public string getBairro()
        {
            return this.bairro;
        }
        public void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }
        public string getComplemento()
        {
            return this.complemento;
        }
        public void setCep(string cep)
        {
            this.cep = cep;
        }
        public string getCep()
        {
            return this.cep;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public string getCidade()
        {
            return this.cidade;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        public string getEstado()
        {
            return this.estado;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return this.telefone;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }
    }
}
