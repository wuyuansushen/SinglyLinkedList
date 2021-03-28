using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
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

}
