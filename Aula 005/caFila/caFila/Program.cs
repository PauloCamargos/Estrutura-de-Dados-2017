using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila f = new Fila();

            for(int i = 0; i < 6; i++)
            {
                f.insereElemento(i);
            }

            f.removeElemento();
            f.removeElemento();

            f.printFila();
            Console.Read();
        }
    }
}
