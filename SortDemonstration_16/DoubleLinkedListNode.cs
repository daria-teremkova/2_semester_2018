using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DoubleLinkedListNode
    {
        public DoubleLinkedListNode Prev;
        public DoubleLinkedListNode Next;

        public int Value;

        public DoubleLinkedListNode(int value, DoubleLinkedListNode prev = null, DoubleLinkedListNode next = null)
        {
            this.Value = value;
            this.Prev = prev;
            this.Next = next;
        }
    }
}
