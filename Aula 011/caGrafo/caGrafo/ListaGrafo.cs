using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafo
{
    class ListaGrafo
    {//Lista encadeada que representa os nos do grafo

        //codigo no site pastbin.com/eMQeMMfz
        NohListaGrafo inicio;
        NohListaGrafo fim;
        int qnt = 0;
        NohListaGrafo Inicio { get => inicio; set => inicio = value; }
        NohListaGrafo Fim { get => fim; set => fim = value; }

        public ListaGrafo()
        {
            inicio = null;
            fim = null;
        }

        public ListaGrafo(NohListaGrafo inicio, NohListaGrafo fim)
        {
            this.Inicio = inicio;
            this.Fim = fim;
        }

        public void insereInicio(Cidade elemento)
        {
            NohListaGrafo novo = new NohListaGrafo(elemento);

            if (inicio == null)
            {
                inicio = novo;
                fim = novo;
            }
            else
            {
                novo.Next = inicio;
                inicio.Previous = novo;
                inicio = novo;
            }
            qnt++;
        }

        public void imprimeDireita()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }
            NohListaGrafo corrente = inicio;
            while (corrente != null)
            {
                if (corrente.Next == null)
                    Console.Write(corrente.Data.Nome);
                else
                    Console.Write(corrente.Data.Nome + " - ");
                corrente = corrente.Next;
            }
            Console.WriteLine();
        }

        public void imprimeEsquerda()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }
            NohListaGrafo corrente = fim;
            while (corrente != null)
            {
                Console.Write(corrente.Data + ", ");
                corrente = corrente.Previous;
            }
            Console.WriteLine();
        }

        public void remove(int n_idx)
        {
            //Removendo primeiramente pele index idx
            NohListaGrafo idx = inicio;
            for (int i = 1; i < n_idx; i++)
            {
                idx = idx.Next;
            }

            if (idx == null)
            {
                return;
            }

            if (idx == inicio)
            {
                inicio = inicio.Next;
                inicio.Previous = null;
                return;
            }

            if (idx == fim)
            {
                fim = fim.Previous;
                fim.Next = null;
                return;
            }

            idx.Previous.Next = idx.Next;
            idx.Next.Previous = idx.Previous;
            idx.Previous = null;
            idx.Next = null;
        }

        public void insereFim(Cidade elemento)
        {
            NohListaGrafo novo = new NohListaGrafo(elemento);
            if (inicio == null)
            {
                inicio = fim = novo;
            }
            else
            {
                fim.Next = novo;
                novo.Previous = fim;
                fim = fim.Next;
            }
            qnt++;
        }

        public int quantidadeDeNohs()
        {
            Console.WriteLine("Esta lista tem " +  qnt + " nós.");
            return this.qnt;
        }

        public NohListaGrafo encontraNoh(Cidade elemento)
        {
            NohListaGrafo temp = inicio;
            while (temp != null)
            {
                if (temp.Data == elemento)
                {
                    return temp;
                }
                else
                {
                    temp = temp.Next;
                }
            }
            return temp;
        }

        //public Cidade EncontraElePPos(int posicao)
        //{
        //    int elemento = 0;
        //    if (posicao <= qnt)
        //    {
        //        NohListaGrafo idx = inicio;
        //        for (int i = 1; i <= posicao; i++)
        //        {
        //            elemento = idx.Data;
        //            idx = idx.Next;
        //        }
        //        Console.WriteLine("Elemento da posicao " + posicao + ": " + elemento);
        //    }
        //    else
        //        Console.WriteLine("Estourou!");
        //    return elemento;
        //}

        //public Cidade contarElementos()
        //{
        //    Console.WriteLine("Quantidade de elementos: " + qnt);
        //    return qnt;
        //}

        //public Cidade SomaElemento()
        //{
        //    Cidade soma = 0;
        //    NohListaGrafo idx = inicio;
        //    while (idx != null)
        //    {
        //        soma += idx.Data;
        //        idx = idx.Next;
        //    }
        //    Console.WriteLine("Soma elementos: " + soma);
        //    return soma;
        //}
    }
}

