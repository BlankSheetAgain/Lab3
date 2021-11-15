using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Node <T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T data1)
        {
            Next = null;
            Prev = null;
            Data = data1;
        }
    }
}
