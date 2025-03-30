using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    public class BrowserHistory
    {
        private class Node
        {
            public string URL;
            public Node? Next;

            public Node(string url)
            {
                URL = url;
                Next = null;
            }
        }

        private Node? top;

        public void KunjungiHalaman(string url)
        {
            Node newNode = new Node(url);
            newNode.Next = top;
            top = newNode;
        }

        public string? Kembali()
        {
            if (top == null || top.Next == null)
                return null;

            top = top.Next;
            return top.URL;
        }

        public string? LihatHalamanSaatIni()
        {
            return top?.URL;
        }

        public void TampilkanHistory()
        {
            Node? temp = top;
            int count = 1;
            while (temp != null)
            {
                Console.WriteLine($"{count}. {temp.URL}");
                temp = temp.Next;
                count++;
            }
        }
    }
}