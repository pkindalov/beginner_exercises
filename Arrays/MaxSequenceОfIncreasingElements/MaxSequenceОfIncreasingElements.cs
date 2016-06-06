using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceОfIncreasingElements
{
    class MaxSequenceОfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string sequence = string.Empty;
            int seq = 0;
            int currentSeq = 0;


            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i - 1] - 1 < nums[i])
                {
                    currentSeq++;

                }
                if (currentSeq > seq)
                {
                    seq = currentSeq;
                    sequence += " " + nums[i - 1];
                }

            }


            Console.WriteLine(sequence);


        }
    }
}
