using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafo
{
    class NohListaAdjacente
    {
        private NohListaAdjacente previous;
        private NohListaAdjacente next;
        private Cidade data;

        public NohListaAdjacente(NohListaAdjacente previous, NohListaAdjacente next, Cidade data)
        {
            this.Previous = previous;
            this.Next = next;
            this.Data = data;
        }

        public NohListaAdjacente()
        {
            this.Previous = null;
            this.Next =  null;
            this.Data = null;
        }

        public NohListaAdjacente(Cidade data)
        {
            this.Previous = null;
            this.Next = null;
            this.Data = data;
        }

        internal NohListaAdjacente Previous { get => previous; set => previous = value; }
        internal NohListaAdjacente Next { get => next; set => next = value; }
        internal Cidade Data { get => data; set => data = value; }
    }
}
