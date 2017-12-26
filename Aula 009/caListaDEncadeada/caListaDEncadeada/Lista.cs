using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDEncadeada
{
    class Lista
    {
        //codigo no site pastbin.com/eMQeMMfz
        NohLista cabeca;
        NohLista cauda;
        int qnt = 0;
        internal NohLista Cabeca { get => cabeca; set => cabeca = value; }
        internal NohLista Cauda { get => cauda; set => cauda = value; }

        public Lista()
        {
            cabeca = null;
            cauda = null;
        }

        public Lista(NohLista cabeca, NohLista cauda)
        {
            this.Cabeca = cabeca;
            this.Cauda = cauda;
        }

        public void insereCabeca(int elemento)
        {
            NohLista novo = new NohLista(elemento);

            if (cabeca == null)
            {
                cabeca = novo;
                cauda = novo;
            }
            else
            {
                novo.Proximo = cabeca;
                cabeca.Anterior = novo;
                cabeca = novo;
            }
            qnt++;
        }

        internal void editarPosicao(int v)
        {
            throw new NotImplementedException();
        }

        internal void inserirNaPosicao(int v)
        {
            throw new NotImplementedException();
        }

        public void imprimeDireita()
        {
            if (cabeca == null)
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }
            NohLista corrente = cabeca;
            while (corrente != null)
            {
                Console.Write(corrente.Info + ", ");
                corrente = corrente.Proximo;
            }
            Console.WriteLine();
        }

        public void imprimeEsquerda()
        {
            if (cabeca == null)
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }
            NohLista corrente = cauda;
            while (corrente != null)
            {
                Console.Write(corrente.Info + ", ");
                corrente = corrente.Anterior;
            }
            Console.WriteLine();
        }

        public void Remove(int n_idx)
        {
            //Removendo primeiramente pele index idx
            NohLista idx = cabeca;
            for (int i = 1; i < n_idx; i++)
            {
                idx = idx.Proximo;
            }

            if (idx == null)
            {
                return;
            }

            if (idx == cabeca)
            {
                cabeca = cabeca.Proximo;
                cabeca.Anterior = null;
                return;
            }

            if (idx == cauda)
            {
                cauda = cauda.Anterior;
                cauda.Proximo = null;
                return;
            }

            idx.Anterior.Proximo = idx.Proximo;
            idx.Proximo.Anterior = idx.Anterior;
            idx.Anterior = null;
            idx.Proximo = null;
        }

        public void InsereCauda(int elemento)
        {
            NohLista novo = new NohLista(elemento);
            if (cabeca == null)
            {
                cabeca = cauda = novo;
            }
            else
            {
                cauda.Proximo = novo;
                novo.Anterior = cauda;
                cauda = cauda.Proximo;
            }
            qnt++;
        }

        public int EncontraPosPElem(int elemento)
        {
            int posicao;
            NohLista temp = cabeca;
            int i = 1;
            while (temp != null)
            {
                if (temp.Info == elemento)
                {
                    posicao = i+1;
                    Console.WriteLine("Posicao do elemento " + elemento + ": " + i);
                    return posicao;
                }
                else
                {
                    temp = temp.Proximo;
                    i++;
                }
            }
            return i;
        }

        public int EncontraElePPos(int posicao)
        {
            int elemento = 0;
            if (posicao <= qnt)
            {
                NohLista idx = cabeca;
                for (int i = 1; i <= posicao; i++)
                {
                    elemento = idx.Info;
                    idx = idx.Proximo;
                }
                Console.WriteLine("Elemento da posicao " + posicao + ": " + elemento);
            }
            else
                Console.WriteLine("Estourou!");
            return elemento;
        }

        public int contarElementos()
        {
            Console.WriteLine("Quantidade de elementos: " + qnt);
            return qnt;
        }

        public int SomaElemento()
        {
            int soma = 0;
            NohLista idx = cabeca;
            while(idx != null)
            {
                soma += idx.Info;
                idx = idx.Proximo;
            }
            Console.WriteLine("Soma elementos: " + soma);
            return soma;
        }

    }
}
