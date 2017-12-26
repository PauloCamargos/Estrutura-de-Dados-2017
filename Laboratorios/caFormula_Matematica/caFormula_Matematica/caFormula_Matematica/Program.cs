using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFormula_Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader leitor = System.Console.In;
            TextWriter escritor = System.Console.Out;

            Expressao e = new Expressao();
 
            Console.WriteLine("Digite uma fórmula matemática:");
            String texto = leitor.ReadLine();
            Console.WriteLine(texto);
            e.Elementos = texto.ToCharArray();

            bool resposta = e.verifica();

            Console.WriteLine(resposta);
            Console.Read();
            

        }
    }
}
