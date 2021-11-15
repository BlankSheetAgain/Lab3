using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public DoublyLinkedList<T> Next { get; set; }
        public DoublyLinkedList<T> Child { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Child = null;
            Next = null;
        }

        public bool Empty() => Head == null;
        public void AddFirstNode(T node)
        {
            Node<T> newNode = new(node);
            if (Empty()) Head = Tail = newNode;
            else
            {
                Head.Prev = newNode;
                newNode.Next = Head;
                Head = newNode;
            }
        }

        /*public void AddToAGivenPosition(T node, int position)
        {
            Node<T> newNode = new(node);
            if (position < 1)
            {
                Console.WriteLine("Позиция не может быть меньше 1");
            }
            else if (position == 1)
            {

            }
        }
        */

        public void AddLastNode(T node)
        {
            Node<T> newNode = new(node);
            if (Empty()) AddFirstNode(node);
            else
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
                Tail = newNode;
            }
        }

        public void DeleteFirstNode()
        {
            if (Empty()) return;
            else if (Head != Tail)
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            else
            {
                Head = Tail = null;
            }
        }

        public void DeleteLastNode()
        {
            if (Empty()) return;
            else if (Head != Tail)
            {
                Tail = Tail.Prev;
                Tail.Next = null;
            }
            else
            {
                Head = Tail = null;
            }
        }
    }
}
