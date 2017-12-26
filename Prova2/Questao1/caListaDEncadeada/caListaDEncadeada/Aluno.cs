using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDEncadeada
{
    class Aluno
    {
        private String nome;
        private int matricula;

        public Aluno(string nome, int matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;
        }

        public Aluno()
        {
            this.Nome = null;
            this.Matricula = 0;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Matricula { get => matricula; set => matricula = value; }
    }
}
