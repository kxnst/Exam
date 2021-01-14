using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadnyk
{
    class NodeEnumerator : IEnumerator
    {
        private Node container;
        public NodeEnumerator(Node r) {
            container = r;
        }
        public object Current => container;

        public bool MoveNext()
        {
            if ((container == null) || (container.Next ==null))
            {
                return false;
            }
            else
            {
                container = container.Next;
                return true;
            }
        }

        public void Reset()
        {
            if(container.Prev == null)
            {
                return;
            }
            else
            {
                while (true)
                {
                    if (container.Prev != null)
                    {
                        container = container.Prev;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
