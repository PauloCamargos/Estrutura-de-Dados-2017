using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPilha1
{
    class Pilha
    {
        private int[] a = new int[5];
        private int topo;

        public Pilha()
        {
            this.topo = -1;
        }

        public bool isEmpty()
        {
            if (topo == -1)
                return true;
            else
                return false;

        }

        public void push(int elemento)
        {
            if (this.isEmpty())
            {
                topo = 0;
                a[topo] = elemento;
            }
            else
            {
                if (topo > 4)
                {
                    Console.WriteLine("Pilha Cheia!");
                }
                else
                {
                    topo++;
                    a[topo] = elemento;
                    Console.WriteLine("Empilhado:" + a[topo]);
                }
            }
        }

        public int pop()
        {
            int desempilhado = -999999999;
            if (this.isEmpty())
            {
                Console.WriteLine("Pilha Vazia!");
            }
            else
            {
                desempilhado = a[topo];
                topo--;
                Console.WriteLine("Desempilhado: " + desempilhado);
            }

            return desempilhado;
        }

        public void print()
        {
            int temp = topo;
            Console.WriteLine("Sua pilha: ");
            while (temp > -1)
            {
                Console.WriteLine(a[temp]);
                temp--;
            }
        }


    }
}
