using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueLibrary {
    class GenericQueue<T> {

        /// <summary>
        /// Constructor creates an empty queue
        /// </summary>
        public GenericQueue() {
            front = back = null;
            size = 0;
        }

        /// <summary>
        /// Enqueue inserts Node with T value into back of queue
        /// </summary>
        /// <param name="value"></param>
        public void enqueue(T value) {
            QueueNode<T> newNode = new QueueNode<T>(value);
            size++;
            //if this is first element
            if (size == 1) {
                front = back = newNode;
                return;
            }
            //else, insert into back
            back.prevNode = newNode;
            back = newNode;
        }


        /// <summary>
        /// Remove element from the front of the queue
        /// </summary>
        /// <returns>Element from front of queue</returns>
        public T dequeue() {
            if (!isEmpty()) {
                T returnValue = front.value;
                front = front.prevNode;
                size--;
                return returnValue;
            }
            Console.WriteLine("Error using dequeue method, Queue is empty.");
            return default(T);
        }


        /// <summary>
        /// Get value of queue's front element
        /// </summary>
        /// <returns>Value of front element</returns>
        public T getFront() {
            if (!isEmpty()) {
                return front.value;
            }
            Console.WriteLine("Error getting front of queue, Queue is empty.");
            return default(T);
        }


        /// <summary>
        /// Prints all elements of Queueue
        /// </summary>
        public void print() {
            QueueNode<T> current = front;
            Console.WriteLine("\nPrinting elements from queue");
            Console.Write("FRONT --> ");
            while (current != null) {
                Console.Write(current.value + " --> ");
                current = current.prevNode;
            }
            Console.Write("BACK");
        }


        public void clear() {
            //remove references to all nodes
            while(front != null) {
                front = front.prevNode;
                size--;
            }
        }

        /// <summary>
        /// Returns true if queue contains no elements
        /// </summary>
        /// <returns>True if queue is empty</returns>
        public Boolean isEmpty() {
            if(size > 0) {
                return false;
            }
            return true;
        }

    
        //class members
        public QueueNode<T> front { get; private set; }
        public QueueNode<T> back { get; private set; }
        private int size;
    }
}