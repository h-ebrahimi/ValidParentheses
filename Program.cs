using System;

namespace ValidParantheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "([)]";
            Solution solution = new Solution();
            var res =solution.IsValid(s);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
