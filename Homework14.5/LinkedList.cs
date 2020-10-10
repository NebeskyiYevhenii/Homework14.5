using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework14._5
{

    public class Node
    {
        public string Name { get; set; }
        public Node Next { get; set; }
        public Node(string name)
        {
            Name = name;
        }
    }
    public class LinkedList<T> : IEnumerable<string>
    {
        Node head;
        Node tail;
        int count;

        public delegate void DeleteAndAddToNewLinkedList(string name);

        public event DeleteAndAddToNewLinkedList DeleteNode;
        public void OnDeleteItem(string name)
        {
            DeleteNode?.Invoke(name);
        }

        public void AddByIndex(string name, int index)
        {
            Node newNode = new Node(name);
            Node node = head;
            Node previous = null;
            int i = 1;

            while (i <= count)
            {
                if (i == index)
                {
                    previous.Next = newNode;
                    newNode.Next = node;
                    break;
                }
                previous = node;
                node = node.Next;
                i++;
            }
            count++;
        }

        public void AddToEnd(string name)
        {
            Node node = new Node(name);

            if (head == null)
            {
                head = node;
            }
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public void AddToStart(string name)
        {
            Node node = new Node(name);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.Next = head;
                head = node;
                count++;
            }
        }

        public bool Delete(string name)
        {
            DeleteAndAddToNewLinkedList deleteAndAddToNewLinkedList = AddToEnd;

            Node item = head;
            Node previous = null;
            bool Return = false;
            if (head != null)
            {
                while (item != null)
                {
                    if (item.Name.Equals(name))
                    {
                        previous.Next = item.Next;
                        count--;
                        Return = true;
                        OnDeleteItem(name);
                    }
                    previous = item;
                    item = item.Next;
                }
                return Return;
            }
            return false;
        }

        public LinkedList<T> Filter(Node node)
        {
            LinkedList<T> LL = new LinkedList<T>();
            Node item = head;
            Node previous = null;

            if (head != null)
            {
                while (item != null)
                {
                    if (item.Name.Equals(node.Name))
                    {
                        previous.Next = item.Next;
                        count--;
                    }
                    previous = item;
                    item = item.Next;
                }
                return LL;
            }
            return LL;
        }

        public Node this[int index]
        {
            set
            {
                Node node = head;
                int i = 1;

                while (i <= index)
                {
                    if (i == index)
                    {
                        node = value;
                    }
                    node = node.Next;
                    i++;
                }
            }
            get
            {

                Node indexNode = head;
                Node node = head;
                Node previous = null;
                int i = 1;

                while (i <= index)
                {
                    if (i == index)
                    {
                        return node;
                    }
                    previous = node;
                    node = node.Next;
                    i++;
                }

                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Name;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

    }

}
