using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayТoNumber
{
    class CondenseArrayТoNumber
    {
        static void Main(string[] args)
        {

            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (n.Length > 1)
            {
                int[] cond = new int[n.Length - 1];
                int prev = 0;

                for (int i = 0; i < n.Length - 1; i++)
                {

                    //for (int j = i + 1; j < n.Length - 1; j++)
                    //{
                    //    cond[i] = n[prev] + n[j];
                    //    prev = cond[i];

                    //}

                    cond[i] = n[i] + n[i + 1];

                    //cond[i] = n[prev] + n[i + 1];
                    //prev = cond[i];



                    //int prev = n[i];
                    //int next = n[i + 1];
                    //int temp = 0;

                    //cond[i] = prev + next;
                    //prev = cond[i];


                    //cond[i] = n[i] + n[i + 1];
                    //int temp = cond[i];
                    //n[i] = n[i + 1];
                    //n[i + 1] = temp;


                   
                }

                n = cond;


            }

            
            Console.WriteLine(n[0]);
            


        }
    }
}
