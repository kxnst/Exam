using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadnyk
{
    class Node
    {
        private Node _prev;

        public Node Prev { get => _prev; set => _prev = value;  }

        private Node _next;

        public Node Next { get => _next; set => _next = value; }

        private object _container;
        public object Container { get=>_container; set => _container = value; }
        #nullable enable
        public Node(int value,Node? prev = null, Node? next = null)
        {
            Container = value;
            Prev = prev;
            Next = next;
        }
    }
}
