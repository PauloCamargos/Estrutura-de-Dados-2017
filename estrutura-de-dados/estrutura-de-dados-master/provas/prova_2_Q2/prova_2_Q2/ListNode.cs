/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 July 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 ListNode for a doubly linked list
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_2_Q2
{
    class ListNode<ADT> : Object
    {
        private ListNode<ADT> nextListNode;
        private ListNode<ADT> priorListNode;
        ADT data;

        /// <summary>
        /// The default constructor
        /// </summary>
        public ListNode()
        {

        }

        /// <summary>
        /// Set a new node in the list
        /// </summary>
        /// <param name="value"> recives the node data value</param>
        public ListNode(ADT value)
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
        public ListNode<ADT> getNext()
        {
            return nextListNode;
        }

        /// <summary>
        /// Sets the node next to this one
        /// </summary>
        /// <param name="newListNode"></param>
        public void setNext(ListNode<ADT> newListNode)
        {
            nextListNode = newListNode;
        }

        /// <summary>
        /// Get the data in the node prior to this one
        /// </summary>
        /// <returns></returns>
        public ListNode<ADT> getPrior()
        {
            return priorListNode;
        }


        /// <summary>
        /// Sets the node prior to this one
        /// </summary>
        /// <param name="newListNode"></param>
        public void setPrior(ListNode<ADT> newListNode)
        {
            priorListNode = newListNode;
        }

        /// <summary>
        /// Checks if two values are equal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool isEqualTo(ADT value)
        {
            bool temp = EqualityComparer<ADT>.Default.Equals(this.getData(), value);
            return temp;
        }
    }
}
