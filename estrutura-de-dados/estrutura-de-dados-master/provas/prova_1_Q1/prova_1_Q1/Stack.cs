/*
 Stack (FILO) implementation using OOP

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
    class Stack<ADT> : Object
    {
        private Node<ADT> top;

        /// <summary>
        /// Creates a new stack that is empty
        /// </summary>
        public Stack()
        {
            top = null;
        }

        /// <summary>
        /// Check if the stack is empty
        /// </summary>
        /// <returns> Returns true if empty</returns>
        public bool isEmpty()
        {
            if (top == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Send a new item (node) to the top of the stack
        /// </summary>
        /// <param name="insertItem">Insert a new node to the Stack with this value</param>
        public void push(ADT insertItem)
        {
            if (isEmpty())
                top = new Node<ADT>(insertItem);
            else
            {
                Node<ADT> next = new Node<ADT>(insertItem);
                next.setNext(top);
                top = next;
            }

        }

        /// <summary>
        /// Removes the last node (top) insert to the stack
        /// </summary>
        /// <returns>Returns the poped node's value</returns>
        public ADT pop()
        {
            if (isEmpty())
            {
                ADT temp = top.getData();
                Console.WriteLine("Empty Stack!");
                return temp;
            }
            else
            {
                ADT temp = top.getData();
                top = top.getNext();
                return temp;
            }
        }

        /// <summary>
        /// Print to the console the current stack
        /// </summary>
        public void print()
        {
            if (isEmpty())
                Console.WriteLine("This stack is empty!");
            else
            {
                Node<ADT> temp = top;

                while (temp != null)
                {
                    Console.WriteLine("\n" + temp.getData());
                    temp = temp.getNext();
                }
            }
        }

        /// <summary>
        /// Returns the top item from the stack but does not remove it
        /// </summary>
        /// <returns></returns>
        public ADT peek()
        {
            ADT temp = top.getData();
            return temp;
        }

        /// <summary>
        /// Returns the number of items on the stack
        /// </summary>
        /// <returns>Returns a integer with the stack size</returns>
        public int size()
        {
            int counter = 0;

            if (isEmpty())
                return counter;
            else
            {
                Node<ADT> temp = top;

                while (temp != null)
                {
                    counter++;
                    temp = temp.getNext();
                }

                return counter;
            }
        }
    }
}
