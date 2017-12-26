using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    class No
    {
        public int info { get; set; }
        public No proximo { get; set; }
        public No anterior { get; set; }

        public No()
        {
            info = 0;
            proximo = null;
            anterior = null;
        }
    }
}
