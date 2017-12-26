using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    class Lista
    {
        private No cabeca;
        private No cauda;

        public Lista()
        {
            cabeca = null;
            cauda = null;
        }


        public No Insere(int item)
        {
            //1- criar novo nó
            No novoNo = new No();
            novoNo.info = item;

            //2- verificar se é o primeiro elemento
            if (cabeca == null)
            {
                cabeca = novoNo;
                cauda = novoNo;
            }
            else
            {
                novoNo.proximo = cabeca;
                cabeca.anterior = novoNo;
                cabeca = novoNo;
            }
            return novoNo;
        }

        public void imprimeDireita()
        {
            if (cabeca == null)
            {
                Console.WriteLine("Lista Vazia");
                return;
            }
            No corrente = cabeca;
            while (corrente != null)
            {
                Console.Write(corrente.info + ", ");
                corrente = corrente.proximo;
            }
            Console.WriteLine("");
        }

        public void imprimeEsquerda()
        {
            if (cabeca == null)
            {
                Console.WriteLine("Lista Vazia");
                return;
            }
            No corrente = cauda;
            while (corrente != null)
            {
                Console.Write(corrente.info + ", ");
                corrente = corrente.anterior;
            }
            Console.WriteLine("");
        }

        public void Remove(No idx)
        {
            if (idx == null)
            {
                return;
            }
            if (idx == cabeca)
            {
                cabeca = cabeca.proximo;
                cabeca.anterior = null;
                return;
            }
            if (idx.proximo == null)
            {
                idx.anterior.proximo = null;
                idx.anterior = null;
                return;
            }
            idx.anterior.proximo = idx.proximo;
            idx.proximo.anterior = idx.anterior;
            idx.proximo = null;
            idx.anterior = null;
        }

        public void Busca(int item)
        {
            if (cabeca == null)
            {
                return;
            }
            No aux = cabeca;
            while (aux != null)
            {
                if (aux.info == item)
                {
                    Console.WriteLine("Item " + aux.info + " encontrado");
                }
                aux = aux.proximo;
            }
            //Console.WriteLine("Não encontrado");
        }
    }
}
