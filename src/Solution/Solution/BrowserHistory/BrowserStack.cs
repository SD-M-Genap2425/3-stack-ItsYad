using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    public class BrowserStack
    {
        private Node? top;

        public void KunjungiHalaman(string url)
        {
            var halaman = new Halaman(url);
            var node = new Node(halaman) { Next = top };
            top = node;
        }

        public string? Kembali()
        {
            if (top == null || top.Next == null) return null;
            top = top.Next;
            return top.Data.URL;
        }

        public string? LihatHalamanSaatIni() => top?.Data.URL;
    }
}
