using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsSorting
{
    class HogwartsSorting
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            
            string[] names = new string[count];
            int sum = 0;

            int GryffindorCount = 0;
            int SlytherinCount = 0;
            int RavenclawCount = 0;
            int HufflepuffCount = 0;




            for (int i = 0; i < count; i++)
            {
                //names[i] = Console.ReadLine();
                string[] firsLastName = Console.ReadLine().Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firsName = firsLastName[0];
                string lastName = firsLastName[1];
                string totalName = firsName + lastName;
                

                string upperLetterName = ""+firsName[0]+lastName[0];
                
                for (int a = 0; a < totalName.Length; a++)
                {
                    sum += (int)totalName[a];
                    
                }
                


                if (sum % 4 == 0)
                {
                    GryffindorCount++;
                    Console.WriteLine("Gryffindor {0}{1}", sum, upperLetterName);
                    sum = 0;
                }
                else if (sum % 4 == 1 )
                {
                    SlytherinCount++;
                    Console.WriteLine("Slytherin {0}{1}", sum, upperLetterName);
                    sum = 0;
                }
                else if (sum % 4 == 2)
                {
                    RavenclawCount++;
                    Console.WriteLine("Ravenclaw {0}{1}", sum, upperLetterName);
                    sum = 0;
                }
                else if (sum % 4 == 3)
                {
                    HufflepuffCount++;
                    Console.WriteLine("Hufflepuff {0}{1}", sum, upperLetterName);
                    sum = 0;
                }


               
            }
            Console.WriteLine();


            Console.WriteLine("Gryffindor: {0}", GryffindorCount);
            Console.WriteLine("Slytherin: {0}", SlytherinCount);
            Console.WriteLine("Ravenclaw: {0}", RavenclawCount);
            Console.WriteLine("Hufflepuff: {0}", HufflepuffCount);




        }


}
    }

