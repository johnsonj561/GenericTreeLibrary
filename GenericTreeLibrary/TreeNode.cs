using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTreeLibrary {
    /// <summary>
    /// TreeNode object encapsulates value, and parent/child pointers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class TreeNode<T> {

        /// <summary>
        /// Constructor assigns value to node and initializes pointers to null
        /// </summary>
        /// <param name="value"></param>
        public TreeNode(T value) {
            this.value = value;
            this.parent = this.leftChild = this.rightChild = null;
        }


        /// <summary>
        /// Compares the values from two TreeNode objects and returns true if value1 < value2
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns>true if value1 < value2</returns>
        public static bool isLessThan(T value1, T value2) {
            var v1 = value1 as IComparable;
            var v2 = value2 as IComparable;
            if((v1.CompareTo(v2) < 0)){
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compares the values from two TreeNode objects and returns true if value1 > value2
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns>true if value1 > value2</returns>
        public static bool isGreaterThan(T value1, T value2) {
            var v1 = value1 as IComparable;
            var v2 = value2 as IComparable;
            if ((v1.CompareTo(v2)) > 0) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compares the values from two TreeNode objects and returns true if value1 == value2
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns>true if value1 == value2</returns>
        public static bool isEqual(T value1, T value2) {
            var v1 = value1 as IComparable;
            var v2 = value2 as IComparable;
            if((v1.CompareTo(v2)) == 0) {
                return true;
            }
            return false;
        }


        public TreeNode<T> parent { get; set; }
        public TreeNode<T> leftChild { get; set; }
        public TreeNode<T> rightChild { get; set; }
        public T value { get; private set; }

       

    }


}
