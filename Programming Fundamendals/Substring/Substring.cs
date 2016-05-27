using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Substring
    {
        
        public class Substring_broken
        {
            public static void Main()
            {
                string text = Console.ReadLine();
                int jump = int.Parse(Console.ReadLine());

                string search = "р";
                bool hasMatch = false;
                int offset = -1;
                int indexFound = 0;


                while (true)
                {
                    offset = text.IndexOf(search, offset + 1);

                    if (offset == -1)
                    {
                        break;
                    }
                    else if (offset > -1)
                    {
                        hasMatch = true;
                        indexFound = offset;
                        text = text.Substring(indexFound, jump + 1);
                    }
                   
                }


                
                Console.WriteLine(text);

                //for (int i = 0; i < text.Length; i++)
                //{
                //    if (text[i] == Search)
                //    {
                //        hasMatch = true;

                //        int endIndex = jump;

                //        if (endIndex > text.Length)
                //        {
                //            endIndex = text.Length;
                //        }

                //        string matchedString = text.Substring(i, endIndex);
                //        Console.WriteLine(matchedString);
                //        i += jump;
                //    }
                //}

                //if (!hasMatch)
                //{
                //    Console.WriteLine("no");
                //}
                //else
                //{
                //    Console.WriteLine(text);
                //}
            }
        }
    }

}
   