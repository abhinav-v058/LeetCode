using System;

namespace LC634LongestContinousSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            //normal
            Console.WriteLine(0 == p.FindLengthOfLCIS(new int[] {}));
            Console.WriteLine(1 == p.FindLengthOfLCIS(new int[] { 1 }));
            Console.WriteLine(3 == p.FindLengthOfLCIS(new int[] {1,3,5,4,7 }));
            Console.WriteLine(1 == p.FindLengthOfLCIS(new int[] { 2, 2, 2, 2, 2 }));
            Console.WriteLine(3 == p.FindLengthOfLCIS(new int[] { -5, -4, -3, -7, 0 }));
            //boundary
            Console.WriteLine(3 == p.FindLengthOfLCIS(new int[] { int.MinValue, -4, -3, -7, int.MaxValue }));
            Console.WriteLine(5 == p.FindLengthOfLCIS(new int[] { -5, -4, -3, -2, 0 }));
            //Special case
            Console.WriteLine(2 == p.FindLengthOfLCIS(new int[] { 2, 2, 3, 3, 3 }));

            Console.WriteLine(1 == p.FindLengthOfLCIS(new int[] { 2, 1 }));
            Console.WriteLine(1 == p.FindLengthOfLCIS(new int[] { 2, 1 },false));
            Console.ReadLine();
        }

        public int FindLengthOfLCIS(int[] nums)
        {
            int maxCount = 0, count = 0;            

            for (int i = 0; i < nums.Length; i++)
            {
                if (i==0||(i + 1 < nums.Length && nums[i] < nums[i + 1]))
                {
                    count = count + 1;                    
                }
                
                else
                {                    
                    count = 0;
                }

                if (maxCount < count)
                    maxCount = count;
            }

            return maxCount;
        }

        public int FindLengthOfLCIS(int[] nums, bool f)
        {
            int res = 0, cnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i - 1] < nums[i]) res = Math.Max(res, ++cnt);
                else cnt = 1;
            }
            return res;
        }
    }
}