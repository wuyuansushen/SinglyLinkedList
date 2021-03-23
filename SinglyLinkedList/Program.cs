using System;

namespace SinglyLinkedList
{
    public class LinkedList
    {

        public Node _head { get; set; }

    }

    public class Node
    {
        internal int N;
        internal Node next;

        public Node(int cons)
        {
            N = cons;
            next = null;
        }
    }


    public static class LinkedListExtensions
    {
        static public void AddNode(this LinkedList linked, int inN)
        {
            Node tmp = new Node(inN);

            Node loopNode;
            if (linked._head == null)
            {
                linked._head = tmp;
            }
            else
            {
                loopNode = linked._head;
                while (loopNode.next != null)
                {
                    loopNode = loopNode.next;
                }
                loopNode.next = tmp;
            }
        }
    

        static public void DisplayLinkedList(this LinkedList linked)
        {
            Node loopNode = linked._head;
            while(loopNode!=null)
            {
                Console.WriteLine(loopNode.N);
                loopNode = loopNode.next;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList tmpList = new LinkedList();
            for(int i=0;i<=10;i++)
            {
                tmpList.AddNode(i);
            }

            tmpList.DisplayLinkedList();
        }
    }
}
