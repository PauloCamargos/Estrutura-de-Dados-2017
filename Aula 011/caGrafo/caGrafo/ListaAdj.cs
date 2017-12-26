using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafo
{
    class ListaAdj
    {
        private NohListaAdjacente INICIO;
        private NohListaAdjacente FIM;

        public ListaAdj(NohListaAdjacente iNICIO, NohListaAdjacente fIM)
        {
            INICIO = iNICIO;
            FIM = fIM;
        }

        public ListaAdj()
        {
            INICIO = FIM = null;
        }

        public void InsereFim(Cidade elemento)
        {
            NohListaAdjacente novo = new NohListaAdjacente(elemento);
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
    }
}//fim da classe ListaAdj
