using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFin
{
    class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Categoria { get; set; }
        public int Status { get; set; }

        private List<Conta> _lstConta = new List<Conta>();

        public Conta()
        {
        }

        public Conta(int id, string nome, string descricao, int categoria,int status)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Categoria = categoria;      
            Status = status;
        }
        public void AddToList(int id, string nome, string descricao, int categoria, int status)
        {
            _lstConta.Add(new Conta(id, nome, descricao, categoria, status));
        }

        public List<Conta> GeraContas()
        {
            Conta _cont1 = new Conta(1, "Salário", "Salário da UNICAMP", 1, 1);
            Conta _cont2 = new Conta(2, "Combustível", "Gasto de combustível", 2, 1);
            _lstConta.Add(_cont1);
            _lstConta.Add(_cont2);
            return _lstConta;
        }
    }
}
