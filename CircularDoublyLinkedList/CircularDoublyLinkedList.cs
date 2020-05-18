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
            if (IsReadOnly)
            {
                throw new NotSupportedException("List is readonly!");
            }

            if (listNode == null)
            {
                throw new ArgumentNullException(nameof(listNode));
            }

            if (newListNode == null)
            {
                throw new ArgumentNullException(nameof(newListNode));
            }

            if (!ContainsNode(listNode))
            {
                throw new NotSupportedException("List does not contain given node!");
            }

            if (!ContainsNode(listNode) && (listNode.Next != null || listNode.Previous != null))
            {
                throw new InvalidOperationException("Node is already set");
            }

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

        public void AddAfter(Node<T> listNode, Node<T> newListNode)
        {
            AddInFront(listNode.Next, newListNode);
        }

        public void AddAfter(Node<T> listNode, T item)
        {
            Node<T> newNode = new Node<T>(item);
            AddInFront(listNode.Next, newNode);
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException("List is readonly!");
            }

            Count = 0;
        }

        public bool Contains(T item)
        {
            return Find(item) != null;
        }

        public Node<T> Find(T element)
        {
            var enumerable = GetNodesFromStart();
            return SearchNode(element, enumerable);
        }

        public Node<T> FindLast(T element)
        {
            var enumerable = GetNodesFromEnd();
            return SearchNode(element, enumerable);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), message: "Invalid index");
            }

            if (array.Length - arrayIndex < Count)
            {
                throw new ArgumentException("The number of elements in List is greater than the available space from" + nameof(arrayIndex) + "to the end of the destination array");
            }

            var enumerator = GetEnumerator();
            for (int i = arrayIndex; i < Count + arrayIndex; i++)
            {
                enumerator.MoveNext();
                array[i] = enumerator.Current;
            }
        }

        public bool Remove(T item)
        {
            return RemoveAt(Find(item));
        }

        public bool RemoveAt(Node<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (!ContainsNode(node))
            {
                throw new NotSupportedException("List does not contain given node!");
            }

            if (IsReadOnly)
            {
                throw new NotSupportedException("List is readonly!");
            }

            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            node.Connect();
            Count--;
            return true;
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

        private Node<T> SearchNode(T element, IEnumerable<Node<T>> nodeToFind)
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

        private bool ContainsNode(Node<T> listNode)
        {
            return listNode.List == this;
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
