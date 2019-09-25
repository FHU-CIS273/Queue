using System;
using System.Collections.Generic;

namespace Queue
{
    public class Queue<T>
    {
        LinkedList<T> linkedList;

        public Queue()
        {
            linkedList = new LinkedList<T>();
        }

        public int Length => linkedList.Count;

        public void Add(T item)
        {
            linkedList.AddLast(new LinkedListNode<T>(item));
        }

        public T Remove()
        {
            if( IsEmpty )
            {
                // throw and exception
                return default(T);
            }

            T item = linkedList.First.Value;
            linkedList.RemoveFirst();

            return item;
        }

        public bool IsEmpty
        {
            get
            {
                return (linkedList.Count == 0);
            }
        }

        public T Front
        {
            get
            {
                if (IsEmpty)
                {
                    // throw and exception
                    return default(T);
                }

                return linkedList.First.Value;
            }
        }

        public T Back
        {
            get
            {
                if (IsEmpty)
                {
                    // throw and exception
                    return default(T);
                }

                return linkedList.Last.Value;
            }
        }
    }
}
