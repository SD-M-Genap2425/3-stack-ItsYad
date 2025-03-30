using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        var browserHistory = new BrowserHistory.BrowserHistory();
        browserHistory.KunjungiHalaman("google.com");
        browserHistory.KunjungiHalaman("example.com");
        browserHistory.KunjungiHalaman("stackoverflow.com");
        Console.WriteLine($"Halaman saat ini: {browserHistory.LihatHalamanSaatIni()}");
        browserHistory.Kembali();
        Console.WriteLine($"Halaman saat ini setelah kembali: {browserHistory.LihatHalamanSaatIni()}");
        browserHistory.TampilkanHistory();

        // Bracket validator
        var validator = new BracketValidator();
        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";
        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {validator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {validator.ValidasiEkspresi(ekspresiInvalid)}");

        // Palindrome Checker
        string palindrome1 = "Kasur ini rusak";
        string palindrome2 = "Ibu Ratna antar ubi";
        string notPalindrome = "Hello World";
        Console.WriteLine($"'{palindrome1}' adalah palindrom? {PalindromeChecker.CekPalindrom(palindrome1)}");
        Console.WriteLine($"'{palindrome2}' adalah palindrom? {PalindromeChecker.CekPalindrom(palindrome2)}");
        Console.WriteLine($"'{notPalindrome}' adalah palindrom? {PalindromeChecker.CekPalindrom(notPalindrome)}");
    }
}
