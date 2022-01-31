using System;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //----------Creating  Object for the class------------------//
            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>(56);
            //-----------Inserting the values to the Binary tree--------//
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Display();
            binaryTree.GetSize();
            bool result = binaryTree.IfExists(67, binaryTree);
            Console.WriteLine(result);
        }
    }
}
