using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
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

        static public void InsertTopNode(this LinkedList linked, Node insertNode)
        {
            insertNode.next = linked._sentinel.next;
            linked._sentinel.next = insertNode;
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
                linked._sentinel.next = linked._head;
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

        static public void InsertNode(this LinkedList linked,Node insertNode,Node afterNode)
        {
            Node currentNode = linked._sentinel;
            while(currentNode.next!=null)
            {
                currentNode = currentNode.next;
                if(currentNode==afterNode)
                {
                    insertNode.next = currentNode.next;
                    currentNode.next = insertNode;
                    return;
                }
                else { }
            }
            throw new Exception("LinkedList isn't contain this node.");
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

}
