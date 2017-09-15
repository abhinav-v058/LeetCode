using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeWeeklyContest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            Program.test('a',p.FindTheDifference("a", "aa"));
            Program.test('e', p.FindTheDifference("abcd", "abcde"));

            Console.ReadLine();
        }

        public char FindTheDifference(string s, string t)
        {

            Dictionary<char, int> unique = new Dictionary<char, int>();

            for (int i = 0; i < t.Length; i++)
            {
                if (unique.ContainsKey(t[i]))
                   unique[t[i]]++;
                else
                    unique.Add(t[i], 1);
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (unique.ContainsKey(s[i]))
                {
                    unique[s[i]]--;
                }
                else
                    return s[i];
            }

            for (int i = 0; i < unique.Count; i++)
            {
                if (unique.ElementAt(i).Value > 0)
                    return unique.ElementAt(i).Key;
            }

            return ' ';
        }

        public static bool test(char expected, char output)
        {
            bool temp = expected == output;

            if (temp)
                Console.WriteLine("Passed");
            else
                Console.WriteLine("Fail");

            return temp;
        }
    }
}