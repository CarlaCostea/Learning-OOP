using System;
using System.Collections;
using System.Collections.Generic;

namespace CircularDoublyLinkedList
{
    public class CircularDoublyLinkedList<T> : ICollection<T>
    {
        private readonly Node<T> sentry;

        public CircularDoublyLinkedList()
        {
            Count = 0;
            sentry = new Node<T>(default) { List = this };
            sentry.Connect(sentry, sentry);
        }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public Node<T> Head
        {
            get
            {
                return Count == 0 ? null : sentry.Next;
            }
        }

        public Node<T> Tail
        {
            get
            {
                return Count == 0 ? null : sentry.Previous;
            }
        }

        public void Add(T item)
        {
            AddInFront(sentry, new Node<T>(item));
        }

        public void AddInFront(Node<T> listNode, Node<T> newListNode)
        {
            listNode.Previous.Next = newListNode;
            newListNode.Connect(previous: listNode.Previous, next: listNode);
            listNode.Previous = newListNode;
            newListNode.List = this;
            Count++;
        }

        public void AddInFront(Node<T> listNode, T item)
        {
            AddInFront(listNode, new Node<T>(item));
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Count = 0;
        }

        public bool Contains(T item)
        {
            return Find(item) != null;
        }

        public Node<T> Find(T element)
        {
            var enumerable = GetNodesFromStart();
            return SearchCircularDoublyLinkedList(element, enumerable);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var enumerator = GetEnumerator();
            for (int i = arrayIndex; i < Count + arrayIndex; i++)
            {
                enumerator.MoveNext();
                array[i] = enumerator.Current;
            }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (Node<T> i = sentry.Next; i != sentry; i = i.Next)
            {
                yield return i.Data;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private bool RemoveItem(Node<T> node)
        {
            if (node == null)
            {
                return false;
            }

            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            node.Connect();
            Count--;
            return true;
        }

        private Node<T> SearchCircularDoublyLinkedList(T element, IEnumerable<Node<T>> nodeToFind)
        {
            foreach (var node in nodeToFind)
            {
                if (CheckForNull(node, element)
                    || node.Data?.Equals(element) == true)
                {
                    return node;
                }
            }

            return null;
        }

        private bool CheckForNull(Node<T> node, T value)
        {
            return node.Data == null && value == null;
        }

        private IEnumerable<Node<T>> GetNodesFromStart()
        {
            for (Node<T> i = sentry.Next; i != sentry; i = i.Next)
            {
                yield return i;
            }
        }

        private IEnumerable<Node<T>> GetNodesFromEnd()
        {
            for (Node<T> i = sentry.Previous; i != sentry; i = i.Previous)
            {
                yield return i;
            }
        }
    }
}
