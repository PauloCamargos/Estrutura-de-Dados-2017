using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDEncadeada
{
    class NohLista
    {
        private NohLista anterior;
        private int info;
        private NohLista proximo;

        public NohLista(NohLista anterior, int info, NohLista proximo)
        {
            this.anterior = anterior;
            this.info = info;
            this.proximo = proximo;
        }

        public NohLista(int elemento)
        {
            this.info = elemento;
            this.anterior = null;
            this.proximo = null;
        }

        public NohLista()
        {
            this.anterior = null;
            this.proximo = null;
            this.info = 0;
        }

        
        public int Info { get => info; set => info = value; }
        internal NohLista Anterior { get => anterior; set => anterior = value; }
        internal NohLista Proximo { get => proximo; set => proximo = value; }
    }
}
