using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<string> words = Console.ReadLine().Split(' ').ToList();
           
            int pos = 0;
            string temp = null;

            while(pos < words.Count)
            {
                
                temp = words[pos];
                int index = rand.Next(words.Count);
                words[pos] = words[index];
                words[index] = temp;
               
                pos++;
            }


            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

        }
    }
}
