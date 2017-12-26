using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafo
{
    class Cidade
    {//Nos da lista do grafo
        private String nome;
        private int habitantes;

        public Cidade()
        {
            this.Nome = "";
            this.Habitantes =0;
        }

        public Cidade(string nome, int habitantes)
        {
            this.Nome = nome;
            this.Habitantes = habitantes;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Habitantes { get => habitantes; set => habitantes = value; }
    }//Fim da classe Cidade
}
