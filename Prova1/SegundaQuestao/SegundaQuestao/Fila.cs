using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaQuestao
{
    class Fila
    {
        public NoFila inicio;
        public NoFila fim;
        public NoFila fura;

        public Fila(NoFila inicio, NoFila fim)
        {
            this.inicio = inicio;
            this.fim = fim;
        }

        public Fila()
        {
            this.inicio = null;
            this.fim = null;
        }

        public bool isEmpty()
        {
            if (inicio == null && fim == null)
                return true;
            else
                return false;
        }

        public int removeElemento()
        {
            if (this.isEmpty())
            {
                Console.WriteLine("Fila vazia!");
                return -404;
            }
            else
            {
                int removido = inicio.Data;
                inicio = inicio.Anterior;
                Console.Write("Removido: ");
                Console.WriteLine(removido);
                return removido;
            }
        }

        public void insereElemento(int n)
        {
            NoFila novo_no = new NoFila(n);
            if (this.isEmpty())
            {
                inicio = novo_no;
                fim = novo_no;
            }
            else
            {
                fim.Anterior = novo_no;
                fim = novo_no;
            }
        }

        public void printFila()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila vazia!");
            }
            else
            {
                NoFila temp = inicio;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Anterior;
                }
            }
        }

        public void furaFila(int n)
        {
            Console.WriteLine("Entre com o elemento: ");
            int ele = Convert.ToInt32(Console.Read());
            NoFila novo = new NoFila(ele);
            NoFila ele_ant = inicio;
            NoFila ele_post = inicio;
            NoFila temp;
            for(int i = 0; i < n-1; i++)
            {
                ele_ant = ele_ant.anterior;
                temp = ele_ant.anterior;
                ele_ant.anterior = novo;
                novo = temp;
            }

        }
    }
}
