using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha_Invertida
{
    class NohPilha<TAD> : Object // TAD = Tipo Abstrato de Dado
    {
        //Atributos
        private TAD data;
        private NohPilha<TAD> nextNoh;

        //Métodos
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

        public TAD Data { get => data; set => data = value; }
        internal NohPilha<TAD> NextNoh { get => nextNoh; set => nextNoh = value; }
    }
}
