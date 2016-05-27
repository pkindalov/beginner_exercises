using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class GameOfNames
    {
        static void Main(string[] args)
        {
            int nPlayers = int.Parse(Console.ReadLine());
            string[] playerNames = new string[nPlayers];
            decimal[] playersScores = new decimal[nPlayers];
            decimal[] totalScores = new decimal[nPlayers];

            //for (int i = 0; i < totalScores.Length; i++)
            //{
            //    totalScores[i] = int.MaxValue;
            //}  


            //Пълня масивите с имената на играчите и точките им по задание на потребителя
            for (int i = 0; i < nPlayers; i++)
            {
                playerNames[i] = Console.ReadLine();
                playersScores[i] = int.Parse(Console.ReadLine());

            }

            
            //Обхождам масива с имената и пресмятам точките
            for (int i = 0; i < playerNames.Length; i++)
            {
                totalScores[i] += playersScores[i];
                //Тук обхождам буквите на всяка дума
                for (int letterPosion = 0; letterPosion < playerNames[i].Length; letterPosion++)
                {
                    char symbol = playerNames[i][letterPosion];
                    int symbolCode = (int)symbol;
                    if (symbolCode % 2 == 0)
                    {
                       
                        totalScores[i] += Convert.ToInt32(symbolCode);
                    }
                    else
                    {
                        totalScores[i] -= Convert.ToInt32(symbolCode);
                    }
                    //Console.Write(symbol + " ");
                    //Console.WriteLine((int)symbol);

                }

            }


            decimal bigger = int.MaxValue;
            int next = 0;
            string winner = string.Empty;
            
            for (int i = 0; i < totalScores.Length - 1; i++)
            {
                next = i + 1;
                if (totalScores[i] > totalScores[i + 1])
                {
                    bigger = totalScores[i];
                    winner = playerNames[i];
                }
               
            }

            Console.WriteLine("The winner is {0} - {1} points", winner, bigger);


            //foreach (int result in totalScores)
            //{
            //    Console.WriteLine(result);
            //}



        }
    }
}
