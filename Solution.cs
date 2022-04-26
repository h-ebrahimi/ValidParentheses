using System.Collections.Generic;
using System.Linq;

namespace ValidParantheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            char[] chLeft = { '{', '[', '(' };
            var sc = new Stack<char>();
            foreach (var c in s)
            {

                if (chLeft.Contains(c))
                {
                    sc.Push(c);
                    continue;
                }

                if (sc.Count == 0) return false;

                switch (sc.Pop())
                {
                    case '[' when c != ']':
                    case '(' when c != ')':
                    case '{' when c != '}':
                        return false;
                }
            }

            return sc.Count == 0;
        }
    }
}