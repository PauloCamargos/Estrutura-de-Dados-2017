using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando objetos da classe Cidade
            Console.WriteLine("Testando o grafo");
            Cidade udi = new Cidade("Uberlândia", 700000);
            Cidade uba = new Cidade("Uberaba",35000);
            Cidade ari = new Cidade("Araguari", 70000);

            //Lista que represetna o Grafo
            ListaGrafo lista = new ListaGrafo();

            //Inserindo nós no grafo, representando os objetos criados
            lista.insereFim(udi);
            lista.insereFim(uba);
            lista.insereFim(ari);

            //Inserindo arestas entres os nos com respectiva distancia.
            lista.insereAresta(udi, uba, 110); // insereAresta(cidade_1, cidade_2, distancia);
            lista.insereAresta(udi, ari, 30);

            //lista.imprimeDireita();

            lista.imprimeGrafo();
            lista.quantidadeDeNohs();
            lista.menorDistanciaEntre(udi, ari);
            //lista.excluiNoh(udi);


            //Criando uma aresta entre Uberlandia e Araguari
            // 1) Acessar a lista de adjacencia de Uberlandia (udi)
            //      1.1) Localizar o noh 'udi' no grafo
            //      1.2) Gettar a lista de adjacencia (ListaNohAdj)
            //      1.3) Executar: listaNohAdj.inserefim(ari)
            // 2) Repetir tudo para Araguari

            //NohListaGrafo nohUdi = lista.encontraNoh(udi);
            //(nohUdi.ListaAdj).InsereFim(ari);

            //NohListaGrafo nohAri = lista.encontraNoh(ari);
            //(nohAri.ListaAdj).InsereFim(udi);

            //// Criando uma aresta entre Uberaba e Uberlândia
            //NohListaGrafo nohUdi2 = lista.encontraNoh(udi);
            //(nohUdi2.ListaAdj).InsereFim(uba);

            //NohListaGrafo nohUba = lista.encontraNoh(uba);
            //(nohUba.ListaAdj).InsereFim(udi);

            Console.Read();
        }
    }
}
