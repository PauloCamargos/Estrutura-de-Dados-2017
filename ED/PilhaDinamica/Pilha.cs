using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class Pilha
    {
        NohPilha topo;
	public int qnt_elementos = 0;

        public Pilha()
        {
            topo = null;
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
                novo.Next = topo;
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
            return desempilhado;
	qnt_elementos--;
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


        public Pilha reverteElementos()
        {
            Pilha p_revertida = new Pilha();
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia!!");
            }
            else
            {
                NoPilha temp = topo;
                
                while (temp != null)
                {
                    p_revertida.push(temp.Data);
                    temp = temp.Next;
                }
            }
            return p_revertida;
        }

        public bool isEqual(Pilha p)
        {
            NoPilha temp1 = topo;
            NoPilha temp2 = p.topo;
            bool estado = true;
            while(temp1 != null || temp2 != null)
            {
                if (temp1.Data != temp2.Data)
                {
                    estado = false;
                    break;
                }
                temp1 = temp1.Next;
                temp2 = temp2.Next;
            }
            return estado;
        }

    }
}
