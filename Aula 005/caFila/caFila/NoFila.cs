using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class NoFila
    {
        public int data;
        public NoFila anterior;

        public NoFila(int data, NoFila posição)
        {
            this.Data = data;
            this.anterior = posição;
        }

        public NoFila(int data)
        {
            this.Data = data;
            this.anterior = null;
        }

        public NoFila()
        {
            this.Data = 0;
            this.anterior = null;
        }

        public int Data { get => data; set => data = value; }
        public NoFila Anterior{ get => anterior; set => anterior = value; }

    }
}
