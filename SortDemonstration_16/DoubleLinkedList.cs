using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DoubleLinkedList
    {
        private DoubleLinkedListNode head = null;
        private DoubleLinkedListNode tail = null;

        private int size = 0;

        public DoubleLinkedListNode Head {
            get
            {
                return head;
            }
            set
            {
                this.head = value;
            }
        }

        public bool Empty
        {
            get
            {
                return size == 0;
            }
        }

        public int Length
        {
            get
            {
                return size;
            }
        }

        public DoubleLinkedList()
        {

        }

        public DoubleLinkedList(int[] arr)
        {
            foreach (int value in arr)
                Add(value);
        }

        public void AddToHead(DoubleLinkedListNode node)
        {
            node.Next = head;
            head.Prev = node;
            head = node;
            this.size++;
        }

        public void Add(int value)
        {
            Add(new DoubleLinkedListNode(value));
        }

        public void AddAfter(DoubleLinkedListNode after, DoubleLinkedListNode node)
        {
            after.Next = node;
            node.Prev = after;
            size++;
        }

        public void Add(DoubleLinkedListNode node)
        {
            if (head == null)
            {
                head = tail = node;
                size++;
                return;
            }

            node.Prev = tail;
            tail.Next = node;
            tail = tail.Next;
            size++;
        }

        public int[] ToArray()
        {
            int arrPtr = 0;
            int[] arr = new int[this.size];

            DoubleLinkedListNode currentNode = head;

            while (currentNode != null)
            {
                arr[arrPtr++] = currentNode.Value;
                currentNode = currentNode.Next;
            }

            return arr;
        }
    }
}
