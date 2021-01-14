using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadnyk
{
    interface IContainer:IEnumerable
    {
        public Node Start { get; set; }

        public void Clear();
    }
}
