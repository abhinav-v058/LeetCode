using System;

namespace LC390Contest2Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            /*
            Console.WriteLine(p.LastRemaining(10)==4);
            Console.WriteLine(p.LastRemaining(9) == 6);
            Console.WriteLine(p.LastRemaining(11) == 8);
            Console.WriteLine(p.LastRemaining(12) == 6);
            Console.WriteLine(p.LastRemaining(-3) == 0);
            Console.WriteLine(p.LastRemaining(1) == 1);
            Console.WriteLine(p.LastRemaining(2) == 2);
            Console.WriteLine(p.LastRemaining(3) == 2);
            Console.WriteLine(p.LastRemaining(6) == 4);
            Console.WriteLine(p.LastRemaining(5) == 2);
            */

            int n = 1;

            while (n != 0)
            {
                n = Convert.ToInt16(Console.ReadLine());

                p.LastRemaining(n);
            }

            // Console.ReadLine();
        }

        /*
        public int LastRemaining(int n)
        {
            if (n < 0)
                return 0;

            if (n <= 3)
            {
                switch (n)
                {
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                    case 3:
                        return 2;
                }                   
            }

            if (n <= 6)
            {
                if (n % 2 == 0)
                    return (n - 2);
                else
                    return (n - 3);
            }
            else
            {
                if (n % 2 == 0)
                    return (n - 6);
                else
                    return (n - 3);
            }
        }*/

        public int LastRemaining(int n)
        {
            bool left = true;
            int remaining = n;
            int step = 1;
            int head = 1;
            while (remaining > 1)
            {
                if (left || remaining % 2 == 1)
                {
                    head = head + step;
                }
                remaining = remaining / 2;
                step = step * 2;
                left = !left;

                Console.WriteLine("left = {0}\t remaining = {1}\t head = {2}\t step = {3} ", left, remaining, head, step);
            }
            return head;
        }
    }
}