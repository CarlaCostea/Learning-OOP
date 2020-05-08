﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class Node<T>
    {
        public Node()
        {
            Next = null;
            Previous = null;
        }

        public Node(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public T Value { get; set; }
    }
}
