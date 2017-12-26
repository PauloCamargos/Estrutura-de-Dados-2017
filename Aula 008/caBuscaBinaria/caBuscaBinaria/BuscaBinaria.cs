using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caBuscaBinaria
{
    class BuscaBinaria
    {
        private int[] vetor = { 6, 2, 7, 4, 8, 0, 3, 9, 1, 2, 5 };

        public BuscaBinaria(int[] vetor)
        {
            this.vetor = vetor;
        }

        public int binarySearch(int[] vetor, int chave)
        {
            return binarySearch(vetor, chave, 0, vetor.Length - 1);
        }

        public int binarySearch(int[] vetor, int x, int low, int high)
        {
            if (low > high) // Condicao de parada
                return -1;

            int mid = (low + high) / 2;

            if (vetor[mid] < x)
                return binarySearch(vetor, x, mid + 1, high);
            else if (vetor[mid] > x)
                return binarySearch(vetor, x, low, mid - 1);
            else
                return mid;
        }
    }
}
