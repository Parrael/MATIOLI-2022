using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFin
{
     public class Categoria
    {
        public int Id {get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public int Status { get; set; }

        private List<Categoria> _1sCategoria = new List<Categoria>();


        public Categoria()
        {

        }

        public Categoria (int id, string nome, string descricao, int tipo, int status)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Tipo = tipo;
            Status = status;
        }

        public void AddTolist(int id, string nome, string descricao, int tipo, int status)
        {
            _1sCategoria.Add(new Categoria(id, nome, descricao, tipo, status));

        }

        


        public List<Categoria> Tolist()
        {
            return _1sCategoria;
        }

        public List<Categoria> GeraCategorias()
        {
            Categoria _cat1 = new Categoria(1, "Salario", "Salario Unicamp", 1, 1);
            Categoria _cat2 = new Categoria(1, "Conbustivel", "Despesas com combustivel", 2, 2);
            _1sCategoria.Add(_cat1);
            _1sCategoria.Add(_cat2);
            return _1sCategoria;

        }



    }
}
