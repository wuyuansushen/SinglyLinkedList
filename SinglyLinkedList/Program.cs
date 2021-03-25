using System;

namespace SinglyLinkedList
{
    public class LinkedList
    {
        public Node _sentinel { get; set; }

        public Node _head { get; set; }

        public LinkedList(int sentinelValue=default)
        {
            _sentinel = new Node(sentinelValue);
            _sentinel.next = _head;
        }

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
        static public Node FindNode(this LinkedList linked, int valueTar)
        {
            Node current = linked._head;
            while(current!=null)
            {
                if (current.N == valueTar)
                    return current;
                else
                {
                    current = current.next;
                }
            }
            return current;
        }

        static public Node FindNodeBefore(this LinkedList linked, int valueTar)
        {
            Node sentinel = linked._sentinel;
            //while (sentinel.next != null)
            do
            {
                if (sentinel.next.N == valueTar)
                    return sentinel;
                else
                {
                    sentinel = sentinel.next;
                }
            } while (sentinel.next != null);
            return null;
        
        }
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
