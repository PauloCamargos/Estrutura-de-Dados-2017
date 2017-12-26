using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila_template
{
    class Node<ADT> : Object
    {
        private ADT data;
        private Node<ADT> nextNode;
        private Node<ADT> priorNode;
    }
}
