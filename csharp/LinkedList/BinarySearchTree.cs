using System;
using System.Collections.Generic;

namespace Codebase.Trees
{
    public class Node
    {
        public int Key { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node()
        {
        }

        public Node(int key, Node left = null, Node right = null)
        {
            this.Key = key;
            this.Left = left;
            this.Right = right;
        }
    }

    public class Tree
    {
        private Node Root { get; set; }
        
        public void PreOrder()
        {
            Console.Write(nameof(PreOrder) + ": ");
            PreOrder(Root);
        }

        public void InOrder()
        {
            Console.Write(nameof(InOrder) + ": ");
            InOrder(Root);
        }

        public void PostOrder()
        {
            Console.Write(nameof(PostOrder) + ": ");
            PostOrder(Root);
        }

        public void Insert(int key)
        {
            Root = Insert(Root, key);
        }

        public Node Search(int key)
        {
            Node item = Search(Root, key);
            return item;
        }



        #region private methods
        private Node Search(Node node, int key)
        {
            if (node == null || node.Key == key)
                return node;

            if (key < node.Key)
                return Search(node.Left, key);
            else
                return Search(node.Right, key);
        }

        private void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Key + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
             }
        }

        
        private void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Key + " ");
                InOrder(node.Right);
            }
        }

        private void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Key + " ");
            }
        }
        
        private Node Insert(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
                return node;
            }

            if (data < node.Key)
                node.Left = Insert(node.Left, data);
            else
                node.Right = Insert(node.Right, data);

            return node;
        }
        #endregion
    }
}
