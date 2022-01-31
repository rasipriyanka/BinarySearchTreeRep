//------------------Dependencies-----------------------//
using System;
using System.Collections.Generic;
using System.Text;
// ---------------------Namespaces-----------------///
namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        //-------------Creating the Constructor And Initializing the Values----//
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        //----------Insert Method is used to Insert Elements Into Binary Tree------//

        //------Insert Method Starts-----------------//
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item))>0)
            {
                if (this.LeftTree == null)
                    this.LeftTree=new BinarySearchTree<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree=new BinarySearchTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }
        //------------Insert Method Ends-------------------//

        //--------Display Method Is Used To Display Elements In the Tree--------//
        //---------Display Method Starts----------------//
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
        //---------Display Method Ends-----------------//
        //--------------To Check or search the elements present in binary tree ---------//
        public bool IfExists(T element, BinarySearchTree<T> node) 
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST"+" " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST ", node.NodeData);

            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists((T)element, node.RightTree);
            }
            return result;
        }
    }
}
   

