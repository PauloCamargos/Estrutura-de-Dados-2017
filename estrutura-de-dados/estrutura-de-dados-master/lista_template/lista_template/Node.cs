/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 Maio de 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Node for a doubly linked list
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_template
{
    class Node<ADT> : Object
    {
        private Node<ADT> nextNode;
        private Node<ADT> priorNode;
        ADT data;

        /// <summary>
        /// The default constructor
        /// </summary>
        public Node()
        {

        }

        /// <summary>
        /// Set a new node in the list
        /// </summary>
        /// <param name="value"> recives the node data value</param>
        public Node(ADT value)
        {
            data = value;
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
        /// Get the data in the node next to this one
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

        /// <summary>
        /// Get the data in the node prior to this one
        /// </summary>
        /// <returns></returns>
        public Node<ADT> getPrior()
        {
            return priorNode;
        }


        /// <summary>
        /// Sets the node prior to this one
        /// </summary>
        /// <param name="newNode"></param>
        public void setPrior(Node<ADT> newNode)
        {
            priorNode = newNode;
        }
    }
}
