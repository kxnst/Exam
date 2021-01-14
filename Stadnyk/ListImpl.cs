using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadnyk
{
    class ListImpl : IList
    {
        private Node _start;

        private Node _end;


        public Node Start { get => _start; set => _start = value; }
        public Node End { get => _end; set => _end = value; }

        public ListImpl(Node start)
        {
            Start = start;
            End = start;
            if (End.Next == null)
                return;
            Node tmp = start;
            while ((tmp = tmp.Next) != null)
                End = tmp;
        }
        public void Add(Node t)
        {
            End.Next = t;
            t.Prev = End;
            End = t;
        }

        public void Clear()
        {
            Start = null;
            End = null;
        }

        public void Delete(Node t)
        {
            Node tmp = Start;
            while (tmp != null)
            {
                if (tmp.Container.Equals(t.Container))
                {
                    bool check = false;
                    if (tmp.Prev == null)
                    {
                        check = true;
                        Start = tmp.Next;
                        tmp.Prev = null;
                    }
                    if(tmp.Next == null)
                    {
                        check = true;                    
                        End = tmp.Prev;
                        End.Next = null;
                    }
                    if (!check)
                    {
                        tmp.Prev.Next = t;
                        tmp.Next.Prev = t;
                    }
                }
                tmp = tmp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new NodeEnumerator(Start);
        }
    }
}
