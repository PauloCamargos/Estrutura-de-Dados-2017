/*
 Ronaldo Sena
 ronaldo.sena@outlook.com
 June 2017
 Use it as you please. If we meet some day, and you think
 this stuff was helpful, you can buy me a beer

 Binary tree
 Implemented methods
 * BinaryTree
 * isEmpty
 * insertInOrder
 * getHeight
 * print
 * nodeCounter
 * find
 * remove
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvore_binaria
{
    class BinaryTree<ADT> : Object
    {
        private Node<ADT> root;
        private int counter = 0;

        /// <summary>
        /// Default constructor
        /// </summary>
        public BinaryTree()
        {
            root = null;
        }

        /// <summary>
        /// Returns true if empty
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (root == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Insert a node in order on the tree 
        /// </summary>
        /// <param name="value"></param>
        public void insertInOrder(ADT value)
        {
            insertInOrder(root, value);
            counter++;
        }

        /// <summary>
        /// Uses recursion to insert a node in ascendig order
        /// </summary>
        /// <param name="root">Tree's root</param>
        /// <param name="value">Value to be added</param>
        private void insertInOrder(Node<ADT> newNode, ADT value)
        {
            //If the root is null, then the new node is the root. 
            //If the root isnt null, compare with the value to be added.
            //If they are the same, just ignore it. If not, compare with the left child. 
            //If the child is null, insert here. If not, get the right and do the same.
            //untill reach a null
            //e.g.
            //         5
            //       /   \
            //      2     6
            //     / \    / \ 
            //    N   3  N   N
            //       / \
            //      N   4
            //
            //The root is null, insert (5) here
            //The root is (5). (2)>(5)? Get left.
            //      Left child of (5). Is null, insert (2) here;
            //The root is (5). (3)>(5)? Get left.
            //      The root is (2). (3)>(2)? Get right.
            //              Right child of (2) is null, insert (3) here;
            //The root is (5). (6)>(5)? Get right.
            //      Right child of(5) is null, insert(6) here;
            //The root is (5). (4)>(5)? Get left.
            //      The root is (2). (4)>(2)? Get right.
            //              The root is (3). (4)>(3)? Get right.
            //                      Right child of(3) is null, insert(4) here;
            //The root is (5)

            //If the root is empty then insert here the new node
            if (isEmpty())
                root = new Node<ADT>(value);
            else
            {
                //If the value to be added is less then the root
                //go to the left node. Use recursion untill you
                //reached a null value
                if (newNode.isEqualTo(value))
                {
                    //do nothing
                }
                else
                {
                    if (newNode.isGreaterThan(value))
                    {
                        if (newNode.getLeft() != null)
                            //Send the current root's left child as the new root
                            insertInOrder(newNode.getLeft(), value);
                        else
                            //If its null then insert here
                            newNode.setLeft(new Node<ADT>(value));
                    }
                    else
                    {
                        //If the value to be added is greater then the root
                        //go to the right node. Use recursion untill you
                        //reached a null value
                        if (newNode.isLessThan(value))
                        {
                            if (newNode.getRight() != null)
                                //Send the current root's right child as the new root
                                insertInOrder(newNode.getRight(), value);
                            else
                                //If its null then insert here
                                newNode.setRight(new Node<ADT>(value));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets the tree's height
        /// </summary>
        /// <returns></returns>
        public int getHeight()
        {
            if (root == null)
                return 1;
            else
                return getHeight(root);
        }

        /// <summary>
        /// Gets the tree height, that is, how many levels there are
        /// starting from this node
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private int getHeight(Node<ADT> root)
        {
            if (root == null)
                return 0;

            //If the root isn't null, then pass the node as a parameter
            //if the next node is null, then you reached the bottom of the left branch
            //and returns zero, then get to node right of the "current root" and do the
            //same thing, i.e., acess the left node untill you reached a null. Do this
            //for all children
            //e.g.
            //         4
            //       /   \
            //      2     5
            //     / \    / \ 
            //    N   1  N   N
            //       / \
            //      N   N
            //
            //The root is (4). Get the left (2)
            //      Now the root is (2). Get the left (null) -> leftHeight = 0
            //      The root still is (2). Get the right (1)
            //              Now the root is (1). Get the left (null) -> leftHeight = 0 
            //              The root still is (1).Get the right (null) -> rightHeight = 0
            //      The root still is (2). -> rightHeight = 1
            //The root is (4). -> rightHeight = 2
            //The root is (4). Get the right (5)
            //      Now the root is (5). Get the left (null) -> leftHeight = 0
            //      The root still is (5). Get the right (null) -> rightHeight = 0
            //The root is (4). -> leftHeight = 1
            //
            //return rightHeight + 1
            //return 3

            int leftHeight = getHeight(root.getLeft());
            int rightHeight = getHeight(root.getRight());

            if (leftHeight > rightHeight)
                return leftHeight + 1;
            else
                return rightHeight + 1;
        }

        /// <summary>
        /// Prints the tree to the console
        /// </summary>
        public void print()
        {
            if (root == null)
                Console.WriteLine("Árvore vazia");
            else
                print(root);
        }

        /// <summary>
        /// Prints the tree to the console starting from this node
        /// </summary>
        /// <param name="root"></param>
        private void print(Node<ADT> root)
        {
            //e.g.
            //         4
            //       /   \
            //      2      5
            //     / \    /  \
            //    1   N  N    N
            //   / \
            //  N   N
            //
            //The root is (4). Left child is null? No
            //      The root is (2). Left child is null? No
            //              The root is (1). Left child is null? Yes: print it
            //      The root is (2). Print it. Right child is null? go up
            //The root is (4). Print it. Right child is null? get right
            //      The root is (5). Left child is null? Yes: print it

            if (root.getLeft() != null)
                print(root.getLeft());
            Console.Write(root.getData() + "\t");
            if (root.getRight() != null)
                print(root.getRight());
        }

        /// <summary>
        /// Returns the number of nodes in the tree
        /// </summary>
        /// <returns></returns>
        public int nodeCounter()
        {
            return counter;
        }

        /// <summary>
        /// Find a node with this value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node<ADT> find(ADT value)
        {
            if (isEmpty())
                return null;
            else
                return find(root, value);
        }

        /// <summary>
        /// Private method to find a node with a given value
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private Node<ADT> find(Node<ADT> newNode, ADT value)
        {
            //e.g.
            //         4
            //       /   \
            //      2      5
            //     / \    /  \
            //    1   N  N    N
            //   / \
            //  N   N
            //
            //Value to be found is 3
            //The root is (4). Is equal to value? No, is greater? No, get left
            //      The root is (2). Is equal to value? No, is greater? Yes, get right
            //              The root is (null). return null
            //
            //Value to be found is 1
            //The root is (4). Is equal to value? No, is greater? No, get left
            //      The root is (2). Is equal to value? No, is greater? No, get left
            //              The root is (1). Is equal to value? Yes, return (1)
            //
            //Value to be found is 5
            //The root is (4). Is equal to value? No, is greater? Yes, get right
            //      The root is (5). Is equal to value? Yes, return (5)

            if (newNode == null)
                return null;
            else
            {
                if (newNode.isEqualTo(value))
                    return newNode;
                else
                {
                    if (newNode.isGreaterThan(value))
                        return find(newNode.getLeft(), value);
                    else
                    {
                        if (newNode.isLessThan(value))
                            return find(newNode.getRight(), value);
                        else
                            return null;
                    }
                }
            }                        
        }

        /// <summary>
        /// Private method that returns the node with the minimum value
        /// </summary>
        /// <param name="newNode"></param>
        /// <returns></returns>
        private Node<ADT> findMinimum(Node<ADT> newNode)
        {
            //Gets the minimum value in the tree, assuming that it is ordered
            if (newNode != null)
                while (newNode.getLeft() != null)
                    newNode = newNode.getLeft();
            return newNode;
        }

        /// <summary>
        /// Private method to remove the node with minimum value
        /// </summary>
        /// <param name="nodeToRemove"></param>
        /// <returns></returns>
        private Node<ADT> removeMinimum(Node<ADT> nodeToRemove)
        {
            //e.g.
            //         8
            //       /   \
            //      5     9
            //     / \      \ 
            //    1   3      11
            //         \       
            //          2   
            //
            //
            if (nodeToRemove == null)
                return null;
            else
            {
                if (nodeToRemove.getLeft() != null)
                {
                    nodeToRemove.setLeft(removeMinimum(nodeToRemove.getLeft()));
                    return nodeToRemove;
                }
                else
                    return nodeToRemove.getRight();
            }
        }

        public Node<ADT> remove(ADT value)
        {
            return remove(root, value);
        }

        private Node<ADT> remove(Node<ADT> nodeToRemove, ADT value)
        {
            //If the root isn't null, then pass the node as a parameter
            //if the next node is null, then you reached the bottom of the left branch
            //and returns zero, then get to node right of the "current root" and do the
            //same thing, i.e., acess the left node untill you reached a null. Do this
            //for all children
            //e.g.
            //        8
            //       / \
            //      2   9
            //     / \
            //    1   5
            //       / \
            //      3   6
            //       \
            //        4
            //
            //Remove (2):
            //The root is (8). (8)>(2)? get left
            //      The root is (2). (2)>(2)?
            //      children of (2) are null? No
            //      find the lowest value in the right branch -> (3)
            //      set (3) as current root
            //      The root is (3). Remove the lowest in the right branch

            if (root == null)
                return null;
            else
            {
                //If the current roots value is greater then value, go to left child
                if (nodeToRemove.isGreaterThan(value))
                    nodeToRemove.setLeft(remove(nodeToRemove.getLeft(), value));
                else if (nodeToRemove.isLessThan(value))
                    //If the current roots value is less then value, go to right child
                    nodeToRemove.setRight(remove(nodeToRemove.getRight(), value));
                //So it is equal
                //if the node has a left and a right child, find the lowest 
                //value in the right branch of the node
                else if (nodeToRemove.getLeft() != null && nodeToRemove.getRight() != null)
                {
                    //temporary node that will find the miminum value
                    Node<ADT> temp = new Node<ADT>();
                    temp = findMinimum(nodeToRemove.getRight());
                    //setting the nodeToRemove with the minimum value
                    nodeToRemove.setData(temp.getData());

                    //Fixing the children
                    nodeToRemove.setRight(removeMinimum(nodeToRemove.getRight()));
                }
                else
                    nodeToRemove = (nodeToRemove.getLeft() != null) ? nodeToRemove.getLeft() : nodeToRemove.getRight();
                return nodeToRemove;
            }            
        }
    }
}