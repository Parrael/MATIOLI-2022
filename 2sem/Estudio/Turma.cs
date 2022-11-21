using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{   class Turma
    {
        private String professor, dia_semana, hora;
        private int modalidade;

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }

        public Turma(int modalidade, string professor, string dia_semana, string hora)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
        }

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(string dia_semana, int modalidade)
        {
            this.dia_semana = dia_semana;
            this.modalidade = modalidade;
        }
    }
}
