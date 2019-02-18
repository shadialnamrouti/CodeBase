using System;
using System.Collections.Generic;

namespace Codebase.LinkedLists
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node()
        {
        }

        public Node(object Data, Node Next = null)
        {
            this.Data = Data;
            this.Next = Next;
        }
    }

    public class LinkedList
    {
        private Node Head { get; set; }

        public Node First
        {
            get => Head;
            set
            {
                First.Data = value.Data;
                First.Next = value.Next;
            }
        }

        public Node Last
        {
            get
            {
                Node node = Head;
                //Based partially on https://en.wikipedia.org/wiki/Linked_list
                while (node.Next != null)
                    node = node.Next; //traverse the list until p is the last node.The last node always points to NULL.

                return node;
            }
            set
            {
                Last.Data = value.Data;
                Last.Next = value.Next;
            }
        }

        public void AddFirst(Object data, bool verbose = true)
        {
            Head = new Node(data, Head);
            if (verbose) Print();
        }

        public void AddFirst(Node newHead, bool verbose = true)
        {
            newHead.Next = Head;
            Head = newHead;
            if (verbose) Print();
        }

        public void AddLast(Object data, bool Verbose = true)
        {
            Last.Next = new Node(data);
            if (Verbose) Print();
        }

        public Node RemoveFirst(bool verbose = true)
        {
            Node first = First;
            Head = First.Next;
            if (verbose) Print();
            return first;
        }

        public Node RemoveLast(bool verbose = true)
        {
            Node parent = Head;
            Node last = Last;

            while (parent.Next != last)
                parent = parent.Next;

            parent.Next = null;
            if (verbose) Print();

            return last;
        }

        public void AddAfter(Node parent, object data, bool verbose = true)
        {
            Node child = new Node()
            {
                Data = data,
                Next = parent.Next //it becomes the parent of the original child
            };

            parent.Next = child;

            if (verbose) Print();
        }

        public void AddBefore(Node child, object data, bool verbose = true)
        {
            Node parent = Head;

            while (parent.Next != child) //Finding the parent 
            {
                parent = parent.Next;
            }

            Node newParent = new Node
            {
                Data = data,
                Next = child //same as  = parent.Next
            };

            //Reattach the original parent to the new parent
            parent.Next = newParent;

            if (verbose) Print();
        }

        public Node Find(object data)
        {
            Node node = Head;

            while (node != null)
            {
                if (node.Data == data)
                    return node;

                node = node.Next;
            }
            return null;
        }

        public void Remove(Node child, bool verbose = true)
        {
            Node parent = Head;

            while (parent.Next != child)
            {
                parent = parent.Next;
            }

            parent.Next = child.Next; //jump over the node-to-be-removed
            if (verbose) Print();
        }

        public void Print()
        {
            Node node = Head;
            while (node != null) //LinkedList iterator
            {
                Console.Write(node.Data + " ");
                node = node.Next; //traverse the list until p is the last node.The last node always points to NULL.
            }
            Console.WriteLine();
        }
    }
}
