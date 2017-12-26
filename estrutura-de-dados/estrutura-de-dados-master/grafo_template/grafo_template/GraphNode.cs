/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 July 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Graph Node for Adjacency List Representation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafo_template
{
    class GraphNode<ADT> : Object
    {
        private GraphNode<ADT> nextGraphNode;
        private GraphNode<ADT> priorGraphNode;
        public DoublyLinkedList<ADT> arrivalList = new DoublyLinkedList<ADT>();
        public DoublyLinkedList<ADT> departureList = new DoublyLinkedList<ADT>();
        ADT data;

        /// <summary>
        /// The default constructor
        /// </summary>
        public GraphNode()
        {

        }

        /// <summary>
        /// Set a new node in the graph
        /// </summary>
        /// <param name="value"></param>
        public GraphNode(ADT value)
        {
            data = value;
        }





        /***********************************************************/
        /*Set of methods that deals with the next/prior graph nodes*/
        /***********************************************************/

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
        /// Returns the next graph node
        /// </summary>
        /// <returns></returns>
        public GraphNode<ADT> getNext()
        {
            return nextGraphNode;
        }

        /// <summary>
        /// Sets the next node
        /// </summary>
        /// <param name="newGraphNode"></param>
        public void setNext(GraphNode<ADT> newGraphNode)
        {
            nextGraphNode = newGraphNode;
        }

        /// <summary>
        /// Returns the prior graph node
        /// </summary>
        /// <returns></returns>
        public GraphNode<ADT> getPrior()
        {
            return priorGraphNode;
        }

        /// <summary>
        /// Sets the prior node
        /// </summary>
        /// <param name="newGraphNode"></param>
        public void setPrior(GraphNode<ADT> newGraphNode)
        {
            priorGraphNode = newGraphNode;
        }

        /// <summary>
        /// Checks if two ADT are equals
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public bool isEqualTo(ADT value)
        {
            bool temp = EqualityComparer<ADT>.Default.Equals(this.getData(), value);
            return temp;
        }

        /**************************************************************************/
        /**************************************************************************/
        /*Set of methods that deals with the arrival/departure list of graph nodes*/
        /**************************************************************************/
        /**************************************************************************/

        /// <summary>
        /// Add a one way vertice (into this)
        /// </summary>
        /// <param name="arrivalValue"></param>
        public void insertArrivalNode(ADT arrivalValue, double weight)
        {
            this.arrivalList.insert(arrivalValue, weight);
        }

        /// <summary>
        /// Add a one way vertice (from this)
        /// </summary>
        /// <param name="departureValue"></param>
        public void insertDepartureNode(ADT departureValue, double weight)
        {
            this.departureList.insert(departureValue, weight);
        }

        /// <summary>
        /// Remove a one way vertice (into this)
        /// </summary>
        /// <param name="arrivalValue"></param>
        public void removeArrivalNode(ADT arrivalValue)
        {
            this.arrivalList.removeData(arrivalValue);
        }

        /// <summary>
        /// Remove a one way vertice (from this)
        /// </summary>
        /// <param name="departureValue"></param>
        public void removeDepartureNode(ADT departureValue)
        {
            this.departureList.removeData(departureValue);
        }

        /// <summary>
        /// Checks if this value is on the arrival list
        /// </summary>
        /// <param name="arrivalValue"></param>
        /// <returns></returns>
        public bool isArrivalNodeHere(ADT arrivalValue)
        {
            return (this.arrivalList.isHere(arrivalValue));
        }

        /// <summary>
        /// Checks if this value is on the departure list
        /// </summary>
        /// <param name="departureValue"></param>
        /// <returns></returns>
        public bool isDepartureNodeHere(ADT departureValue)
        {
            return (this.departureList.isHere(departureValue));
        }

        /// <summary>
        /// Set the edge weight
        /// </summary>
        /// <param name="departureValue"></param>
        /// <param name="weight"></param>
        public void setWeigh(ADT departureValue, double weight)
        {
            this.departureList.changeWeight(departureValue, weight);
        }


        //I now realized that I could just have made the arrival/departure lists public... 
        //Well, now is too late! What was was, and it will never be again
    }
}
