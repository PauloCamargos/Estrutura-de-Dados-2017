/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 July 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Use example
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafo_template
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> grafo = new Graph<string>();

            
            grafo.insertGraphNode("Grupiara");
            grafo.insertGraphNode("Estrela do Sul");
            grafo.insertGraphNode("Romaria");
            grafo.insertGraphNode("Nova Ponte");
            grafo.insertGraphNode("Indianópolis");

            grafo.insertGraphNode("Capinópolis");
            grafo.insertGraphNode("Ituiutaba");
            grafo.insertGraphNode("Centralina");
            grafo.insertGraphNode("Itumbiara");
            grafo.insertGraphNode("Tupaciguara");
            grafo.insertGraphNode("Monte Alegre de Minas");
            grafo.insertGraphNode("Douradinhos");
            grafo.insertGraphNode("Uberlândia");
            grafo.insertGraphNode("Araguari");
            grafo.insertGraphNode("Cascalho Rico");


            //Capinópolis
            grafo.addEdge("Capinópolis", "Centralina", 40);
            grafo.addEdge("Capinópolis", "Ituiutaba", 30);

            //Ituiutaba
            grafo.addEdge("Ituiutaba", "Monte Alegre de Minas", 85);
            grafo.addEdge("Ituiutaba", "Douradinhos", 90);

            //Centralina
            grafo.addEdge("Centralina", "Itumbiara", 20);
            grafo.addEdge("Centralina", "Monte Alegre de Minas", 75);

            //Itumbiara
            grafo.addEdge("Itumbiara", "Tupaciguara", 55);

            //Monte Alegre de Minas
            grafo.addEdge("Monte Alegre de Minas", "Douradinhos", 28);
            grafo.addEdge("Monte Alegre de Minas", "Uberlândia", 60);
            grafo.addEdge("Monte Alegre de Minas", "Tupaciguara", 44);

            //Douradinhos
            grafo.addEdge("Douradinhos", "Uberlândia", 63);
                                   
            //Uberlândia
            grafo.addEdge("Uberlândia", "Araguari", 30);
            grafo.addEdge("Uberlândia", "Romaria", 78);
            grafo.addEdge("Uberlândia", "Indianópolis", 45);
            grafo.addEdge("Uberlândia", "Tupaciguara", 60);
            
            //Araguari
            grafo.addEdge("Araguari", "Cascalho Rico", 28);
            grafo.addEdge("Araguari", "Estrela do Sul", 34);

            //Cascalho Rico
            grafo.addEdge("Cascalho Rico", "Grupiara", 32);

            //Grupiara
            grafo.addEdge("Grupiara", "Estrela do Sul", 38);

            //Estrela do Sul
            grafo.addEdge("Estrela do Sul", "Romaria", 27);

            //Romaria
            grafo.addEdge("Romaria", "Nova Ponte", 28);

            //Nova Ponte
            grafo.addEdge("Nova Ponte", "Indianópolis", 40);

            //grafo.print();
            //Console.ReadKey();

            Console.WriteLine("\n\n");
            //grafo.printConnections();
            //Console.ReadKey();

            grafo.Dijkstra("Ituiutaba", "Romaria");

            //grafo.Dijkstra("Uberlândia", "Estrela do Sul");
            Console.ReadKey();

            
        }
    }
}
