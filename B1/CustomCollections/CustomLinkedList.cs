using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class CustomLinkedList<T> : ICustomCollection<T>, IEnumerable<T>
    {
        private LinkedNode<T> head;
        private LinkedNode<T> tail;
        private int length = 0;

        public void Add(T value)
        {
            LinkedNode<T> newNode = new LinkedNode<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            length++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var h = head;
            var t = tail;
            if (h == null) yield break;
            while (h != t)
            {
                yield return h.Value;
                h = h.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Size
        {
            get
            {
                return length;
            }
        }
    }
}
