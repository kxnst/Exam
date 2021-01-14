using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadnyk
{
    class Menu
    {
        public static void RunListImpl()
        {
            Random e = new Random();
            Node node = new Node(e.Next(0, 100));
            Node last = node;
            for(int i  = 0; i < 10; i++)
            {
                Node t = new Node(e.Next(0, 100));
                t.Prev = last;
                if (last.Prev!=null)
                {
                    last.Prev.Next = last;
                }
                last = t;
            }
            ListImpl list = new ListImpl(node);
            Console.WriteLine("Init");
            foreach (Node r in list)
            {
                Console.Write(r.Container+"    ");
            }
            Console.WriteLine();
            Console.WriteLine("Added element");
            list.Add(new Node(1337));
            foreach(Node r in list)
            {
                Console.Write(r.Container + "    ");
            }
            Console.WriteLine();
            Console.WriteLine("Deleted element");

            list.Delete(new Node(1337));
            foreach (Node r in list)
            {
                Console.Write(r.Container + "    ");
            }
            Console.WriteLine();
            Console.WriteLine("List Cleared");
            list.Clear();
            foreach (Node r in list)
            {
                Console.Write(r.Container + "    ");
            }
            return;
        }
    }
}
