using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class NohPilha
    {
        int data;
        NohPilha next; // auto referenciamento


        internal NohPilha Next { get => next; set => next = value; }
        public int Data { get => data; set => data = value; }

        public NohPilha()
        {
            next = null;
        }  

        public NohPilha(int elemento)
        {
            this.Data = elemento;
            next = null;
        }

    }
}
