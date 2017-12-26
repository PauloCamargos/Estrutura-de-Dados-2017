using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Expressao expressao = new Expressao();
            //expressao.setExpressao();
            //expressao.expressao = "{2+[3*-2+(4-(5-3))]-6}*2";
            //expressao.expressao = "{{}()()[]}";
            //expressao.expressao = "{{}()()[]}";
            expressao.setExpressao();
            expressao.getExpressao();
            //expressao.empilharExpressao();
            expressao.testarExpressao();
            Console.Read();
        }
    }
}
