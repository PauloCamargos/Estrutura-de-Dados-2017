using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab02
{
    class NoPilha
    {
        private String elemento;
        private NoPilha next;

        public String Elemento { get => elemento; set => elemento = value; }
        internal NoPilha Next { get => next; set => next = value; }

        public NoPilha(String elemento, NoPilha next)
        {
            this.Elemento = elemento;
            this.Next = next;
        }

        public NoPilha(String elemento)
        {
            this.Elemento = elemento;
            this.Next = null;
        }

        public NoPilha()
        {
            Elemento = "";
            this.Next = null;
        }
    }
}
