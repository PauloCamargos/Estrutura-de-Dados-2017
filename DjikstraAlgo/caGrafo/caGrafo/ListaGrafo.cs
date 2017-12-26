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

        ListaAdj listaPrioridade = new ListaAdj();

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

        public void menorDistanciaEntre(Cidade origem, Cidade destino)
        {
           this.dijkstra(origem, destino);

        }

        private void dijkstra(Cidade origem, Cidade destino)
        {
            //            Criar a lista de prioridade;
            //            Configurar origem S como distancia 0;
            //            Configurar outros nós como distacia infinita;
            //            Inserir todos os nós em uma lista de prioridade P;
            //            |Para cada no V de P não-visitado //Começando em Origem (primeiro nó):
            //            |   | Para cada nó vizinho U de V
            //            |   |     Se distancia no grafo de P(V, U) + distancia acumulada P(S, V) menor que P(S, U)
            //            |   |         Configure a distância de P(S, V) = distancia acumulada P(S, U) +distancia P(U, V)
            //            |   |         Configure o anterior de U = V
            //            |   |     Marque nó V como visitado
            //            |   |     Organiza a lista P pela menor distancia de S a V

            //            Criar a lista de prioridade;

            listaPrioridade.encontraNoh(origem).Peso = 0;
            listaPrioridade.imprimeListaAdj();
            listaPrioridade.ordenarLista();
        }

        internal void imprimeGrafo()
        {
            NohListaGrafo temp = Inicio;
            while(temp != null)
            {
                Console.Write(temp.Data.Nome + " -> " );
                temp.ListaAdj.imprimeListaAdj();
                temp = temp.Next;
            }
        }

        public void insereAresta(Cidade c1, Cidade c2, int distancia)
        {
   
            NohListaGrafo noh_c1 = this.encontraNoh(c1);
            NohListaGrafo noh_c2 = this.encontraNoh(c2);

            if (noh_c1 == null || noh_c2 == null) //Caso um ou outro nao exista
            {
                Console.WriteLine("Locais não encontrados.");
            }
            else
            {
                noh_c1.ListaAdj.InsereFim(c2, distancia);
                noh_c2.ListaAdj.InsereFim(c1, distancia);
            }
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

        public void insereFim(Cidade cidade)
        {
            NohListaGrafo novo = new NohListaGrafo(cidade);
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
            listaPrioridade.InsereFim(cidade, double.PositiveInfinity);
        }

        public int quantidadeDeNohs()
        {
            Console.WriteLine("Esta lista tem " + qnt + " nós.");
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

