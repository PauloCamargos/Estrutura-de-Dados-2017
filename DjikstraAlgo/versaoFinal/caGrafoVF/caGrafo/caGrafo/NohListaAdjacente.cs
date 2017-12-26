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
        private double peso;

        public double distanciaDikstra = double.PositiveInfinity;
        public bool foiVisitado = false;
        public Cidade caminhoDijkstra ;

        public NohListaAdjacente(NohListaAdjacente previous, NohListaAdjacente next, Cidade data, int peso)
        {
            this.Previous = previous;
            this.Next = next;
            this.Data = data;
            this.Peso = peso;
        }

        public NohListaAdjacente()
        {

            this.Previous = null;
            this.Next = null;
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
        //internal int Peso { get => Peso1; set => Peso1 = value; }
        internal double Peso { get => peso; set => peso = value; }
    }
}
