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

namespace grafo_template
{
    class DoublyLinkedList<ADT> : Object
    {
        public ListNode<ADT> firstListNode;
        ListNode<ADT> lastListNode;

        /// <summary>
        /// TODO: Fix this
        /// This is a lazy man's way to implement a priority queue for Dijkstra's algorithm. 
        /// Probaly if something goes wrong, it will be here!
        /// </summary>
        /// <param name="destination"></param>
        public void printDijkistraResult(ADT destination)
        {
            if (isEmpty())
            {
                // Console.WriteLine("Lista vazia!");
            }
            else
            {
                ListNode<ADT> temp = new ListNode<ADT>();
                ListNode<ADT> trackingTemp = new ListNode<ADT>();
                temp = this.find(destination);
                trackingTemp = temp;
                temp = trackingTemp;
                Console.Write(temp.getData());
                Console.Write(" via ");
                Console.Write(temp.DijkistraPath);
                Console.Write(" distance ");
                Console.Write(temp.DijkistraWeight);
                Console.Write("\n");
                do
                {
                    if (trackingTemp.isEqualTo(temp.DijkistraPath))
                    {
                        temp = trackingTemp;
                        Console.Write(temp.getData());
                        Console.Write(" via ");
                        Console.Write(temp.DijkistraPath);
                        Console.Write(" distance ");
                        Console.Write(temp.DijkistraWeight);
                        if (temp.getNext() == null)
                            break;
                        Console.Write("\n");
                    }
                    trackingTemp = trackingTemp.getPrior();
                } while (trackingTemp.getPrior() != null);
                Console.Write("\n");
                Console.Write("Total distance " + this.find(destination).DijkistraWeight);
            }
        }

        /// <summary>
        /// TODO: Fix this
        /// This is a lazy man's way to implement a priority queue for Dijkstra's algorithm. 
        /// Probaly if something goes wrong, it will be here!
        /// </summary>
        /// <returns></returns>
        public bool isDijkistraWeightAscendingOrder()
        {
            ListNode<ADT> temp = firstListNode;
            bool findFlag = true;

            if (size() == 0)
                return findFlag;
            else
            {
                while (temp.getNext() != null)
                {
                    if (temp.DijkistraWeight > temp.getNext().DijkistraWeight)
                    {
                        findFlag = false;
                        break;
                    }
                    else
                        temp = temp.getNext();
                } 
                return findFlag;
            }
        }

        /// <summary>
        /// TODO: Fix this
        /// This is a lazy man's way to implement a priority queue for Dijkstra's algorithm. 
        /// Probaly if something goes wrong, it will be here!
        /// </summary>
        /// <param name="newListNode"></param>
        public void insert(ListNode<ADT> newListNode)
        {
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
        /// TODO: Fix this
        /// This is a lazy man's way to implement a priority queue for Dijkstra's algorithm. 
        /// Probaly if something goes wrong, it will be here!
        /// </summary>
        /// <param name="value"></param>
        /// <param name="weight"></param>
        public void changeDijkstraWeight(ADT value, double weight)
        {
            ListNode<ADT> temp = find(value);

            if (temp != null)
                temp.DijkistraWeight = weight;
        }

        /// <summary>
        /// TODO: Fix this
        /// This is a lazy man's way to implement a priority queue for Dijkstra's algorithm. 
        /// Probaly if something goes wrong, it will be here!
        /// </summary>
        /// <param name="insertItem"></param>
        /// <param name="priority"></param>
        public void insertAscending(ADT insertItem, double priority)
        {
            ListNode<ADT> newListNode = new ListNode<ADT>(insertItem);
            newListNode.DijkistraWeight = priority;

            if (isEmpty())
            {
                firstListNode = newListNode;
                lastListNode = newListNode;
            }
            else
            {
                ListNode<ADT> temp = firstListNode;
                bool findFlag = false;

                //Finds where the node will be in the priority queue
                do
                {
                    if (temp.DijkistraWeight > priority)
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
        /// TODO: Fix this
        /// This is a lazy man's way to implement a priority queue for Dijkstra's algorithm. 
        /// Probaly if something goes wrong, it will be here too!
        /// </summary>
        public void bubbleSort()
        {
            while (!isDijkistraWeightAscendingOrder())
            {
                ListNode<ADT> temp = firstListNode;
                ADT aux;
                double aux2;
                ADT aux3;

                do
                {
                    if (temp.DijkistraWeight > temp.getNext().DijkistraWeight)
                    {
                        //Swapp then

                        // temp
                        //  |
                        //  v
                        //  A -> B -> C

                        // aux = A
                        aux = temp.getData();
                        aux2 = temp.DijkistraWeight;
                        aux3 = temp.DijkistraPath;
                        // (A.data = B.data) -> B
                        temp.setData(temp.getNext().getData());
                        temp.DijkistraWeight = temp.getNext().DijkistraWeight;
                        temp.DijkistraPath = temp.getNext().DijkistraPath;
                        // (A.data = B.data) -> (B.data = aux.data) 
                        temp.getNext().setData(aux);
                        temp.getNext().DijkistraWeight = aux2;
                        temp.getNext().DijkistraPath = aux3;
                    }                    
                    else
                        temp = temp.getNext();

                    if (temp.getNext() == null || temp.getNext().getNext() == null)
                        break;

                } while (temp != null || temp.getNext() != null);
            }
        }

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
        /// Checks if two things are equal
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
                    if (temp.isEqualTo(itemToRemove))
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
               // Console.WriteLine("Lista vazia!");
            }
            else
            {
                ListNode<ADT> temp = new ListNode<ADT>();
                temp = firstListNode;
                do
                {
                    Console.Write(temp.getData());
                    if (temp.getNext() == null)
                        break;
                    Console.Write(" | ");                    
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
        public void insert(ADT insertItem, double weight)
        {
            ListNode<ADT> newListNode = new ListNode<ADT>(insertItem, weight);

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
                    if (newListNode.isLessThan(temp.getData()))
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
                    if (newListNode.isGreaterThan(temp.getPrior().getData())
                        && newListNode.isLessThan(temp.getData()))
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
                while (temp.getNext() != null)
                {
                    if (temp.getWeight() > temp.getNext().getWeight())
                    {
                        findFlag = false;
                        break;
                    }
                    else
                        temp = temp.getNext();
                } 
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
        public ListNode<ADT> removeAt(int itemToRemove)
        {
            if (isEmpty())
            {
                return null;
            }
            else
            {
                ListNode<ADT> temp = firstListNode;

                if (size() < itemToRemove)
                    return null;
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
                        return temp;
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
                        return temp;
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
        /// Returns the node with this value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ListNode<ADT> find(ADT value)
        {
            if (isEmpty())
                return null;
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
                    {
                        temp = temp.getNext();
                        if (temp == null)
                            break;
                    }
                } while (!findFlag);
                if (findFlag)
                    return temp;
                else
                    return null;
            }
        }

        /// <summary>
        /// Changes the weight of an edge
        /// </summary>
        /// <param name="value"></param>
        /// <param name="weight"></param>
        public void changeWeight(ADT value, double weight)
        {
            ListNode<ADT> temp = find(value);

            if (temp != null)
                temp.setWeight(weight);
        }
    }
}