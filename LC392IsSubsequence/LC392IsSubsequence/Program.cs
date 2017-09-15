using System;

namespace LC392IsSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            Console.WriteLine(p.IsSubsequence("abe", "abcde"));
            Console.WriteLine(p.IsSubsequence("aec", "abcde"));
            Console.WriteLine(p.IsSubsequence("aaa", "aaaaaa"));
            Console.WriteLine(p.IsSubsequence("aaaaaa,", "aa"));
            Console.ReadLine();
        }

        public bool IsSubsequence(string s, string t)
        {
            if (s.Length < t.Length)
            {
                int j = 0;
                for (int i = 0; i < t.Length; i++)
                {
                    if (j < s.Length)
                    {
                        if (t[i] == s[j])
                            j++;
                    }
                    else
                        break;
                }

                if (j == s.Length)
                    return true;
                else
                    return false;
            }

            return false;
        }
    }
}