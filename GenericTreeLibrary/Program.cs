using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTreeLibrary {
    class Program {
        static void Main(string[] args) {

            GenericBST<int> intBST = new GenericBST<int>();
            intBST.insert(55);
            intBST.insert(10);
            intBST.insert(80);
            intBST.insert(75);
            intBST.insert(12);
            intBST.insert(4);
            intBST.insert(5);
            intBST.insert(99);

            Console.WriteLine("\nPrinting Breadth First");
            intBST.breadthFirstTraversal(intBST.root);
            Console.WriteLine("\nPrinting Pre Order Traversal");
            intBST.preOrderTraversal(intBST.root);
            Console.WriteLine("\nPrinting In Order Traversal");
            intBST.inOrderTraversal(intBST.root);
            Console.WriteLine("\nPrinting Post Order Traversal");
            intBST.postOrderTraversal(intBST.root);

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();

            
        }
    }
}
