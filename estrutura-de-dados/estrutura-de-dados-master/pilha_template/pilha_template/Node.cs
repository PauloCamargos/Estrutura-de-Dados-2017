/*
 Node to a stack (FIFO)

 Ronaldo Sena
 ronaldo.sena@outlook.com
 Maio de 2017
 Use it as you please. If we meet some day, and you think
 this stuff is helpful, you can buy me a beer
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_template
{
    class Node<ADT> : Object
    {
        private ADT data;
        private Node<ADT> nextNode;

        /// <summary>
        /// The default constructor
        /// </summary>
        public Node()
        {
            nextNode = null;
        }

        /// <summary>
        /// Set a new node in the stack
        /// </summary>
        /// <param name="value"> recives the node data value</param>
        public Node(ADT value)
        {
            data = value;
            nextNode = null;
        }

        /// <summary>
        /// Set a new node in the stack
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newNode"></param>
        public Node(ADT value, Node<ADT> newNode)
        {
            data = value;
            nextNode = newNode;
        }

        /// <summary>
        /// Get the data in this node
        /// </summary>
        /// <returns></returns>
        public ADT getData()
        {
            return data;
        }

        /// <summary>
        /// Set the data in this node
        /// </summary>
        /// <param name="value"></param>
        public void setData(ADT value)
        {
            data = value;
        }

        /// <summary>
        /// Get the node next to this one
        /// </summary>
        /// <returns></returns>
        public Node<ADT> getNext()
        {
            return nextNode;
        }

        /// <summary>
        /// Sets the node next to this one
        /// </summary>
        /// <param name="newNode"></param>
        public void setNext(Node<ADT> newNode)
        {
            nextNode = newNode;
        }
    }
}
