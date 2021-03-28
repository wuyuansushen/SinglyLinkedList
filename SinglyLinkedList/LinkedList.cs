using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class LinkedList
    {
        public Node _sentinel { get; set; }

        public Node _head { get; set; }

        public LinkedList(int sentinelValue=-1)
        {
            _sentinel = new Node(sentinelValue);
        }

    }
}
