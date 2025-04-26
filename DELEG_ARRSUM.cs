using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEG_ARRSUM
{
    internal class Program
    {
        delegate int SumArray(int[] numbers);
        static void Main()
        {
            SumArray sum = delegate (int[] nums)
            {
                int total = 0;
                foreach (int num in nums)
                {
                    total += num;
                }
                return total;
            };
            int[] arr = { 10, 11, 19, 8, 4 };
            Console.WriteLine($"sum array: {sum(arr)}");
        }
    }


}
