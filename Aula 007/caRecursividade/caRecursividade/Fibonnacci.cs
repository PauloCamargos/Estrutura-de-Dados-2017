using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRecursividade
{
    class Fibonnacci
    {
        public int n;

        public Fibonnacci(int _n)
        {
            this.n = _n;
        }

        public Fibonnacci()
        {
            this.n = 0;
        }

        public int N { get => n; set => n = value; }

        public int calcFibonnacci(int n)
        {
            
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                    return calcFibonnacci(n - 1) + calcFibonnacci(n - 2);
            }
            

        }
    }
}
