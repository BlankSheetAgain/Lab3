using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
   public class Stack<T>
    {
        public DoublyLinkedList<T> Top { get; set; }

        public Stack()
        {
            Top = null;
        }

        public void Push()
        {
            DoublyLinkedList<T> newDoublyLinkedList = new();
            newDoublyLinkedList.Next = Top;
            Top = newDoublyLinkedList;
        }

        public void Pop()
        {
            if (Empty()) return;
            Top = Top.Next;
        }

        public bool Empty() => Top == null;
    }
}
