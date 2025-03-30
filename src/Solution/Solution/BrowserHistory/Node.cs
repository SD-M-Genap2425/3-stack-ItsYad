using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    public class Node
    {
        public Halaman Data;
        public Node? Next;
        public Node(Halaman data) => Data = data;
    }
}
