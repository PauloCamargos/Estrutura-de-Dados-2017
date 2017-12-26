using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFilaTAD
{
    class NoFila<TAD>: Object
    {
        public TAD data;
        public NoFila<TAD> anterior;

        public NoFila(TAD data, NoFila<TAD> posição)
        {
            this.Data = data;
            this.anterior = posição;
        }

        public NoFila(TAD data)
        {
            this.Data = data;
            this.anterior = null;
        }

        public TAD Data { get => data; set => data = value; }
        public NoFila<TAD> Anterior { get => anterior; set => anterior = value; }

    }
}

