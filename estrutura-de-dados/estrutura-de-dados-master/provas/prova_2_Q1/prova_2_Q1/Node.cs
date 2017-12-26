/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 June 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Node for a binary tree
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_2_Q1
{
    class Node<ADT> : Object
    {
        private Node<ADT> leftNode;
        private Node<ADT> rightNode;
        ADT data;


        /// <summary>
        /// Default constructor
        /// </summary>
        public Node()
        {

        }

        /// <summary>
        /// Creates a new node
        /// </summary>
        /// <param name="value"></param>
        public Node(ADT value)
        {
            data = value;
        }

        /// <summary>
        /// Gets the data in the node
        /// </summary>
        /// <returns></returns>
        public ADT getData()
        {
            return data;
        }

        /// <summary>
        /// Sets the nodes data
        /// </summary>
        /// <param name="value"></param>
        public void setData(ADT value)
        {
            data = value;
        }

        /// <summary>
        /// Gets the node in the left branch
        /// </summary>
        /// <returns></returns>
        public Node<ADT> getLeft()
        {
            return leftNode;
        }

        /// <summary>
        /// Sets the node in the left branch
        /// </summary>
        /// <param name="newNode"></param>
        public void setLeft(Node<ADT> newNode)
        {
            leftNode = newNode;
        }

        /// <summary>
        /// Gets the node in the right branch
        /// </summary>
        /// <returns></returns>
        public Node<ADT> getRight()
        {
            return rightNode;
        }

        /// <summary>
        /// Sets the node in the right branch
        /// </summary>
        /// <param name="newNode"></param>
        public void setRight(Node<ADT> newNode)
        {
            rightNode = newNode;
        }

        /// <summary>
        /// Checks if this Nodes value is greater than other
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool isGreaterThan(ADT value)
        {
            var result = Comparer<ADT>.Default.Compare(this.getData(),value);
            if (result > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Checks if this Nodes value is less than other
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool isLessThan(ADT value)
        {
            var result = Comparer<ADT>.Default.Compare(this.getData(), value);
            if (result < 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Checks if two ADT are equals
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool isEqualTo(ADT value)
        {
            bool temp = EqualityComparer<ADT>.Default.Equals(this.getData() ,value);
            return temp;
        }   
    }
}
