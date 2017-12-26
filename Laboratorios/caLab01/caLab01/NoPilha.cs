using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab01
{
    class NoPilha
    {
        private int elemento;
        private NoPilha next;

        public int Elemento { get => elemento; set => elemento = value; }
        internal NoPilha Next { get => next; set => next = value; }

        public NoPilha(int elemento, NoPilha next)
        {
            this.Elemento = elemento;
            this.Next = next;
        }

        public NoPilha(int elemento)
        {
            this.Elemento = elemento;
            this.Next = null;
        }

        public NoPilha()
        {
            this.Elemento = -1;
            this.Next = null;
        }


    }
}
