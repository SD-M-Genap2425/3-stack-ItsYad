using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BracketValidation
{
    internal class StackNode
    {
        public char Data;
        public StackNode? Next;
        public StackNode(char data) => Data = data;
    }

    internal class Stack
    {
        private StackNode? top;

        public void Push(char c)
        {
            var node = new StackNode(c) { Next = top };
            top = node;
        }

        public char Pop()
        {
            if (top == null) throw new InvalidOperationException("Stack kosong");
            char data = top.Data;
            top = top.Next;
            return data;
        }

        public bool IsEmpty() => top == null;

        public bool ValidasiEkspresi(string ekspresi)
        {
            foreach (char c in ekspresi)
            {
                if ("({[".Contains(c)) Push(c);
                else if (")}]".Contains(c))
                {
                    if (IsEmpty()) return false;
                    char pop = Pop();
                    if ((c == ')' && pop != '(') || (c == '}' && pop != '{') || (c == ']' && pop != '['))
                        return false;
                }
            }
            return IsEmpty();
        }
    }
}