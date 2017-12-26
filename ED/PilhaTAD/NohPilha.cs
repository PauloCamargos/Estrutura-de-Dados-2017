using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTemplatePilha
{
    class NohPilha<TAD>: Object //TAD = Tipo Abstrato de Dados //Esta parte é chamada de interface
    {
        //Esta parte daqui pra baixo é chamada de corpo
        // Atributos
        private TAD data;
        private NohPilha<TAD> nextNoh;

        public NohPilha()
        {
            nextNoh = null;
        }

        public NohPilha(TAD valor)
        {
            data = valor;
            nextNoh = null;
        }

        public NohPilha(TAD valor, NohPilha<TAD> nextNoh)
        {
            data = valor;
            nextNoh = null;
        }

        public TAD getData()
        {
            return data;
        }

        public void setData(TAD valor)
        {
            data = valor;
        }

        public NohPilha<TAD> getNext()
        {
            return nextNoh;
        }

        public void setNext(NohPilha<TAD> newNoh)
        {
            nextNoh = newNoh;
        }
    }
}
