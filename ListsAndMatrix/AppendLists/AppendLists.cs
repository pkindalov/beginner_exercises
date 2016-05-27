using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {

            var lists = Console.ReadLine().Split('|').ToList();
           // var result = new List<string>();

            for (int i = lists.Count - 1; i >= 0 ; i--)
            {
                //Console.WriteLine(lists[i].Trim());
                var currentList = lists[i].Split(' ');

                foreach (var item in currentList)
                {
                    if (item != "")
                    {
                        Console.Write(item);
                       // result.Add(item);
                    }
                    
                }
            }




        }
    }
}
