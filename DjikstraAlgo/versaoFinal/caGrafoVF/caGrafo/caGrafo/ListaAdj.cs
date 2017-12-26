using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafo
{
    class ListaAdj
    {
        private NohListaAdjacente Inicio;
        private NohListaAdjacente Fim;
        public int qnt = 0;
        internal NohListaAdjacente INICIO { get => Inicio; set => Inicio = value; }
        internal NohListaAdjacente FIM { get => Fim; set => Fim = value; }

        public ListaAdj(NohListaAdjacente iNICIO, NohListaAdjacente fIM)
        {
            INICIO = iNICIO;
            FIM = fIM;
        }

        public ListaAdj()
        {
            INICIO = FIM = null;
        }


        public void insereInicio(Cidade elemento, double peso)
        {
            NohListaAdjacente novo = new NohListaAdjacente(elemento);
            novo.Peso = peso;
            if (Inicio == null)
            {
                INICIO = novo;
                FIM = novo;
            }
            else
            {
                novo.Next = INICIO;
                INICIO.Previous = novo;
                INICIO = novo;
            }
            qnt++;
        }

        public void InsereFim(Cidade elemento, double distancia)
        {
            qnt++;
            NohListaAdjacente novo = new NohListaAdjacente(elemento);
            novo.Peso = distancia;
            if (INICIO == null)
            {
                INICIO = FIM = novo;
            }
            else
            {
                FIM.Next = novo;
                novo.Previous = FIM;
                FIM = FIM.Next;
            }
        }

        public void imprimeListaAdj()
        {
            NohListaAdjacente temp = INICIO;
            while (temp != null)
            {
                if (temp.Next != null)
                    Console.Write(temp.Data.Nome + " (" + temp.Peso + " Km)" + " - ");
                else
                    Console.Write(temp.Data.Nome + " (" + temp.Peso + " Km)");
                temp = temp.Next;
            }
            Console.WriteLine();

        }

        public void imprimeTrajeto()
        {
            NohListaAdjacente temp_incio = Inicio, temp_fim = Fim;

            Console.WriteLine("Com " + temp_fim.Peso + " Km de extensão, o menor trajeto de " + temp_incio.Data.Nome + " a " + temp_fim.Data.Nome + " é: ");
            while (temp_incio != null)
            {
                if (temp_incio.Next == null) Console.WriteLine(temp_incio.Data.Nome + " (" + temp_incio.Peso + " Km)");
                else
                {
                    if (temp_incio.Peso == 0)
                        Console.Write(temp_incio.Data.Nome + " (Origem) --> ");
                    else
                        Console.Write(temp_incio.Data.Nome + " (" + temp_incio.Peso + " Km) --> ");
                }
                temp_incio = temp_incio.Next;
            }
        }

        public void imprimeEsquerda()
        {
            if (INICIO == null)
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }
            NohListaAdjacente corrente = FIM;
            while (corrente.caminhoDijkstra != null)
            {
                Console.WriteLine(corrente.Data.Nome + "(" + corrente.distanciaDikstra + "," + corrente.caminhoDijkstra.nome + "-> ");
                //Console.WriteLine();
                corrente = encontraNoh(corrente.caminhoDijkstra);
            }
            if (corrente.caminhoDijkstra == null)
            {
                Console.WriteLine(corrente.Data.Nome + "(" + corrente.distanciaDikstra + ",NULO)");
            }
            Console.WriteLine();
        }

        public NohListaAdjacente encontraNoh(Cidade elemento)
        {
            NohListaAdjacente temp = Inicio;
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

        public void ordenarLista()
        {
            NohListaAdjacente temp = this.Inicio;  // Variavel temporario do loop de fora
            NohListaAdjacente temp_2 = this.Inicio; // Variavel temporario do loop de dentro
            Cidade aux_data;
            Double aux_distDijkstra;
            Cidade aux_caminhoDijkstra;
            Boolean naoEstaOrdenada = true;
            bool flag = true;

            while (naoEstaOrdenada)
            {
                while (temp_2 != null && flag && naoEstaOrdenada)
                {
                    aux_data = temp_2.Data;
                    aux_distDijkstra = temp_2.distanciaDikstra;
                    aux_caminhoDijkstra = temp_2.caminhoDijkstra;

                    if (temp_2 == null || temp_2.Next == null)
                    {
                        naoEstaOrdenada = false;
                        flag = false;
                        break;
                    }

                    if (temp_2.Next.distanciaDikstra < temp_2.distanciaDikstra)
                    {

                        //Troca os nós de lugar
                        temp_2.Data = temp_2.Next.Data;
                        temp_2.distanciaDikstra = temp_2.Next.distanciaDikstra;
                        temp_2.caminhoDijkstra = temp_2.Next.caminhoDijkstra;

                        temp_2.Next.Data = aux_data;
                        temp_2.Next.distanciaDikstra = aux_distDijkstra;
                        temp_2.Next.caminhoDijkstra = aux_caminhoDijkstra;
                        temp_2 = this.INICIO;
                    }
                    else
                        temp_2 = temp_2.Next;
                    //Verfica se a lista está ordenada
                    while (temp.Next != null)
                    {
                        if (temp.Next.distanciaDikstra < temp.distanciaDikstra)
                        {
                            naoEstaOrdenada = true;
                            break;
                        }
                        else
                        {
                            naoEstaOrdenada = false;
                            temp = temp.Next;
                        }
                    }
                    temp = this.INICIO; ;
                }
            }
        }

        public void imprimeListaDjikstra()
        {
            NohListaAdjacente temp = INICIO;
            while (temp != null)
            {
                // A(0, NULL) -> C(4, D)
                if (temp.caminhoDijkstra == null)
                {
                    Console.Write(temp.Data.Nome + "(" + temp.distanciaDikstra + ", nulo) -> ");// + temp.caminhoDijkstra.+ ") -> ");
                }
                else
                {
                    Console.Write(temp.Data.Nome + "(" + temp.distanciaDikstra + ", " + temp.caminhoDijkstra.nome + ") -> ");
                }
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public NohListaAdjacente encontrarEm(int posicao)
        {
            if (posicao <= 0)
            {
                Console.WriteLine("Posição inválida. Índices começam em 1.");
                return null;
            }
            else
            {
                if (this.Inicio == null)
                {
                    return null;
                }
                else
                {
                    NohListaAdjacente temp = Inicio;

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
}//fim da classe ListaAdj
