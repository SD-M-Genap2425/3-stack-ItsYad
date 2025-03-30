using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            Stack<char> stack = new Stack<char>();
            string normalized = "";

            foreach (char ch in input.ToLower())
            {
                if (char.IsLetter(ch))
                {
                    normalized += ch;
                    stack.Push(ch);
                }
            }

            foreach (char ch in normalized)
            {
                if (stack.Pop() != ch)
                    return false;
            }
            return true;
        }
    }
}