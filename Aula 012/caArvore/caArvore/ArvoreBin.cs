using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvore
{
    class ArvoreBin
    {
        public NohArvoreBin RAIZ;


        public ArvoreBin()
        {
            RAIZ = null;
        }

        public ArvoreBin(NohArvoreBin rAIZ)
        {
            RAIZ = rAIZ;
        }

        public bool isEmpty(){
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
            if(isEmpty())
            {
                this.RAIZ = new NohArvoreBin(valor);
            }
            else
            {
                if(valor < node.Valor) //insere na sae
                {
                    if(node.NoEsquerda != null) 
                    {
                        inserir(node.NoEsquerda, valor);
                    }
                    else // SAE esta vazia
                    {
                        node.NoEsquerda = new NohArvoreBin(valor);
                    }
                } //FIM DO IF DA ESQUERDA
                else if(valor > node.Valor) // insere na sad
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
            if(this.RAIZ == null)
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
            if(node.NoEsquerda != null)
            {
                imprimirArvore(node.NoEsquerda);
            }
            Console.WriteLine("Noh: " + node.valor);

            if(node.NoDireita != null)
            {
                imprimirArvore(node.NoDireita);
            }
           // Console.WriteLine("Noh: " + node.valor);
        }

        public int remove() { }
        //public void imprimePreOrdem() { }
        //public void imrprimePosOrdem() { }
        //public int getAltura() { }
        //public int getQntNoh() { }
    }
}
