using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFilaTAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila<int> f = new Fila<int>();

            for (int i = 0; i < 6; i++)
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
