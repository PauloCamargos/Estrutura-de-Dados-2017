using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraQuestao
{
    class NoPilha
    {
        char data;
        NoPilha next; // auto referenciamento


        internal NoPilha Next { get => next; set => next = value; }
        public char Data { get => data; set => data = value; }

        public NoPilha()
        {
            next = null;
        }

        public NoPilha(char elemento)
        {
            this.Data = elemento;
            next = null;
        }

    }
}
