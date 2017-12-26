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

namespace grafo_template
{
    class ListNode<ADT> : Object
    {
        private ListNode<ADT> nextListNode;
        private ListNode<ADT> priorListNode;
        private double weight;
        ADT data;

        // TODO: Fix this
        // This is a lazy man's way to implement a priority queue for Dijkstra's algorithm. 
        // Probaly if something goes wrong, it will be here!
        public ADT DijkistraPath;
        public double DijkistraWeight;
        public bool DijkistraProcessed = false;

        /// <summary>
        /// TODO: Fix this
        /// This is a lazy man's way to implement a priority queue for Dijkstra's algorithm. 
        /// Probaly if something goes wrong, it will be here!
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool isDijkistraPathEqualTo(ADT value)
        {
            bool temp = EqualityComparer<ADT>.Default.Equals(this.DijkistraPath, value);
            return temp;
        }

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
        /// Set a new node in the list with a value and a weight
        /// </summary>
        /// <param name="value"></param>
        /// <param name="edgeWeight"></param>
        public ListNode(ADT value, double edgeWeight)
        {
            data = value;
            weight = edgeWeight;
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
        /// Sets both data and weight
        /// </summary>
        /// <param name="value"></param>
        /// <param name="edgeWeight"></param>
        public void setData(ADT value, double edgeWeight)
        {
            data = value;
            weight = edgeWeight;
        }

        /// <summary>
        /// Sets the weight
        /// </summary>
        /// <param name="edgeWeight"></param>
        public void setWeight(double edgeWeight)
        {
            weight = edgeWeight;
        }

        /// <summary>
        /// Gets the weight
        /// </summary>
        /// <returns></returns>
        public double getWeight()
        {
            return weight;
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

        /// <summary>
        /// Checks the greater value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool isGreaterThan(ADT value)
        {
            var result = Comparer<ADT>.Default.Compare(this.data, value);
            if (result >= 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Checks the smallest value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool isLessThan(ADT value)
        {
            var result = Comparer<ADT>.Default.Compare(this.data, value);
            if (result <= 0)
                return true;
            else
                return false;
        }
    }
}
