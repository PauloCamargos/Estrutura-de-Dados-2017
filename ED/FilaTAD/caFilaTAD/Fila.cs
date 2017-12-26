using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFilaTAD
{
    class Fila<TAD>: Object
    {
        public NoFila<TAD> inicio;
        public NoFila<TAD> fim;

        public Fila(NoFila<TAD> inicio, NoFila<TAD> fim)
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

        public void removeElemento()
        {
            if (this.isEmpty())
            {
                Console.WriteLine("Fila vazia!");
            }
            else
            {
                TAD removido = inicio.Data;
                inicio = inicio.Anterior;
                Console.Write("Removido: ");
                Console.WriteLine(removido);
            }
        }

        public void insereElemento(TAD n)
        {
            NoFila<TAD> novo_no = new NoFila<TAD>(n);
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
                NoFila<TAD> temp = inicio;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Anterior;
                }
            }

        }
    }
}

