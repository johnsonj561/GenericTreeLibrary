using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueLibrary {
    class QueueNode<T> {

        /// <summary>
        /// Constructor creates a new node with a value of type T 
        /// </summary>
        public QueueNode(T value) {
            this.value = value;
        }

        public QueueNode<T> prevNode { get; set; }
        public T value { get; private set; }
    }
}
