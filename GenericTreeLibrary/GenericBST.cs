using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericQueueLibrary;

namespace GenericTreeLibrary {

    /// <summary>
    /// GenericBST class defines functionality of binary search tree for generic data type T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class GenericBST<T> {

        /// <summary>
        /// Default constructor initializes an empty tree
        /// </summary>
        public GenericBST() {
            this.root = null;
            this.size = 0;
            this.recursiveSearchFound = false;
        }


        /// <summary>
        /// Traverses tree to appropriate leaf position and inserts new TreeNode into tree
        /// </summary>
        /// <param name="value"></param>
        public void insert(T value) {
            //create new node
            TreeNode<T> newNode = new TreeNode<T>(value);
            size++;
            //start traversing at root
            TreeNode<T> current = root;
            //traverse tree to appropriate node
            while (current != null) {
                //if current tree node value is greater than value being inserted, traverse left
                if (TreeNode<T>.isGreaterThan(current.value, value)) {
                    //if left child is not a leaf node, traverse to left child
                    if (current.leftChild != null) {
                        current = current.leftChild;
                    }
                    //else, assign new node to left child
                    else {
                        current.leftChild = newNode;
                        newNode.parent = current;
                        return;
                    }
                }
                //if current tree node value is less than or qual to value being inserted, traverse right
                else if ((TreeNode<T>.isLessThan(current.value, value) ||
                    (TreeNode<T>.isEqual(current.value, value)))) {
                    //if right child isn't null, traverse right
                    if (current.rightChild != null) {
                        current = current.rightChild;
                    }
                    //else assign new node to right child
                    else {
                        current.rightChild = newNode;
                        newNode.parent = current;
                        return;
                    }
                }
            }
            //if current is null, then it must be the root!
            root = newNode;
            return;
        }

        /// <summary>
        /// Remove node from BST and re-arrange tree as required to maintain tree structure
        /// </summary>
        /// <param name="value"></param>
        public void delete(T value) {
            //TODO
        }

        /// <summary>
        /// Iteratively search tree for T value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>TreeNode with T value</returns>
        public TreeNode<T> search(T value) {
            //start at root
            TreeNode<T> current = root;
            //while there are more nodes to search, continue to traverse
            while (current != null) {
                if (TreeNode<T>.isEqual(value, current.value)) {
                    return current;
                }
                else if (TreeNode<T>.isLessThan(value, current.value)) {
                    current = current.leftChild;
                }
                else {
                    current = current.rightChild;
                }
            }
            return current;
        }


        /// <summary>
        /// Traverse Tree in Pre-Order manner and print nodes as encountered
        /// </summary>
        /// <param name="root"></param>
        public void preOrderTraversal(TreeNode<T> root) {
            if (root != null) {
                Console.Write(root.value + ", ");
                if (root.leftChild != null) {
                    preOrderTraversal(root.leftChild);
                }
                if (root.rightChild != null) {
                    preOrderTraversal(root.rightChild);
                }
            }
        }


        /// <summary>
        /// Traverse Tree in In-Order manner and print nodes as encountered
        /// </summary>
        /// <param name="root"></param>
        public void inOrderTraversal(TreeNode<T> root) {
            if(root != null) {
                inOrderTraversal(root.leftChild);
                Console.Write(root.value + ", ");
                inOrderTraversal(root.rightChild);
            }
        }


        /// <summary>
        /// Traverse tree in post order manner and print nodes as encountered
        /// </summary>
        /// <param name="root"></param>
        public void postOrderTraversal(TreeNode<T> root) {
            if(root != null) {
                postOrderTraversal(root.leftChild);
                postOrderTraversal(root.rightChild);
                Console.Write(root.value + ", ");
            }
        }

        /// <summary>
        /// Print tree node values as encountered in breadth first search
        /// </summary>
        public void breadthFirstTraversal(TreeNode<T> root) {
            // Uses a queue to traverse tree
            GenericQueue<TreeNode<T>> queue = new GenericQueue<TreeNode<T>>();
            // Enqueue root
            if (root != null) {
                queue.enqueue(root);
            }
            //print elements while queue is not empty
            while (!queue.isEmpty()) {
                //dequeue element from queue
                TreeNode<T> current = queue.dequeue();
                Console.Write(current.value + ", ");
                //if left child exists, add it to queue
                if (current.leftChild != null) {
                    queue.enqueue(current.leftChild);
                }
                //if right child exists, add it to queue
                if (current.rightChild != null) {
                    queue.enqueue(current.rightChild);
                }
            }
        }


        public TreeNode<T> root { get; set; }
        public int size { get; private set; }
        private bool recursiveSearchFound;
    }
}
