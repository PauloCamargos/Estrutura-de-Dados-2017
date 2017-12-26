using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafo
{
    class ListaAdj
    {
        private NohListaAdjacente Inicio;
        private NohListaAdjacente Fim;

        internal NohListaAdjacente INICIO { get => Inicio; set => Inicio = value; }
        internal NohListaAdjacente FIM { get => Fim; set => Fim = value; }

        public ListaAdj(NohListaAdjacente iNICIO, NohListaAdjacente fIM)
        {
            INICIO = iNICIO;
            FIM = fIM;
        }

        public ListaAdj()
        {
            INICIO = FIM = null;
        }

        public void InsereFim(Cidade elemento, double distancia)
        {

            NohListaAdjacente novo = new NohListaAdjacente(elemento);
            novo.Peso = distancia;
            if (INICIO == null)
            {
                INICIO = FIM = novo;
            }
            else
            {
                FIM.Next = novo;
                novo.Previous = FIM;
                FIM = FIM.Next;
            }
        }

        internal void imprimeListaAdj()
        {
            NohListaAdjacente temp = INICIO;
            while (temp != null)
            {
                if (temp.Next != null)
                    Console.Write(temp.Data.Nome + " (" + temp.Peso + " Km)" + " - ");
                else
                    Console.Write(temp.Data.Nome + " (" + temp.Peso + " Km)");
                temp = temp.Next;
            }
            Console.WriteLine();

        }
        

        public NohListaAdjacente encontraNoh(Cidade elemento)
        {
            NohListaAdjacente temp = Inicio;
            while (temp != null)
            {
                if (temp.Data == elemento)
                {
                    return temp;
                }
                else
                {
                    temp = temp.Next;
                }
            }
            return temp;
        }

        internal void ordenarLista()
        {
            NohListaAdjacente temp = this.Inicio;
            NohListaAdjacente noh_aux;
            while(temp.Next.Peso < temp.Peso)
            {
                noh_aux = temp;
                temp = temp.Next;
                temp.Next = noh_aux;

            }

        }
    }
}//fim da classe ListaAdj
