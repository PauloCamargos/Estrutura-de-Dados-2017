/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 July 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Graph with Adjacency List Representation

 Implemented methods
 * Graph
 * isEmpty
 * find
 * insertGraphNode
 * addEdge
 * directConnection
 * setEdgeWeight
 * removeEdge
 * print
 * printConnections
 * DepthFirstSearch - pending
 * BreadthFirstSearch - pending
 * Dijkstra - pending
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafo_template
{
    class Graph<ADT> : Object
    {
        GraphNode<ADT> graphStart;
        GraphNode<ADT> graphEnd;
        //I'm too lazy to properly implement this now, maybe I'll do this latter
        //I'm doing this here because I have not implemented a method to
        DoublyLinkedList<ADT> PriorityQueue = new DoublyLinkedList<ADT>();


        /// <summary>
        /// The default constructor
        /// </summary>
        public Graph()
        {
            graphStart = null;
            graphEnd = null;
        }

        /// <summary>
        /// Check if the graph is empty
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (graphStart == null && graphEnd == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Find a node with this value
        /// </summary>
        /// <param name="valueToFind"></param>
        public GraphNode<ADT> find(ADT valueToFind)
        {
            GraphNode<ADT> temp = graphStart;
            do
            {
                if (temp.isEqualTo(valueToFind))
                    return temp;
                else
                    temp = temp.getNext();
            } while (temp.getData() != null);
            return null;
        }

        /// <summary>
        /// Insert a node in the Graph
        /// </summary>
        /// <param name="insertValue"></param>
        public void insertGraphNode(ADT insertValue)
        {
            GraphNode<ADT> newGraphNode = new GraphNode<ADT>(insertValue);

            if (isEmpty())
            {
                graphStart = newGraphNode;
                graphEnd = newGraphNode;
            }
            else
            {
                //insert in the end
                newGraphNode.setPrior(graphEnd);
                newGraphNode.setNext(null);
                graphEnd.setNext(newGraphNode);
                graphEnd = newGraphNode;
            }

            //TODO:fix this latter
            //This is for Dijkstra Algorithm, remember to fix this latter
            PriorityQueue.insertAscending(insertValue, double.PositiveInfinity);
        }

        /// <summary>
        /// Creates an edge between two graph nodes. If not specified, the default weight will be 1.0 and the edge will be undirected
        /// </summary>
        /// <param name="firstNodeValue"></param>
        /// <param name="secondNodeValue"></param>
        public void addEdge(ADT firstNodeValue, ADT secondNodeValue, double edgeWeight = 1.0)
        {
            GraphNode<ADT> firstNode = find(firstNodeValue);
            GraphNode<ADT> secondNode = find(secondNodeValue);
 
            if (firstNode == null || secondNode == null)
                Console.WriteLine("Nós não encontrados!");
            else
            {
                //Insert the second node into the first node's arrival list
                firstNode.insertArrivalNode(secondNode.getData(), edgeWeight);
                //Insert the first node into the second node's departure list
                secondNode.insertDepartureNode(firstNode.getData(), edgeWeight);
                //Insert the second node into the first node's arrival list
                firstNode.insertDepartureNode(secondNode.getData(), edgeWeight);
                //Insert the first node into the second node's departure list
                secondNode.insertArrivalNode(firstNode.getData(), edgeWeight);
            }
        }

        /// <summary>
        /// Checks if there a direct connection between two nodes
        /// </summary>
        /// <returns></returns>
        public bool directConnection(ADT arrivalNodeValue, ADT departureNodeValue)
        {
            GraphNode<ADT> arrivalNode = find(arrivalNodeValue);
            GraphNode<ADT> departureNode = find(departureNodeValue);

            if (arrivalNode == null || departureNode == null)
            {
                Console.WriteLine("Nós não encontrados!");
                return false;
            }
            else
            {
                //Check if the departure node is in the arrivals node arrival list
                bool temp1 = arrivalNode.isDepartureNodeHere(departureNode.getData());
                //Check if the arrival node is in the departures node departure list
                bool temp2 = departureNode.isArrivalNodeHere(arrivalNode.getData());

                if (temp1 && temp2)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Set the weight on an edge. Set the optitional parameter "both" as FALSE to change only the one-way edge
        /// </summary>
        /// <param name="arrivalNodeValue"></param>
        /// <param name="departureNodeValue"></param>
        /// <param name="edgeWeight"></param>
        /// <param name="both"></param>
        public void setEdgeWeight(ADT arrivalNodeValue, ADT departureNodeValue, double edgeWeight, bool both = true)
        {
            GraphNode<ADT> arrivalNode = find(arrivalNodeValue);
            GraphNode<ADT> departureNode = find(departureNodeValue);
            bool conectionFlag = directConnection(arrivalNode.getData(), departureNode.getData());

            if (conectionFlag)
            {
                if (both)
                {
                    arrivalNode.setWeigh(departureNodeValue, edgeWeight);
                    departureNode.setWeigh(arrivalNodeValue, edgeWeight);
                }
                else
                {
                    arrivalNode.setWeigh(departureNodeValue, edgeWeight);
                }
            }
            else
                Console.WriteLine("Unable to find the edge!");
        }

        /// <summary>
        /// Remove an edge between two nodes
        /// </summary>
        public void removeEdge(ADT arrivalNodeValue, ADT departureNodeValue)
        {
            GraphNode<ADT> arrivalNode = find(arrivalNodeValue);
            GraphNode<ADT> departureNode = find(departureNodeValue);
            bool conectionFlag = directConnection(arrivalNode.getData(), departureNode.getData());

            if (conectionFlag)
            {
                //Remove the departure node from the arrivals node arrival list
                arrivalNode.removeArrivalNode(departureNode.getData());
                //Remove the arrival node from the departures node departure list
                departureNode.removeDepartureNode(arrivalNode.getData());
            }
            else
                Console.WriteLine("Unable to remove edge!");
        }

        /// <summary>
        /// Print to the console the graph
        /// </summary>
        public void print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Grafo vazio!");
            }
            else
            {
                GraphNode<ADT> temp = new GraphNode<ADT>();
                temp = graphStart;
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
        /// Prints all graph connections
        /// </summary>
        public void printConnections()
        {
            if (isEmpty())
            {
                Console.WriteLine("Grafo vazio!");
            }
            else
            {
                GraphNode<ADT> temp = new GraphNode<ADT>();
                
                //Printing the departures
                temp = graphStart;
                Console.Write("Beginning\n\n");
                do
                {
                    Console.Write(temp.getData());
                    Console.Write(" => ");                    
                    temp.departureList.print();
                    Console.Write("\n");
                    if (temp.getNext() == null)
                    {
                        Console.WriteLine("\nEnd\n\n");
                        break;
                    }
                    temp = temp.getNext();
                } while (temp != null);

                //Printing the arrivals
                temp = graphStart;
                Console.Write("Beginning\n\n");
                do
                {
                    Console.Write(temp.getData());
                    Console.Write(" <= ");                    
                    temp.arrivalList.print();
                    Console.Write("\n");
                    if (temp.getNext() == null)
                    {
                        Console.WriteLine("\nEnd\n\n");
                        break;
                    }
                    temp = temp.getNext();
                } while (temp != null);
            }
        }

        /// <summary>
        /// Given a node as the root, this algorithm explores as far as possible along each branch before backtracking
        /// </summary>
        public void DepthFirstSearch()
        {
            //I should use a stack for that

        }

        /// <summary>
        /// 
        /// </summary>
        public void BreadthFirstSearch()
        {
            //I should use a queue for that

        }

        /// <summary>
        // TODO: Fix this
        /// Algorithm for finding the shortest paths between nodes in a graph
        /// </summary>
        public void Dijkstra(ADT sourceValue, ADT destinationValue)
        {
            //Backtracking the whole thing
            DoublyLinkedList<ADT> BackTrackingStack = new DoublyLinkedList<ADT>();
            ListNode<ADT> auxDepartureNode = new ListNode<ADT>();
            ADT newSourceValue = sourceValue;
            int counter = 0;

            if (this.find(newSourceValue) == null || this.find(destinationValue) == null)
                Console.WriteLine("Nós de origem/destino não encontrados!");
            else
            {
                PriorityQueue.changeDijkstraWeight(newSourceValue, 0);

                while (PriorityQueue.find(destinationValue).DijkistraWeight == double.PositiveInfinity)
                {
                    PriorityQueue.bubbleSort();
                    auxDepartureNode = this.find(newSourceValue).departureList.firstListNode;
                    while (auxDepartureNode != null)
                    {
                        if (PriorityQueue.find(auxDepartureNode.getData()).DijkistraWeight >
                            PriorityQueue.find(newSourceValue).DijkistraWeight + auxDepartureNode.getWeight()
                            && !PriorityQueue.find(auxDepartureNode.getData()).DijkistraProcessed)
                        {
                            PriorityQueue.find(auxDepartureNode.getData()).DijkistraWeight =
                                PriorityQueue.find(newSourceValue).DijkistraWeight + auxDepartureNode.getWeight();
                            PriorityQueue.find(auxDepartureNode.getData()).DijkistraPath =
                                PriorityQueue.find(newSourceValue).getData();
                        }

                        auxDepartureNode = auxDepartureNode.getNext();
                        PriorityQueue.bubbleSort();
                    }
                    PriorityQueue.find(newSourceValue).DijkistraProcessed = true;
                    newSourceValue = PriorityQueue.findAt(++counter).getData();
                }
                //Showing the shortest path
                PriorityQueue.printDijkistraResult(destinationValue);
            }
        }
    }
}