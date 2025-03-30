using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    public class HistoryManager
    {
        private Stack<string> history = new Stack<string>();
        private string currentPage = null;

        public void KunjungiHalaman(string url)
        {
            if (currentPage != null)
                history.Push(currentPage);
            currentPage = url;
        }

        public string Kembali()
        {
            if (history.Count == 0)
                return "Tidak ada halaman sebelumnya.";

            currentPage = history.Pop();
            return currentPage;
        }

        public string LihatHalamanSaatIni()
        {
            return currentPage ?? "Tidak ada halaman saat ini.";
        }

        public void TampilkanHistory()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("Tidak ada riwayat halaman.");
                return;
            }

            foreach (var page in history.Reverse()) 
            {
                Console.WriteLine(page);
            }

            if (currentPage != null)
            {
                Console.WriteLine(currentPage);
            }
        }
    }
}
