using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRecursividade
{
    class NoPilha
    {
        int data;
        NoPilha next; // auto referenciamento


        internal NoPilha Next { get => next; set => next = value; }
        public int Data { get => data; set => data = value; }

        public NoPilha()
        {
            next = null;
        }

        public NoPilha(int elemento)
        {
            this.Data = elemento;
            next = null;
        }
    }
}
