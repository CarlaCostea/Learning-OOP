using System;
using System.Collections;
using System.Collections.Generic;

namespace CircularDoublyLinkedList
{
    public class CircularDoublyLinkedList<T> : ICollection<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int Count;

        public CircularDoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public CircularDoublyLinkedList(T value)
        {
            Head = new Node<T>(value);
            Tail = new Node<T>(value);
            Head.Previous = Head;
            Head.Next = Head;
            Tail = Head;
            Count = 1;
        }

        int ICollection<T>.Count => Count;

        bool ICollection<T>.IsReadOnly => false;

        public void Add(T item)
        {
            Count++;
            if (Count == 0)
            {
                Head = new Node<T>(item);
                Tail = Head;
                Head.Previous = Head;
                Head.Next = Head;
                Tail = Head;
            }
            else
            {
                Node<T> newNode = new Node<T>(item);

                newNode.Next = Head;
                newNode.Previous = Tail;

                Head.Previous = newNode;
                Tail.Next = newNode;
                Tail = Tail.Next;
            }
        }

        public void AddToFront(T value)
        {
            if (Count == 0)
            {
                Head = new Node<T>(value);
                Tail = Head;
                Head.Previous = Head;
                Head.Next = Head;
                Tail = Head;
            }
            else
            {
                Node<T> newNode = new Node<T>(value);
                newNode.Next = Head;
                newNode.Previous = Tail;

                Head.Previous = newNode;
                Tail.Next = newNode;
                Head = Head.Previous;
            }

            Count++;
        }

        public bool AddAt(int position, T value)
        {
            if (Count < position)
            {
                return false;
            }
            else if (position == 0)
            {
                AddToFront(value);
                return true;
            }
            else if (position == Count)
            {
                Add(value);
                return true;
            }
            else
            {
                Node<T> prev = Head;
                Node<T> next;
                for (int i = 0; i < position - 1; i++)
                {
                    prev = prev.Next;
                }

                var newNode = new Node<T>(value);
                if (prev == Head)
                {
                    Head = newNode;
                }

                if (prev == Tail)
                {
                    Tail = newNode;
                }

                next = prev.Next;
                prev.Next = newNode;
                next.Previous = newNode;
                newNode.Previous = prev;
                newNode.Next = next;

                Count++;
                return true;
            }
        }

        public bool RemoveFromFront()
        {
            if (IsEmpty())
            {
                return false;
            }
            else if (Count == 1)
            {
                Head = null;
                Count--;
                Tail = Head;
                return true;
            }
            else
            {
                Head = Head.Next;
                Head.Previous = Tail;
                Tail.Next = Head;
                Count--;
                return true;
            }
        }

        public bool RemoveFromEnd()
        {
            if (IsEmpty())
            {
                return false;
            }
            else if (Count == 1)
            {
                RemoveFromFront();
                return true;
            }
            else
            {
                Tail = Tail.Previous;
                Tail.Next = Head;
                Head.Previous = Tail;
                Count--;
                return true;
            }
        }

        public bool RemoveAt(int position)
        {
            if (Count - 1 < position)
            {
                return false;
            }
            else if (position == 0)
            {
                RemoveFromFront();
                return true;
            }
            else if (position == Count - 1)
            {
                RemoveFromEnd();
                return true;
            }
            else
            {
                var current = Head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }

                if (current.Next == Head)
                {
                    Head = current.Next.Next;
                }

                if (current.Next == Tail)
                {
                    Tail = current;
                }

                current.Next = current.Next.Next;
                current.Next.Previous = current;

                Count--;
                return true;
            }
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            while (!IsEmpty())
            {
                RemoveFromEnd();
            }
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
