using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    internal class Node
    {
        public int data;
        public Node left;
        public Node right;
        //--------- creating Constructor And Initializing Values------------//
        public Node(int d) 
        {
            data = d;
            left = null;
            right = null;
        }
    }
}

