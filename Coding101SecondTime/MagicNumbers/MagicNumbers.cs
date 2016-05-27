using System;

class MagicNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int pos1 = 0; pos1 <= n; pos1++)
        {
            for (int pos2 = 0; pos2 <= n; pos2++)
            {
                for (int pos3 = 0; pos3 <= n; pos3++)
                {

                    for (int pos4 = 0; pos4 <= n; pos4++)
                    {

                        for (int pos5 = 0; pos5 <= n; pos5++)
                        {
                            

                            for (int pos6 = pos5; pos6 <= n; pos6++)
                            {
                                if(pos6 * pos5 * pos4 * pos3 * pos2 * pos1 == n)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}{5} ", pos1, pos2, pos3, pos4, pos5, pos6);
                                }

                                //if (pos6 > n) pos6 = 1;
                                
                                
                            }
                            

                        }


                    }
                }

            }


        }



    }
}