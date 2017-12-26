/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 July 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Doubly linked list
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_2_Q2
{
    class DoublyLinkedList<ADT> : Object
    {
        ListNode<ADT> firstListNode;
        ListNode<ADT> lastListNode;

        /// <summary>
        /// The default constructor
        /// </summary>
        public DoublyLinkedList()
        {
            firstListNode = null;
            lastListNode = null;
        }

        /// <summary>
        /// Check if the list is empty
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (firstListNode == null && lastListNode == null)
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
                ListNode<ADT> temp = firstListNode;
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
                            firstListNode = null;
                            lastListNode = null;
                        }
                        else
                        {
                            temp.getNext().setPrior(temp.getPrior());
                            /*also could be:
                            temp.getNext().setPrior(null);*/
                            firstListNode = temp.getNext();
                        }
                        return temp.getData();
                    }
                    else
                    {
                        //Checks if it is the last node in the list
                        if (temp.getNext() == null)
                        {
                            temp.getPrior().setNext(temp.getNext());
                            lastListNode = temp.getPrior();
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
                ListNode<ADT> temp = new ListNode<ADT>();
                temp = firstListNode;
                //Console.Write("Beginning:\t");
                do
                {
                    Console.Write(temp.getData());
                    if (temp.getNext() == null)
                    {
                        Console.WriteLine("\nEnd");
                        break;
                    }
                    Console.Write("\n");
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
                ListNode<ADT> temp = firstListNode;

                while (temp != null)
                {
                    counter++;
                    temp = temp.getNext();
                }
                return counter;
            }
        }

        /// <summary>
        /// Insert a node in the end of the list
        /// </summary>
        /// <param name="insertItem"></param>
        public void insert(ADT insertItem)
        {
            ListNode<ADT> newListNode = new ListNode<ADT>(insertItem);

            if (isEmpty())
            {
                firstListNode = newListNode;
                lastListNode = newListNode;
            }
            else
            {
                //insert in the end
                newListNode.setPrior(lastListNode);
                newListNode.setNext(null);
                lastListNode.setNext(newListNode);
                lastListNode = newListNode;
            }
        }

        /// <summary>
        /// Insert a node in ascending order
        /// </summary>
        /// <param name="insertItem"></param>
        public void insertAscending(ADT insertItem)
        {
            ListNode<ADT> newListNode = new ListNode<ADT>(insertItem);

            if (isEmpty())
            {
                firstListNode = newListNode;
                lastListNode = newListNode;
            }
            else
            {
                ListNode<ADT> temp = firstListNode;
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
                    newListNode.setNext(temp);
                    newListNode.setPrior(temp.getPrior());
                    temp.getPrior().setNext(newListNode);
                    temp.setPrior(newListNode);
                }
                //insertItem value is greater than all others, insert in the end
                else
                {
                    newListNode.setPrior(lastListNode);
                    newListNode.setNext(null);
                    lastListNode.setNext(newListNode);
                    lastListNode = newListNode;
                }
            }
        }

        /// <summary>
        /// Insert a node in ascending order in a list given that it wil
        /// still be in ascending order after insertion
        /// </summary>
        /// <param name="insertItem"></param>
        /// <param name="position"></param>
        public void insertAscendingAt(ADT insertItem, int position)
        {
            ListNode<ADT> newListNode = new ListNode<ADT>(insertItem);

            if (isEmpty())
            {
                firstListNode = newListNode;
                lastListNode = newListNode;
            }
            else
            {
                ListNode<ADT> temp = findAt(position);

                //Checks if list is in ascending order
                if (isAscendingOrder())
                {
                    //If the next one is less than the current, insert node
                    if (isGreaterThan(newListNode.getData(), temp.getPrior().getData())
                        && isLessThan(newListNode.getData(), temp.getData()))
                    {
                        newListNode.setNext(temp);
                        newListNode.setPrior(temp.getPrior());
                        temp.getPrior().setNext(newListNode);
                        temp.setPrior(newListNode);
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
            ListNode<ADT> temp = firstListNode;
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
        public ListNode<ADT> findAt(int position)
        {
            if (isEmpty())
            {
                return null;
            }
            else
            {
                ListNode<ADT> temp = firstListNode;

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
                ListNode<ADT> temp = firstListNode;

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
                            firstListNode = null;
                            lastListNode = null;
                        }
                        else
                        {
                            temp.getNext().setPrior(temp.getPrior());
                            /*also could be:
                            temp.getNext().setPrior(null);*/
                            firstListNode = temp.getNext();
                        }
                        return temp.getData();
                    }
                    else
                    {
                        //Checks if it is the last node in the list
                        if (temp.getNext() == null)
                        {
                            temp.getPrior().setNext(temp.getNext());
                            lastListNode = temp.getPrior();
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

        /// <summary>
        /// Check if a given value is on the list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool isHere(ADT value)
        {
            if (isEmpty())
                return false;
            else
            {
                bool findFlag = false;
                ListNode<ADT> temp = new ListNode<ADT>();
                temp = firstListNode;
                do
                {
                    if (temp.isEqualTo(value))
                        findFlag = true;
                    else
                        temp = temp.getNext();
                } while (!findFlag);
                if (findFlag)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Insert something at this position
        /// </summary>
        /// <param name="insertItem"></param>
        /// <param name="position"></param>
        public void insertAt(ADT insertItem, int position)
        {
            ListNode<ADT> newListNode = new ListNode<ADT>(insertItem);
            if (position >= this.size())
                Console.WriteLine("A lista não tem essa posição!");
            else
            {
                ListNode<ADT> temp = findAt(position);

                if (isEmpty())
                {
                    firstListNode = newListNode;
                    lastListNode = newListNode;
                }
                else
                {
                    //Checks if it is the first node in the list
                    if (temp.getPrior() == null)
                    {
                        //Checks if it is also the last node in the list
                        if (temp.getPrior() == null && temp.getNext() == null)
                        {
                            firstListNode = newListNode;
                            lastListNode = newListNode;
                        }
                        else
                        {
                            firstListNode = newListNode;
                            newListNode.setNext(temp);
                            temp.setPrior(newListNode);
                        }
                    }
                    else
                    {
                        newListNode.setNext(temp);
                        newListNode.setPrior(temp.getPrior());
                        temp.getPrior().setNext(newListNode);
                        temp.setPrior(newListNode);
                    }
                }
            }            
        }

        /// <summary>
        /// Replace a node at some position by this value
        /// </summary>
        /// <param name="position"></param>
        /// <param name="insertItem"></param>
        public void replaceBy(int position, ADT insertItem)
        {
            if (position >= this.size())
                Console.WriteLine("A lista não tem essa posição!\n");
            else
            {
                if (isEmpty())
                    Console.WriteLine("A lista está vazia!");
                else
                {
                    ListNode<ADT> temp = findAt(position);
                    temp.setData(insertItem);
                }
            }
        }
    }
}