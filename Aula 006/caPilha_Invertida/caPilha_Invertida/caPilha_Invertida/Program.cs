using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha_Invertida
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha<String> p = new Pilha<String>();

            TextReader leitor = System.Console.In;
            TextWriter escritor = System.Console.Out;

            Console.WriteLine("Digite uma frase:");
            String frase = Console.ReadLine();
            
            frase = frase.Replace(" ", "");
            char[] palindromo = frase.ToCharArray();


            Pilha<char> pilha = new Pilha<char>();


            foreach (char i in palindromo)
            {
                pilha.push(i);
                               
            }

            
            
            Pilha<char> invertida = pilha.inverte();
            

            NohPilha<char> aux1 = pilha.Topo;
            NohPilha<char> aux2 = invertida.Topo;

            while (aux1.Data == aux2.Data)
            {
                aux1 = aux1.NextNoh;
                aux2 = aux2.NextNoh;

                if ((aux1.NextNoh == null) && (aux2.NextNoh == null))
                {
                    Console.WriteLine("Frase Palíndroma.");
                    break;
                }
                
            }


            Console.Read();

        }
    }
}
