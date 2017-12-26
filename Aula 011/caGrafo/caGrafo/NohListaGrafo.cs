using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafo
{
    class NohListaGrafo
    {
        private NohListaGrafo previous;
        private Cidade data;
        private ListaAdj listaAdj;
        private NohListaGrafo next;

        public NohListaGrafo(NohListaGrafo previous, Cidade data, ListaAdj listaAdj, NohListaGrafo next)
        {
            this.Previous = previous;
            this.Data = data;
            this.ListaAdj = listaAdj;
            this.Next = next;
        }

        public NohListaGrafo()
        {
            this.Previous = null;
            this.Data = null;
            this.ListaAdj = null;
            this.Next = null;
        }

        public NohListaGrafo(Cidade data)
        {
            this.Previous = null;
            this.Data = data;
            this.ListaAdj = new ListaAdj();
            this.Next = null;
        }

        public bool ehIgual(NohListaGrafo noh)
        {
            if (this.Data.Equals(noh))
            {
               // Console.WriteLine("Os nós são iguais.");
                return true;
            }
            else
            {
                //Console.WriteLine("Os são diferentes.");
                return false;
            }
        }

        internal NohListaGrafo Previous { get => previous; set => previous = value; }
        internal Cidade Data { get => data; set => data = value; }
        internal ListaAdj ListaAdj { get => listaAdj; set => listaAdj = value; }
        internal NohListaGrafo Next { get => next; set => next = value; }
    }//Fim da classe NohListaGrafo
}//Fim do namespace
