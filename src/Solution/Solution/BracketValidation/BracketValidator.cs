using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class StackNode
        {
            public char Data;
            public StackNode? Next;

            public StackNode(char data)
            {
                Data = data;
                Next = null;
            }
        }

        private StackNode? top;

        private void Push(char ch)
        {
            StackNode newNode = new StackNode(ch);
            newNode.Next = top;
            top = newNode;
        }

        private char Pop()
        {
            if (top == null) return '\0';
            char data = top.Data;
            top = top.Next;
            return data;
        }

        public bool ValidasiEkspresi(string ekspresi)
        {
            foreach (char ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    char popped = Pop();
                    if ((ch == ')' && popped != '(') ||
                        (ch == '}' && popped != '{') ||
                        (ch == ']' && popped != '['))
                    {
                        return false;
                    }
                }
            }
            return top == null;
        }
    }
}
