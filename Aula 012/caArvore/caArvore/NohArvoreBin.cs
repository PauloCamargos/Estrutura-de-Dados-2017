using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvore
{
    class NohArvoreBin
    {
        public int valor;
        NohArvoreBin noEsquerda; //SAE
        NohArvoreBin noDireita; //SAD

        public NohArvoreBin(int valor, NohArvoreBin noEsquerda, NohArvoreBin noDireita)
        {
            this.Valor = valor;
            this.NoEsquerda = noEsquerda;
            this.NoDireita = noDireita;
        }

        public NohArvoreBin()
        {
            this.Valor = 0;
            this.NoEsquerda = null;
            this.NoDireita = null;
        }

        public NohArvoreBin(int n)
        {
            this.Valor = n;
            this.NoEsquerda = null;
            this.NoDireita = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal NohArvoreBin NoEsquerda { get => noEsquerda; set => noEsquerda = value; }
        internal NohArvoreBin NoDireita { get => noDireita; set => noDireita = value; }
    }
}
