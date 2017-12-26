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
            /*  //= ================================================ TESTE
               ListaGrafo grafo_teste = new ListaGrafo();

               Cidade A = new Cidade("A", 1);
               Cidade B = new Cidade("B", 1);
               Cidade C = new Cidade("C", 1);
               Cidade D = new Cidade("D", 1);
               Cidade E = new Cidade("E", 1);
               Cidade F = new Cidade("F", 1);

               grafo_teste.insereFim(A);
               grafo_teste.insereFim(B);
               grafo_teste.insereFim(C);
               grafo_teste.insereFim(D);
               grafo_teste.insereFim(E);
               grafo_teste.insereFim(F);

               grafo_teste.insereAresta(A, B, 1);
               grafo_teste.insereAresta(B, C, 3);

               grafo_teste.insereAresta(A, C, 10);
               grafo_teste.insereAresta(C, D, 5);

               grafo_teste.insereAresta(A, F, 1);
               grafo_teste.insereAresta(E, F, 5);
               grafo_teste.insereAresta(C, E, 1);
               //grafo_teste.insereAresta(B, D, 1);

               grafo_teste.menorDistanciaEntre(D,F);
              // grafo_teste.menorDistanciaEntre(A,D);
               //            */


            //Criando objetos da classe Cidade
            //Console.WriteLine("Testando o grafo");
            Cidade araguari = new Cidade("Araguari", 1);
            Cidade ituiutaba = new Cidade("Ituiutaba", 1);
            Cidade centralina = new Cidade("Centralina", 1);
            Cidade itumbiara = new Cidade("Itumbiara", 1);
            Cidade capinopolis = new Cidade("Capinópolis", 1);
            Cidade malegreminas = new Cidade("Monte Alegre de Minas", 1);
            Cidade douradinhos = new Cidade("Douradinhos", 1);
            Cidade tupaciguara = new Cidade("Tupaciguara", 1);
            Cidade uberlandia = new Cidade("Uberlândia", 1);
            Cidade indianopolis = new Cidade("Indianópolis", 1);
            Cidade novaPonte = new Cidade("Nova Ponte", 1);
            Cidade romaria = new Cidade("Romaria", 1);
            Cidade estrelaSul = new Cidade("Estrela do Sul", 1);
            Cidade cascalhoRico = new Cidade("Cascalho Rico", 1);
            Cidade grupiara = new Cidade("Grupiara", 1);


            Cidade losAngeles = new Cidade("Los Angeles", 1);


            //grafo que represetna o Grafo
            ListaGrafo grafo = new ListaGrafo();

            //teste
            //grafo.insereFim(losAngeles);

            //Inserindo nós no grafo, representando os objetos criados
            grafo.insereFim(araguari);
            grafo.insereFim(ituiutaba);
            grafo.insereFim(centralina);
            grafo.insereFim(itumbiara);
            grafo.insereFim(capinopolis);
            grafo.insereFim(malegreminas);
            grafo.insereFim(douradinhos);
            grafo.insereFim(tupaciguara);
            grafo.insereFim(uberlandia);
            grafo.insereFim(indianopolis);
            grafo.insereFim(novaPonte);
            grafo.insereFim(romaria);
            grafo.insereFim(estrelaSul);
            grafo.insereFim(grupiara);
            grafo.insereFim(cascalhoRico);

            grafo.insereAresta(capinopolis, centralina, 40);
            grafo.insereAresta(centralina, ituiutaba, 30);
            grafo.insereAresta(ituiutaba, malegreminas, 85);
            grafo.insereAresta(ituiutaba, douradinhos, 90);
            grafo.insereAresta(centralina, itumbiara, 20);
            grafo.insereAresta(centralina, malegreminas, 75);
            grafo.insereAresta(itumbiara, tupaciguara, 55);
            grafo.insereAresta(malegreminas, douradinhos, 28);
            grafo.insereAresta(malegreminas, uberlandia, 60);
            grafo.insereAresta(malegreminas, tupaciguara, 44);
            grafo.insereAresta(douradinhos, uberlandia, 63);
            grafo.insereAresta(uberlandia, araguari, 30);
            grafo.insereAresta(uberlandia, romaria, 78);
            grafo.insereAresta(uberlandia, indianopolis, 45);
            grafo.insereAresta(uberlandia, tupaciguara, 60);
            grafo.insereAresta(araguari, cascalhoRico, 28);
            grafo.insereAresta(araguari, estrelaSul, 34);
            grafo.insereAresta(cascalhoRico, grupiara, 32);
            grafo.insereAresta(grupiara, estrelaSul, 38);
            grafo.insereAresta(estrelaSul, romaria, 27);
            grafo.insereAresta(romaria, novaPonte, 28);
            grafo.insereAresta(novaPonte, indianopolis, 40);
            //grafo.insereAresta(novaPonte, losAngeles, 100);


            //grafo.imprimeDireita();

            // grafo.imprimeGrafo();
            //grafo.quantidadeDeNohs();
            //grafo.menorDistanciaEntre(uberlandia, capinopolis);
            // grafo.menorDistanciaEntre(ituiutaba, indianopolis);

            //grafo.excluiNoh(udi);
            String resp, origem, destino;
            resp = "s";
            Cidade origem_ = new Cidade();
            Cidade destino_ = new Cidade();


            while (resp == "s" || resp == "S")
            {
                Console.WriteLine(" ====================== ALGORITMO DE DIJKSTRA ===========================");
                Console.Write("\nEntre com o nome da origem: ");
                origem = Console.ReadLine();
                Console.Write("Entre com o nome do destino: ");
                destino = Console.ReadLine();
                origem_ = grafo.encontraNomeCidade(origem);
                destino_ = grafo.encontraNomeCidade(destino); Console.WriteLine("");
                grafo.menorDistanciaEntre(origem_, destino_);
                Console.Write("\n ---> Realizar nova consulta (S/N)? ");
                resp = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Programa encerrado!");

            Console.Read();
        }
    }
}
