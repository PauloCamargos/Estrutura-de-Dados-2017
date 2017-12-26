﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class Pilha
    {
        NohPilha topo;
        public int qnt_elementos;

        public Pilha()
        {
            topo = null;
            qnt_elementos = 0;
        }

        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }// FIM DO MÉTODO isEmpty()

        public void push(int n)
        {
            if (this.isEmpty())
            {
                NohPilha novo = new NohPilha(n);
                topo = novo;
            }
            else
            {
                NohPilha novo = new NohPilha(n);
                novo.Next = topo;
                topo = novo;
            }
            qnt_elementos++;
        }//FIM DO MÉTODO push

        public int pop()
        {
            int desempilhado = 999999999;
            if (this.isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
            }
            else
            {
                desempilhado = topo.Data;
                topo = topo.Next;
                Console.WriteLine("Desempilhado: " + desempilhado);
            }
            qnt_elementos--;
            return desempilhado;
        }//FIM DO MÉTODO  pop()

        public void print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia!!");
            }else
            {
                NohPilha temp = topo;
                while(temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }
        }

    }
}
