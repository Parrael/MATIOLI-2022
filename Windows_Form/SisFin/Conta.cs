using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFin
{
    class Conta
    {
        private string nome;
        private int id;
        private int status;
        private string descricao;
        private string categoria;
        private List<Conta> _lstConta = new List<Conta>();

        public Conta()
        {
        }

        public Conta(string nome, int id, int status, string descricao, string categoria)
        {
            this.nome = nome;
            this.id = id;
            this.status = status;
            this.descricao = descricao;
            this.categoria = categoria;
            
        }

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        internal List<Conta> LstConta { get => _lstConta; set => _lstConta = value; }

        public List<Conta> GeraConta()
        {
            Conta _cat1 = new Conta("Mika",1,1,"Aluna do Cotil","Combustivel");
            Conta _cat2 = new Conta("Grazi", 2, 2, "Aluna do Cotil", "Combustivel");
            _lstConta.Add(_cat1);
            _lstConta.Add(_cat2);
            return _lstConta;
        }
    }

}
