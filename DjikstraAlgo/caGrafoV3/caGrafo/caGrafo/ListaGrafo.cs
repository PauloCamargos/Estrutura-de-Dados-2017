﻿using System;
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
        ListaAdj listaPrioridade_temp = new ListaAdj();

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

        public Cidade encontraNomeCidade(String nome_cidade)
        {
            Cidade cidade = null;
            NohListaGrafo temp = inicio;
            if (temp == null)
                return null;
            else
            {
                while (temp != null)
                {
                    if (temp.Data.Nome == nome_cidade)
                    {
                        cidade = temp.Data;
                    }
                    else
                        temp = temp.Next;
                }
                return cidade;
            }

        }

        public void menorDistanciaEntre(Cidade origem_, Cidade destino_)
        //public void menorDistanciaEntre(String origem, String destino)
        {
            //Cidade origem_ = new Cidade();
            //origem_ = this.encontraNomeCidade(origem);
            //Cidade destino_ = new Cidade();
            //destino_ = this.encontraNomeCidade(destino);


            dijkstra(origem_, destino_);
           //  listaPrioridade.imprimeListaDjikstra();

            NohListaAdjacente temp = listaPrioridade_temp.encontraNoh(destino_);
            ListaAdj trajeto = new ListaAdj();
            while (temp != null)
            {
                //Console.WriteLine(temp.Data.nome + " => ");
                trajeto.insereInicio(temp.Data, temp.distanciaDikstra);
                temp = listaPrioridade_temp.encontraNoh(temp.caminhoDijkstra);
            }

            trajeto.imprimeTrajeto();

            //ListaAdj menorCaminho = dijkstra(origem, destino);
            //ListaAdj trajeto = new ListaAdj();
            //if (menorCaminho.INICIO == null)
            //{
            //    Console.WriteLine("Lista Vazia!");
            //    return;
            //}
            //else
            //{
            //    NohListaAdjacente corrente = menorCaminho.FIM;
            //    while (corrente != null)
            //    {
            //        //Console.WriteLine(corrente.Data.Nome + "(" + corrente.distanciaDikstra + "," + corrente.caminhoDijkstra.nome + "-> ");
            //        //Console.WriteLine();
            //        trajeto.insereInicio(corrente.Data, corrente.distanciaDikstra);
            //        corrente = menorCaminho.encontraNoh(corrente.caminhoDijkstra);
            //    }
            //    NohListaAdjacente temp = trajeto.INICIO;
            //    Console.WriteLine("O menor possui " + trajeto.FIM.Peso + " Km e o trajeto é: ");
            //    while (temp != null)
            //    {
            //        Console.Write(temp.Data.Nome + "-> ");
            //        temp = temp.Next;

            //    }               
            //    Console.WriteLine();
            //}
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

            listaPrioridade_temp = listaPrioridade;

            NohListaAdjacente aux = new NohListaAdjacente();
            NohListaAdjacente aux_lp = new NohListaAdjacente();
            NohListaAdjacente novaOrigem_lp = new NohListaAdjacente();
            Cidade novaOrigem = origem;
            int i = 1;

            if (encontraNoh(origem) == null || encontraNoh(destino) == null)
            {
                Console.WriteLine("Nós não encontrados");
                return;
            }
            else
            {
                listaPrioridade_temp.encontraNoh(origem).distanciaDikstra = 0;
                listaPrioridade_temp.ordenarLista();
                Console.WriteLine("Estou Ordenado!");
                listaPrioridade_temp.imprimeListaDjikstra();
                //NohListaAdjacente noh_LA = this.encontraNoh(origem).ListaAdj.INICIO;
                //NohListaAdjacente noh_LP = listaPrioridade.encontraNoh(noh_LA.Data);
                //NohListaAdjacente noh_novaOrigem = listaPrioridade.encontraNoh(origem);
                //NohListaAdjacente destino_LP = listaPrioridade.encontraNoh(destino); 

                while (listaPrioridade_temp.encontraNoh(destino).distanciaDikstra == double.PositiveInfinity && !listaPrioridade_temp.encontraNoh(novaOrigem).foiVisitado)
                // while (!listaPrioridade.encontraNoh(destino).foiVisitado)
                {
                    listaPrioridade_temp.ordenarLista();
                    // listaPrioridade.imprimeListaDjikstra();
                    //this.encontraNoh(novaOrigem).ListaAdj.ordenarLista();
                    aux = this.encontraNoh(novaOrigem).ListaAdj.INICIO;
                    novaOrigem_lp = listaPrioridade_temp.encontraNoh(novaOrigem);
                    while (aux != null)
                    {
                        //Console.WriteLine("-------------------------------- ");
                        listaPrioridade_temp.imprimeListaDjikstra();

                        aux_lp = listaPrioridade_temp.encontraNoh(aux.Data);
                        if (aux_lp.distanciaDikstra > novaOrigem_lp.distanciaDikstra + aux.Peso && !aux_lp.foiVisitado)
                        {
                            aux_lp.distanciaDikstra = novaOrigem_lp.distanciaDikstra + aux.Peso;
                            aux_lp.caminhoDijkstra = listaPrioridade_temp.encontraNoh(novaOrigem).Data;

                            //aux_lp.caminhoDijkstra.Nome = listaPrioridade.encontraNoh(novaOrigem).Data.Nome;
                            //Console.WriteLine("nome :" + aux_lp.caminhoDijkstra.Nome);
                            //aux_lp.Data.NomeDikstra = listaPrioridade.encontraNoh(novaOrigem).Data.Nome;

                        }
                        aux = aux.Next;
                        listaPrioridade_temp.ordenarLista();
                    }
                    listaPrioridade_temp.ordenarLista();
                    listaPrioridade_temp.encontraNoh(novaOrigem).foiVisitado = true;
                    i++;
                    novaOrigem = listaPrioridade_temp.encontrarEm(i).Data;
                }
            }
            // listaPrioridade;
        }

        public void imprimeGrafo()
        {
            NohListaGrafo temp = Inicio;
            while (temp != null)
            {
                Console.Write(temp.Data.Nome + " -> ");
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

        public NohListaGrafo encontrarEm(int posicao)
        {
            if (posicao <= 0)
            {
                Console.WriteLine("Posição inválida. Índices começam em 1.");
                return null;
            }
            else
            {
                if (this.inicio == null)
                {
                    return null;
                }
                else
                {
                    NohListaGrafo temp = inicio;

                    if (posicao > qnt)
                        return null;
                    else
                    {
                        for (int i = 1; i < posicao; i++)
                            temp = temp.Next;
                        //Console.WriteLine("Elemento da posicao " + posicao + ": " + temp.Info);
                        return temp;
                    }
                }
            }
        }// Fim encontraEm( int posicao )
    }
}

