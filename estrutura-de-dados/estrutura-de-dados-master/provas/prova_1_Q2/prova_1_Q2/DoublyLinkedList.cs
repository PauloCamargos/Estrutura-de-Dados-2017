/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 Maio de 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Doubly linked list

 Implemented methods:
 * isEmpty
 * isEqual
 * isGreaterThan
 * isLessThan
 * removeData
 * print
 * size
 * insertAscending
 * insertAscendingAt
 * isAscendingOrder
 * findAt
 * removeAt
 * binarySearch -> TODO
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_template
{
    class DoublyLinkedList<ADT> : Object
    {
        Node<ADT> firstNode;
        Node<ADT> lastNode;

        /// <summary>
        /// The default constructor
        /// </summary>
        public DoublyLinkedList()
        {
            firstNode = null;
            lastNode = null;
        }

        /// <summary>
        /// Check if the list is empty
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (firstNode == null && lastNode == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Checks if two ADT are equals
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public bool isEqual(ADT value1, ADT value2)
        {
            bool temp = EqualityComparer<ADT>.Default.Equals(value1, value2);
            return temp;
        }

        /// <summary>
        /// Checks if a value is greater than other
        /// </summary>
        /// <param name="value"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool isGreaterThan(ADT value, ADT other)
        {
            var result = Comparer<ADT>.Default.Compare(value, other);
            if (result >= 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Checks if a value is less than other
        /// </summary>
        /// <param name="value"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool isLessThan(ADT value, ADT other)
        {
            var result = Comparer<ADT>.Default.Compare(value, other);
            if (result <= 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Remove the first node (starting to the top) that
        /// is equal to the parameter
        /// </summary>
        /// <param name="itemToRemove"></param>
        /// <returns></returns>
        public ADT removeData(ADT itemToRemove)
        {
            if (isEmpty())
            {
                return default(ADT);
            }
            else
            {
                Node<ADT> temp = firstNode;
                bool findFlag = false;

                //Finds the first node with the same data
                do
                {
                    if (!isEqual(temp.getData(), itemToRemove))
                    {
                        findFlag = true;
                        break;
                    }
                    else
                        temp = temp.getNext();
                } while (temp != null);


                if (findFlag)
                {
                    //Checks if it is the first node in the list
                    if (temp.getPrior() == null)
                    {
                        //Checks if it is also the last node in the list
                        if (temp.getPrior() == null && temp.getPrior() == null)
                        {
                            firstNode = null;
                            lastNode = null;
                        }
                        else
                        {
                            temp.getNext().setPrior(temp.getPrior());
                            /*also could be:
                            temp.getNext().setPrior(null);*/
                            firstNode = temp.getNext();
                        }
                        return temp.getData();
                    }
                    else
                    {
                        //Checks if it is the last node in the list
                        if (temp.getNext() == null)
                        {
                            temp.getPrior().setNext(temp.getNext());
                            lastNode = temp.getPrior();
                        }
                        else
                        {
                            temp.getPrior().setNext(temp.getNext());
                            temp.getNext().setPrior(temp.getPrior());
                        }
                        return temp.getData();
                    }

                }
                //Didn't found the node with same value
                else
                    return default(ADT);
            }
        }

        /// <summary>
        /// Print to the console the current list
        /// </summary>
        public void print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Lista vazia!");
            }
            else
            {
                Node<ADT> temp = new Node<ADT>();
                temp = firstNode;
                Console.Write("Beginning:\t");
                do
                {
                    Console.Write(temp.getData());
                    if (temp.getNext() == null)
                    {
                        Console.WriteLine("\tEnd");
                        break;
                    }
                    Console.Write(" -> ");
                    temp = temp.getNext();
                } while (temp != null);
            }
        }

        /// <summary>
        /// Returns the number of items on the stack
        /// </summary>
        /// <returns></returns>
        public int size()
        {
            int counter = 0;

            if (isEmpty())
                return counter;
            else
            {
                Node<ADT> temp = firstNode;

                while (temp != null)
                {
                    counter++;
                    temp = temp.getNext();
                }
                return counter;
            }
        }

        /// <summary>
        /// Insert a node in ascending order
        /// </summary>
        /// <param name="insertItem"></param>
        public void insertAscending(ADT insertItem)
        {
            Node<ADT> newNode = new Node<ADT>(insertItem);

            if (isEmpty())
            {
                firstNode = newNode;
                lastNode = newNode;
            }
            else
            {
                Node<ADT> temp = firstNode;
                bool findFlag = false;

                //Finds a node that its value is greater than insertItem
                do
                {
                    if (isLessThan(insertItem, temp.getData()))
                    {
                        findFlag = true;
                        break;
                    }
                    else
                        temp = temp.getNext();
                } while (temp != null);

                if (findFlag)
                {
                    newNode.setNext(temp);
                    newNode.setPrior(temp.getPrior());
                    temp.getPrior().setNext(newNode);
                    temp.setPrior(newNode);
                }
                //insertItem value is greater than all others, insert in the end
                else
                {
                    newNode.setPrior(lastNode);
                    newNode.setNext(null);
                    lastNode.setNext(newNode);
                    lastNode = newNode;
                }
            }
        }

        /// <summary>
        /// Insert a node in ascending order in a list given that it wil
        /// still be in ascending order after insertion
        /// TODO: avoid crash by miss use 
        /// </summary>
        /// <param name="insertItem"></param>
        /// <param name="position"></param>
        public void insertAscendingAt(ADT insertItem, int position)
        {
            Node<ADT> newNode = new Node<ADT>(insertItem);

            if (isEmpty())
            {
                firstNode = newNode;
                lastNode = newNode;
            }
            else
            {
                Node<ADT> temp = findAt(position);

                //Checks if list is in ascending order
                if (isAscendingOrder())
                {
                    //If the next one is less than the current, insert node
                    if (isGreaterThan(newNode.getData(), temp.getPrior().getData())
                        && isLessThan(newNode.getData(), temp.getData()))
                    {
                        newNode.setNext(temp);
                        newNode.setPrior(temp.getPrior());
                        temp.getPrior().setNext(newNode);
                        temp.setPrior(newNode);
                    }
                    else
                    {
                        Console.WriteLine("Impossível de inserir");
                    }
                }
                else
                {
                    Console.WriteLine("Lista não em ordem");
                }
            }
        }

        /// <summary>
        /// Checks if a list is in ascending order
        /// </summary>
        /// <returns></returns>
        public bool isAscendingOrder()
        {
            Node<ADT> temp = firstNode;
            bool findFlag = true;

            if (size() == 0)
                return findFlag;
            else
            {
                do
                {
                    if (isLessThan(temp.getNext().getData(), temp.getData()))
                    {
                        findFlag = false;
                        break;
                    }
                    else
                        temp = temp.getNext();
                } while (temp.getNext() != null);
                return findFlag;
            }
        }

        /// <summary>
        /// Finds the node in the given position
        /// Returns null if not found
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Node<ADT> findAt(int position)
        {
            if (isEmpty())
            {
                return null;
            }
            else
            {
                Node<ADT> temp = firstNode;

                if (size() < position)
                    return null;
                else
                {
                    for (int counter = 1; counter < position; counter++)
                        temp = temp.getNext();
                    return temp;
                }
            }
        }

        /// <summary>
        /// Removes the node in the n-th position
        /// </summary>
        /// <param name="itemToRemove"></param>
        /// <returns></returns>
        public ADT removeAt(int itemToRemove)
        {
            if (isEmpty())
            {
                return default(ADT);
            }
            else
            {
                Node<ADT> temp = firstNode;

                if (size() < itemToRemove)
                    return default(ADT);
                else
                {
                    for (int counter = 1; counter < itemToRemove; counter++)
                        temp = temp.getNext();

                    //Checks if it is the first node in the list
                    if (temp.getPrior() == null)
                    {
                        //Checks if it is also the last node in the list
                        if (temp.getPrior() == null && temp.getNext() == null)
                        {
                            firstNode = null;
                            lastNode = null;
                        }
                        else
                        {
                            temp.getNext().setPrior(temp.getPrior());
                            /*also could be:
                            temp.getNext().setPrior(null);*/
                            firstNode = temp.getNext();
                        }
                        return temp.getData();
                    }
                    else
                    {
                        //Checks if it is the last node in the list
                        if (temp.getNext() == null)
                        {
                            temp.getPrior().setNext(temp.getNext());
                            lastNode = temp.getPrior();
                        }
                        else
                        {
                            temp.getNext().setPrior(temp.getPrior());
                            temp.getPrior().setNext(temp.getNext());
                        }
                        return temp.getData();
                    }
                }
            }
        }
    }
}
