using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTemplatePilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha<int> pilhaInteiros = new Pilha<int>();
            Pilha<String> pilhaStrings = new Pilha<String>();

            pilhaInteiros.push(2);
            pilhaInteiros.push(3);
            pilhaInteiros.push(4);
            pilhaInteiros.push(5);

            pilhaStrings.push("Baleia");
            pilhaStrings.push("Cavalo");
            pilhaStrings.push("Gato");
            pilhaStrings.push("Cachorro");

            pilhaStrings.print();
            pilhaInteiros.print();

            Console.Read();
        }
    }
}
