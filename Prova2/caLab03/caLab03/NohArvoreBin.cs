using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab03
{
    class NohArvoreBin: Object
    {
        private int valor;
        NohArvoreBin noEsquerda; //SAE
        NohArvoreBin noDireita; //SAD

        public int Valor { get => valor; set => valor = value; }
        internal NohArvoreBin NoEsquerda { get => noEsquerda; set => noEsquerda = value; }
        internal NohArvoreBin NoDireita { get => noDireita; set => noDireita = value; }

        public NohArvoreBin(int valor, NohArvoreBin _noEsquerda, NohArvoreBin _noDireita)
        {
            this.Valor = valor;
            this.NoEsquerda = _noEsquerda;
            this.NoDireita = _noDireita;
        }

        public NohArvoreBin()
        {   
            this.NoEsquerda = null;
            this.NoDireita = null;
        }

        public NohArvoreBin(int n)
        {
            this.Valor = n;
            this.NoEsquerda = null;
            this.NoDireita = null;
        }

    }
}