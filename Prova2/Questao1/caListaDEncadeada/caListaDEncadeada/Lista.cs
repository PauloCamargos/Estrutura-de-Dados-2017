using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDEncadeada
{
    class Lista
    {
        NohLista cabeca;
        NohLista cauda;
        int qnt_elementos = 0;
        internal NohLista Cabeca { get => cabeca; set => cabeca = value; }
        internal NohLista Cauda { get => cauda; set => cauda = value; }
        public int[] listaMatricula = new int[10];

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
        public bool isEmpty()
        {
            if (cabeca == null)
                return true;
            return false;
        }
        public void insereCabeca(Aluno elemento)
        {
            NohLista novo = new NohLista(elemento);

            if (isEmpty())
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
            qnt_elementos++;
        }
        public void imprimirOrdenado()
        {
            int i = 0, j = 0, aux;
            NohLista temp = cabeca;
            int[] listaMatricula = new int[qnt_elementos];

            
            while(temp  != null)
            {
                listaMatricula[i] = temp.Info.Matricula;
                temp = temp.Proximo;
                i++;
            }

            for (i = 0; i < qnt_elementos; i++)
            {
                for (j = i + 1; j < qnt_elementos; j++)
                {
                    if (listaMatricula[i] > listaMatricula[j])
                    {
                        aux = listaMatricula[i];
                        listaMatricula[i] = listaMatricula[j];
                        listaMatricula[j] = aux;
                    }
                }
            }
      
            NohLista temporario;
            for(i = 0; i < qnt_elementos; i++)
            {                
                temporario = encontrarEm(EncontraPosPElem(listaMatricula[i]));
                Console.WriteLine("Matricula: " + temporario.Info.Matricula + " - Nome: " + temporario.Info.Nome);
            }
        }

        //internal void editarDataPosicao(int posicao, int valor)
        //{
        //    NohLista temporario = encontrarEm(posicao);
        //    temporario.Info = valor;              
        //}

        //internal void inserirAposPosicao(int posicao, int valor)
        //{
        //    NohLista novo = new NohLista(valor);
        //    if (posicao > qnt_elementos)
        //        Console.WriteLine("Posição inexistente!");
        //    else
        //    {
        //        NohLista atual = this.encontrarEm(posicao);

        //        if (isEmpty())
        //        {
        //            cabeca = novo;
        //            cauda = novo;
        //        }
        //        else
        //        {
        //            if (atual.Proximo == null) // Caso seja o último nó
        //            {
        //                this.insereCauda(valor);
        //            }
        //            else
        //            {
        //                novo.Proximo = atual.Proximo;
        //                atual.Proximo.Anterior = novo;
        //                novo.Anterior = atual;
        //                atual.Proximo = novo;
        //            }
        //        }
        //    }

        //}

        internal void inserirAntesPosicao(int posicao, Aluno valor)
        {

            NohLista novo = new NohLista(valor);
            if (posicao > qnt_elementos)
                Console.WriteLine("Posição inexistente!");
            else
            {
                NohLista atual = this.encontrarEm(posicao);
                //Console.WriteLine("Chegou aqui!!!!!!!!!!!!!!!!!!!!!!!!!!");

                if (isEmpty())
                {
                    cabeca = novo;
                    cauda = novo;
                }
                else
                {
                    if (atual.Anterior == null) // Caso seja o primeiro nó
                    {
                        this.insereCabeca(valor);
                    }
                    else
                    {
                        novo.Proximo = atual;
                        novo.Anterior = atual.Anterior;
                        atual.Anterior = novo;
                        novo.Anterior.Proximo = novo;
                        //int posicao_anterior = posicao - 1;
                        //this.inserirAposPosicao(valor, posicao_anterior);
                    }
                }
            }

        }

        public void imprimeDireita()
        {
            if (isEmpty())
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }
            NohLista corrente = cabeca;
            while (corrente != null)
            {
                Console.Write(corrente.Info.Matricula + " - " + corrente.Info.Nome + "\n");
                corrente = corrente.Proximo;
            }
            Console.WriteLine();
        }

        public void imprimeEsquerda()
        {
            if (isEmpty())
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

        public void remove(int n_idx)
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
                qnt_elementos--;
                return;
            }

            if (idx == cauda)
            {
                cauda = cauda.Anterior;
                cauda.Proximo = null;
                qnt_elementos--;
                return;
            }

            idx.Anterior.Proximo = idx.Proximo;
            idx.Proximo.Anterior = idx.Anterior;
            idx.Anterior = null;
            idx.Proximo = null;
            qnt_elementos--;

        }

        public void removeMatricula(int matricula)
        {
            //Removendo primeiramente pele index idx
            NohLista temp = cabeca;
            this.remove(EncontraPosPElem(matricula));
        }

        public void insereCauda(Aluno elemento)
        {
            NohLista novo = new NohLista(elemento);
            if (isEmpty())
            {
                cabeca = cauda = novo;
            }
            else
            {
                cauda.Proximo = novo;
                novo.Anterior = cauda;
                cauda = cauda.Proximo;
            }
            qnt_elementos++;
        }

        public int EncontraPosPElem(int matricula)
        {
            int posicao;
            NohLista temp = cabeca;
            int i = 1;
            while (temp != null)
            {
                if (temp.Info.Matricula == matricula)
                {
                    posicao = i;
                    //Console.WriteLine("Posicao do elemento " + elemento + ": " + i);
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

        public NohLista encontrarEm(int posicao)
        {
            if (posicao <= 0)
            {
                Console.WriteLine("Posição inválida. Índices começam em 1.");
                return null;
            }
            else
            {
                if (isEmpty())
                {
                    return null;
                }
                else
                {
                    NohLista temp = cabeca;

                    if (posicao > qnt_elementos)
                        return null;
                    else
                    {
                        for (int i = 1; i < posicao; i++)
                            temp = temp.Proximo;
                        //Console.WriteLine("Elemento da posicao " + posicao + ": " + temp.Info);
                        return temp;
                    }
                }
            }
        }

        //public int EncontraElePPos(int posicao)
        //{
        //    int elemento = 0;
        //    if (posicao <= qnt_elementos)
        //    {
        //        NohLista idx = cabeca;
        //        for (int i = 1; i <= posicao; i++)
        //        {
        //            elemento = idx.Info;
        //            idx = idx.Proximo;
        //        }
        //        Console.WriteLine("Elemento da posicao " + posicao + ": " + elemento);
        //    }
        //    else
        //        Console.WriteLine("Elemento não encontrado ou inexistente!");
        //    return elemento;
        //}

        public int contarElementos()
        {
            //Console.WriteLine("Quantidade de elementos: " + qnt);
            return qnt_elementos;
        }

        //public int SomaElemento()
        //{
        //    int soma = 0;
        //    NohLista idx = cabeca;
        //    while (idx != null)
        //    {
        //        soma += idx.Info;
        //        idx = idx.Proximo;
        //    }
        //    // Console.WriteLine("Soma elementos: " + soma);
        //    return soma;
        //}

    }
}
