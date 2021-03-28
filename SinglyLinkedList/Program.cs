using System;

namespace SinglyLinkedList
{


    class Program
    {
        static void Main(string[] args)
        {
            LinkedList tmpList = new LinkedList();
            for(int i=0;i<=10;i++)
            {
                tmpList.AddNode(i);
            }
            Node findTo=tmpList.FindNode(5);
            tmpList.DeleteNode(findTo);
            tmpList.DisplayLinkedList();
        }
    }
}
