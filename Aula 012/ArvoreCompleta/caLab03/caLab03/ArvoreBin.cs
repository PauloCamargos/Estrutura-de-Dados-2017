using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab03
{
    class ArvoreBin
    {
        public NohArvoreBin RAIZ;
        public int qnt = 0;


        public ArvoreBin()
        {
            RAIZ = null;
        }

        public ArvoreBin(NohArvoreBin rAIZ)
        {
            RAIZ = rAIZ;
        }

        public bool isEmpty()
        {
            if (RAIZ == null)
                return true;
            else
                return false;
        }

        public void inserir(int n)
        {
            inserir(this.RAIZ, n);
        }

        public void inserir(NohArvoreBin node, int valor)
        {
            if (isEmpty())
            {
                this.RAIZ = new NohArvoreBin(valor);
            }
            else
            {
                if (valor < node.Valor) //insere na sae
                {
                    if (node.NoEsquerda != null)
                    {
                        inserir(node.NoEsquerda, valor);
                    }
                    else // SAE esta vazia
                    {
                        node.NoEsquerda = new NohArvoreBin(valor);
                    }
                } //FIM DO IF DA ESQUERDA
                else if (valor > node.Valor) // insere na sad
                {
                    if (node.NoDireita != null)
                    {
                        inserir(node.NoDireita, valor);
                    }
                    else // SAD esta vazia
                    {
                        node.NoDireita = new NohArvoreBin(valor);
                    }
                } // FIM DO IF DA DIREITA
            } //FIM DO IF NO NÃO VAZIO
        } // FIM DO inserir(NohArvoreBin node, int valor)

        public void imprimirArvore()
        {
            if (this.RAIZ == null)
            {
                Console.WriteLine("ARVORE VAZIA");
            }
            else
            {
                imprimirArvore(this.RAIZ);
            }
        }

        public void imprimirArvore(NohArvoreBin node)
        {
            if (node.NoEsquerda != null)
            {
                imprimirArvore(node.NoEsquerda);
            }
            Console.WriteLine("Noh: " + node.Valor);

            if (node.NoDireita != null)
            {
                imprimirArvore(node.NoDireita);
            }
            // Console.WriteLine("Noh: " + node.valor);
        }

        public NohArvoreBin encontraMin(NohArvoreBin noduloAencontrar)
        {
            if(noduloAencontrar != null)
            {
                while(noduloAencontrar.NoEsquerda != null)
                {
                    noduloAencontrar = noduloAencontrar.NoEsquerda;
                }
            }
            return noduloAencontrar;
        }

        public NohArvoreBin removeMin(NohArvoreBin noAremover) {
            if (noAremover == null)
                return null;
            else
            {
                if (noAremover.NoEsquerda != null)
                {
                    noAremover.NoEsquerda = removeMin(noAremover.NoEsquerda);
                    return noAremover;
                }
                else
                    return noAremover.NoDireita;
            }
        }
        
        /*
        3 cases:
            1) Node with no children
            2) Node with 1 child
            3) Node with 2 children
        */
        public NohArvoreBin remove(int value)
        {
            return remove(RAIZ, value);
        }

        public NohArvoreBin remove(NohArvoreBin noduloARemover, int value)
        {
            //Case 1
            if (noduloARemover == null) {
                return noduloARemover;
                }
            else
            {
                if (noduloARemover.Valor > value)
                    noduloARemover.NoEsquerda = remove(noduloARemover.NoEsquerda, value);
                else if (noduloARemover.Valor < value)
                    noduloARemover.NoDireita = remove(noduloARemover.NoDireita, value);
                else if (noduloARemover.NoDireita != null && noduloARemover.NoEsquerda != null)
                {
                    NohArvoreBin temporario = new NohArvoreBin();
                    //Busca menor nó a direita do nodulo a ser removido
                    temporario = encontraMin(noduloARemover.NoDireita);
                    //Troca os valores
                    noduloARemover.Valor = temporario.Valor;
                    //Removendo o menor nodulo a direita
                    noduloARemover.NoDireita = removeMin(noduloARemover.NoDireita);
                }
                else
                {
                    if (noduloARemover.NoDireita != null)
                        noduloARemover = noduloARemover.NoDireita;
                    else
                        noduloARemover = noduloARemover.NoEsquerda;
                }
            }
            return noduloARemover;
        }

        //public void imprimePreOrdem() { }
        //public void imrprimePosOrdem() { }
        //public int getAltura() { }
        //public int getQntNoh() { }
    }
}
