using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MatrixGame
{
    class MatrixGame
    {
        class infoBegin
        {
            public int matrixRows { get; set; }
            public int matrixCols { get; set; }
            //Console.WriteLine("Enter ROWS of matrix");
            // public int matrixRows = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter COLS of matrix");
            //public int matrixCols = int.Parse(Console.ReadLine());
        }


        //Метод, който проверява входните данни дали са правилни. Примерно на редове да не може да се пише дсфсгдфгфгдфгдф примерно и да гръмне програмата.
        static int checkInfo(double score, int rounds, int series)
        {
            string userString = Console.ReadLine();
            while (userString == "score")
            {
                yourScore(score, rounds, series);
                userString = Console.ReadLine();
            }

            if (userString == "quit" || userString == "exit" || userString == "изход")
            {
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("Total score: {0:f1}", score);
                //Console.ForegroundColor = ConsoleColor.Gray;
                yourScore(score, rounds, series);
                Environment.Exit(0);
            }
            //if (userString == "score")
            //{
            //    yourScore(score);
            //    userString = Console.ReadLine();
            //}
            //else if (userString == "quit" || userString == "exit" || userString == "изход")
            //{
            //    return 0;
            //}

            int rowsCols = 0;
            bool result = int.TryParse(userString, out rowsCols);

            while (!result || rowsCols < 0)
            {
                while (userString == "score")
                {
                    yourScore(score, rounds, series);
                    userString = Console.ReadLine();
                }

                if (userString == "quit" || userString == "exit" || userString == "изход")
                {
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //Console.WriteLine("Total score: {0:f1}", score);
                    //Console.ForegroundColor = ConsoleColor.Gray;
                    yourScore(score, rounds, series);
                    Environment.Exit(0);
                }
                //if (userString == "score")
                //{
                //    yourScore(score);
                //    userString = Console.ReadLine();
                //}
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Грешен тип данни. Моля въведете цяло число");
                Console.ForegroundColor = ConsoleColor.Gray;
                userString = Console.ReadLine();
                result = int.TryParse(userString, out rowsCols);

            }

            //Да кара потребителя да въведе число по-малко или равно на 10

            return rowsCols;

        }


        //Метод, който да пълни матрицата със случайни числа. След него да напиша метод, който да проверява за еднакви случайни числа и да замени едното.
        static void fillMatrixHelpMenu(int[,] matrix, int rows, int cols, int guessingRow, int guessingCol)
        {
            Random rand = new Random();
           

            for (int c = 0; c < cols; c++)
            {

                Console.Write(new string(' ', 7) + "cols" + c);

            }

            Console.WriteLine();
            for (int r = 0; r < rows; r++)
            {


                //for (int c = 0; c < cols; c++)
                //{
                //    Console.Write(new string(' ', 6) + "cols" + c);
                //}

                //Console.WriteLine();

                Console.Write("row" + r + new string(' ', 5));

               

                for (int cols2 = 0; cols2 < cols; cols2++)
                {
                    //Console.Write("cols" + cols + new string(' ', 5));
                    matrix[r, cols2] = rand.Next(11, 999);
                    //matrix[r, cols2] = checkForEqualNums(matrix, r, cols2, matrix[r, cols2]);
                    if (matrix[r, cols2] == matrix[guessingRow, guessingCol])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //Console.Write(matrix[r, cols2] + new string(' ', 10));
                        Console.Write(String.Format("{0,-10}", matrix[r, cols2]) + new string(' ', 2));
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        //Console.Write(matrix[r, cols2] + new string(' ', 10));
                        Console.Write(String.Format("{0,-10}", matrix[r, cols2]) + new string(' ', 2));
                    }


                }

               

                Console.WriteLine();
                Console.WriteLine();
            }

            for (int c = 0; c < cols; c++)
            {

                Console.Write(new string(' ', 7) + "cols" + c);

            }
            Console.WriteLine();

        }




        static void fillMatrix(int[,] matrix, int rows, int cols, int guessingRow, int guessingCol)
        {
            Random rand = new Random();

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = rand.Next(11, 999);
                    if (matrix[r, c] == matrix[guessingRow, guessingCol])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //Console.Write(matrix[r, c] + new string(' ', 10));
                        Console.Write(String.Format("{0,-10}", matrix[r, c]) + new string(' ', 2));
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        //Console.Write(matrix[r, c] + new string(' ', 10));
                        Console.Write(String.Format("{0,-10}", matrix[r, c]) + new string(' ', 2));
                    }
                    //Console.Write(matrix[r, c] + new string(' ', 5));
                }


                Console.WriteLine();
            }
        }








        //Метод, който започва ако потребителят поиска помощ
        static double generateMatrixHelp(int rows, int cols, double yourPoints, int rounds, int series)
        {
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];
            int guessingRow = rand.Next(0, rows);
            int guessingCol = rand.Next(0, cols);



            fillMatrixHelpMenu(matrix, rows, cols, guessingRow, guessingCol);

            //for (int c = 0; c < cols; c++)
            //{               
                   
            //        Console.Write(new string(' ', 7) + "cols" + c);
                            
            //}

            //Console.WriteLine();
            //for (int r = 0; r < rows; r++)
            //{


            //    //for (int c = 0; c < cols; c++)
            //    //{
            //    //    Console.Write(new string(' ', 6) + "cols" + c);
            //    //}

            //    //Console.WriteLine();
                  
            //        Console.Write("row" + r + new string(' ', 5));
                               

            //    for (int cols2 = 0; cols2 < cols; cols2++)
            //    {
            //        //Console.Write("cols" + cols + new string(' ', 5));
            //        matrix[r, cols2] = rand.Next(11, 100);
            //        //matrix[r, cols2] = checkForEqualNums(matrix, r, cols2, matrix[r, cols2]);
            //        if (matrix[r, cols2] == matrix[guessingRow,guessingCol])
            //        {
            //            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //            Console.Write(matrix[r, cols2] + new string(' ', 10));
            //            Console.ForegroundColor = ConsoleColor.Gray;
            //        }
            //        else
            //        {
            //            Console.Write(matrix[r, cols2] + new string(' ', 10));
            //        }
                   

            //    }

            //    Console.WriteLine();
            //    Console.WriteLine();


            //}

            //Console.WriteLine("Choose the right position on element from matrix {0}", matrix[guessingRow, guessingCol]);

            Console.Write("Choose the right position on element from matrix ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(matrix[guessingRow, guessingCol]);
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.Write("If the element repeats, the latest is ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("true");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Row: ");
            int userRow = userRowCheck(rows, yourPoints, rounds, series);

            Console.WriteLine("Col: ");
            int userCol = userCowCheck(cols, yourPoints, rounds, series);

            //Console.WriteLine($"Вие въведохте ред {userRow} колона {userCol} ");


            //Проверява числата на позициите ред и колона дали има съвпадение и ако няма се правят две променливи, които пазят верните ред и колона

            bool found = false;
            int wrongCounter = 0;
            int badSeries = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[userRow, userCol] == matrix[guessingRow, guessingCol])
                    {
                        //Console.WriteLine("Bravo ! You guess. Excellent work");
                        //return;
                        found = true;
                        yourPoints = calcUserPoint(true, rows, cols);
                                    
                        //if (found)
                        //{
                        //    Console.WriteLine("Bravo ! You guess. Excellent work");
                        //    break;
                        //}
                    }


                    else
                    {
                        wrongCounter++;
                       
                        int rightRow = 0;
                        int rightCol = 0;
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                if (matrix[row, col] == matrix[guessingRow, guessingCol])
                                {
                                    rightRow = row;
                                    rightCol = col;
                                   

                                }
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Не познахте. Моля опитайте отново.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        //Тук проверявам грешните отговори и ако са повече от 1 предлагам помощ
                        doYouWantHelp(wrongCounter, guessingRow, guessingCol, yourPoints, rounds, series);

                        //if (wrongCounter > 3)
                        //{
                        //    Console.WriteLine("Do you want more help ? Yes : No");
                        //    string answer = checkYesNo();
                        //    if (answer == "yes")
                        //    {
                        //        colourRowCol(matrix, rows, cols, guessingRow, guessingCol);
                        //    }
                                
                        //}

                        while(!found)
                        {
                            Console.Write("Row: ");
                            userRow = userRowCheck(rows, yourPoints, rounds, series);
                            Console.Write("Cow: ");     
                            userCol = userCowCheck(cols, yourPoints, rounds, series);
                            if (userRow == guessingRow && userCol == guessingCol)
                            {
                                found = true;
                                break;
                            }

                            if ((wrongCounter % 3) == 0)
                            {
                                doYouWantHelp(wrongCounter, guessingRow, guessingCol,yourPoints, rounds, series);

                            }

                            if (userRow == guessingRow && userCol == guessingCol)
                            {
                                found = true;
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Не познахте. Моля опитайте отново.");
                            badSeries++;
                            if (badSeries > 2)
                            {
                                Console.WriteLine("Правите серийка от {0} грешни отговора :(", badSeries);
                            }
                            Console.ForegroundColor = ConsoleColor.Gray;

                            if (wrongCounter > 3)
                            {
                                if (userRow == guessingRow && userCol == guessingCol)
                                {
                                    found = true;
                                    break;
                                }
                                Console.WriteLine("Do you want more help ? Yes : No");
                                string answer = checkYesNo(yourPoints, rounds, series);
                                if (answer == "yes")
                                {
                                    if (userRow == guessingRow && userCol == guessingCol)
                                    {
                                        found = true;
                                        break;
                                    }
                                    colourRowCol(matrix, rows, cols, guessingRow, guessingCol);
                                    
                                }

                            }
                            if (userRow == guessingRow && userCol == guessingCol)
                            {
                                found = true;
                                break;
                            }

                            wrongCounter++;
                        }
                       

                        //Console.WriteLine("Wrong answer. The right answer is row: {0} col: {1}. Please try again.", rightRow, rightCol);
                        //return;
                    }
                }

                if (found)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bravo ! You guess. Excellent work");
                    Console.WriteLine("Your points: {0:f1}",  yourPoints);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return yourPoints;
                   // break;
                }

                //return yourPoints;
            }

            return yourPoints;



            //Проверява потребителя да не въведе за ред повече отколкото матрицата има, защото ще се препълни и ще даде грешка. Същото трябва да се направи и колоните.

        }




        //метод, който стартира ако потребителят не поиска помощ
        static double generateMatrix(int rows, int cols, double yourPoints, int rounds, int series)
        {
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];
            int guessingRow = rand.Next(0, rows);
            int guessingCol = rand.Next(0, cols);


            fillMatrix(matrix, rows, cols, guessingRow, guessingCol);
            //for (int r = 0; r < rows; r++)
            //{
            //    for (int c = 0; c < cols; c++)
            //    {
            //        matrix[r, c] = rand.Next(11, 100);
            //        if (matrix[r, c] == matrix[guessingRow, guessingCol])
            //        {
            //            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //            Console.Write(matrix[r, c] + new string(' ', 10));
            //            Console.ForegroundColor = ConsoleColor.Gray;
            //        }
            //        else
            //        {
            //            Console.Write(matrix[r, c] + new string(' ', 10));
            //        }
            //        //Console.Write(matrix[r, c] + new string(' ', 5));
            //    }


            //    Console.WriteLine();
            //}


            //Console.WriteLine("Choose the right position on element from matrix {0}", matrix[guessingRow, guessingCol]);
            //Console.WriteLine("If the element repeats, the latest is true");

            Console.Write("Choose the right position on element from matrix ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(matrix[guessingRow, guessingCol]);
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.Write("If the element repeats, the latest is ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("true");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Row: ");
            int userRow = userRowCheck(rows, yourPoints, rounds, series);

            Console.WriteLine("Col: ");
            int userCol = userCowCheck(cols, yourPoints, rounds, series);


            //Проверява числата на позициите ред и колона дали има съвпадение и ако няма се правят две променливи, които пазят верните ред и колона
            bool found = false;
            int wrongCounter = 0;
            int badSeries = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[userRow, userCol] == matrix[guessingRow, guessingCol])
                    {
                        //Console.WriteLine("Bravo ! You guess. Excellent work");
                        //return;
                        found = true;
                        yourPoints = calcUserPoint(false, rows, cols);
                    }
                    else
                    {
                        wrongCounter++;
                        int rightRow = 0;
                        int rightCol = 0;
                        
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                if (matrix[row, col] == matrix[guessingRow, guessingCol])
                                {
                                    rightRow = row;
                                    rightCol = col;

                                }
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Не познахте. Моля опитайте отново.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        //Тук проверявам грешните отговори и ако са повече от 1 предлагам помощ
                        doYouWantHelp(wrongCounter, guessingRow, guessingCol, yourPoints, rounds, series);


                        while (!found)
                        {
                            Console.Write("Row: ");
                            userRow = userRowCheck(rows, yourPoints, rounds, series);
                            Console.Write("Cow: ");
                            userCol = userCowCheck(cols, yourPoints, rounds, series);
                            if (userRow == guessingRow && userCol == guessingCol)
                            {
                                found = true;
                                break;
                            }

                            if ((wrongCounter % 3) == 0)
                            {
                                doYouWantHelp(wrongCounter, guessingRow, guessingCol, yourPoints, rounds, series);
                            }

                            if (userRow == guessingRow && userCol == guessingCol)
                            {
                                found = true;
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Не познахте. Моля опитайте отново.");
                            badSeries++;
                            if (badSeries > 2)
                            {
                                Console.WriteLine("Правите серийка от {0} грешни отговора :(", badSeries);
                            }
                            Console.ForegroundColor = ConsoleColor.Gray;

                            if (wrongCounter > 3)
                            {
                                if (userRow == guessingRow && userCol == guessingCol)
                                {
                                    found = true;
                                    break;
                                }
                                Console.WriteLine("Do you want more help ? Yes : No");
                                string answer = checkYesNo(yourPoints, rounds, series);
                                if (answer == "yes")
                                {
                                    if (userRow == guessingRow && userCol == guessingCol)
                                    {
                                        found = true;
                                        break;
                                    }
                                    colourRowCol(matrix, rows, cols, guessingRow, guessingCol);

                                }

                            }
                            if (userRow == guessingRow && userCol == guessingCol)
                            {
                                found = true;
                                break;
                            }

                            wrongCounter++;
                        }





                        //Console.Write("Row: ");
                        //userRow = userRowCheck(rows);
                        //Console.Write("Cow: ");
                        //userCol = userCowCheck(cols);


                        //Console.WriteLine("Wrong answer. The right answer is row: {0} col: {1}. Please try again.", rightRow, rightCol);
                        //return;


                    }
                }

                if (found)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bravo ! You guess. Excellent work");
                    Console.WriteLine("Your Points: {0:f1}", yourPoints);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return yourPoints;
                    // break;
                }

                //return yourPoints;
            }

            return yourPoints;











            //Долният ред просто проверява дали съм взел вярно или правилните данни.
            //Console.WriteLine($"Вие въведохте ред {userRow} колона {userCol} ");

        }





        //Метод, който проверява предположението за ред на потребителя да не е по-голямо от реда на матрицата, за да не се препълни. Същото трябва да се направи и за колоните.

        static int userRowCheck(int rows, double score, int rounds, int series)
        {
            //Проверявам какви глупости въвежда потребителя идиот, за да не ми счупи програмата
            string yourRow = Console.ReadLine();
            while (yourRow == "score")
            {
                yourScore(score, rounds, series);
                yourRow = Console.ReadLine();
            }

            if (yourRow == "quit" || yourRow == "exit" || yourRow == "изход")
            {
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("Total score: {0:f1}", score);
                //Console.ForegroundColor = ConsoleColor.Gray;
                yourScore(score, rounds, series);
                Environment.Exit(0);
            }
            //if (yourRow == "score")
            //{
            //    yourScore(score);
            //    yourRow = Console.ReadLine();
            //}
            int userRow = 0;
            bool result = int.TryParse(yourRow, out
                userRow);

            while (!result)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Грешен тип данни. Моля въведете цяло число");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Row: ");
                yourRow = Console.ReadLine();
                while (yourRow == "score")
                {
                    yourScore(score, rounds, series);
                    yourRow = Console.ReadLine();
                }

                if (yourRow == "quit" || yourRow == "exit" || yourRow == "изход")
                {
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //Console.WriteLine("Total score: {0:f1}", score);
                    //Console.ForegroundColor = ConsoleColor.Gray;
                    yourScore(score, rounds, series);
                    Environment.Exit(0);
                }
                //if (yourRow == "score")
                //{
                //    yourScore(score);
                //    yourRow = Console.ReadLine();
                //}
                result = int.TryParse(yourRow, out
                 userRow);
            }

            //След горната проверка за простотии, проверявам дали числото е в границите на матрицата , за да не изписка грозния exception

            while (userRow >= rows || userRow < 0)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Няма такъв ред. Моля опитайте отново.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Row: ");
                string yourRows = Console.ReadLine();
                while (yourRow == "score")
                {
                    yourScore(score, rounds, series);
                    yourRow = Console.ReadLine();
                }

                if (yourRow == "quit" || yourRow == "exit" || yourRow == "изход")
                {
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //Console.WriteLine("Total score: {0:f1}", score);
                    //Console.ForegroundColor = ConsoleColor.Gray;
                    yourScore(score, rounds, series);
                    Environment.Exit(0);
                }
                //if (yourRow == "score")
                //{
                //    yourScore(score);
                //    yourRow = Console.ReadLine();
                //}
                userRow = 0;
                bool result2 = int.TryParse(yourRows, out userRow);
                while (!result2)
                {
                   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Няма такъв ред. Моля опитайте отново.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Row: ");
                    yourRows = Console.ReadLine();
                    while (yourRow == "score")
                    {
                        yourScore(score, rounds, series);
                        yourRow = Console.ReadLine();
                    }

                    if (yourRow == "quit" || yourRow == "exit" || yourRow == "изход")
                    {
                        //Console.ForegroundColor = ConsoleColor.Green;
                        //Console.WriteLine("Total score: {0:f1}", score);
                        //Console.ForegroundColor = ConsoleColor.Gray;
                        yourScore(score, rounds, series);
                        Environment.Exit(0);
                    }
                    //if (yourRow == "score")
                    //{
                    //    yourScore(score);
                    //    yourRow = Console.ReadLine();
                    //}
                    result2 = int.TryParse(yourRows, out userRow);
                }

            }

            return userRow;

        }


        //Същият метод, но да проверява колоните
        static int userCowCheck(int cows, double score, int rounds, int series)
        {

            //Проверявам какви глупости въвежда потребителя идиот, за да не ми счупи програмата
            string yourCow = Console.ReadLine();
            while (yourCow == "score")
            {
                yourScore(score, rounds, series);
                yourCow = Console.ReadLine();
            }

            if (yourCow == "quit" || yourCow == "exit" || yourCow == "изход")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Total score: {0:f1}", score);
                Console.ForegroundColor = ConsoleColor.Gray;
                Environment.Exit(0);
            }
            //if (yourCow == "score")
            //{
            //    yourScore(score);
            //    yourCow = Console.ReadLine();
            //}
            int userCow = 0;
            bool result = int.TryParse(yourCow, out
                userCow);

            while (!result)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Грешен тип данни. Моля въведете цяло число");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Col: ");
                yourCow = Console.ReadLine();
                while (yourCow == "score")
                {
                    yourScore(score, rounds, series);
                    yourCow = Console.ReadLine();
                }

                if (yourCow == "quit" || yourCow == "exit" || yourCow == "изход")
                {
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //Console.WriteLine("Total score: {0:f1}", score);
                    //Console.ForegroundColor = ConsoleColor.Gray;
                    yourScore(score, rounds, series);
                    Environment.Exit(0);
                }
                //if (yourCow == "score")
                //{
                //    yourScore(score);
                //    yourCow = Console.ReadLine();
                //}
                result = int.TryParse(yourCow, out
                 userCow);
            }

            //След горната проверка за простотии, проверявам дали числото е в границите на матрицата , за да не изписка грозния exception
            while (userCow >= cows || userCow < 0)
            {
                //userCow > cows || userCow < 0
                //Console.WriteLine("Няма такав колона. Моля опитайте отново.");
                //userCow = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Няма такaвa колона. Моля опитайте отново.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Col: ");
                string yourCol = Console.ReadLine();
                while (yourCol == "score")
                {
                    yourScore(score,rounds, series);
                    yourCol = Console.ReadLine();
                }

                if (yourCol == "quit" || yourCol == "exit" || yourCol == "изход")
                {
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //Console.WriteLine("Total score: {0:f1}", score);
                    //Console.ForegroundColor = ConsoleColor.Gray;
                    yourScore(score, rounds, series);
                    Environment.Exit(0);
                }
                //if (yourCow == "score")
                //{
                //    yourScore(score);
                //    yourCow = Console.ReadLine();
                //}
                userCow = 0;
                bool result2 = int.TryParse(yourCol, out userCow);
                while (!result2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Няма такава колона. Моля опитайте отново2.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Col: ");
                    yourCol = Console.ReadLine();
                    while (yourCol == "score")
                    {
                        yourScore(score, rounds, series);
                        yourCol = Console.ReadLine();
                    }

                    if (yourCol == "quit" || yourCol == "exit" || yourCol == "изход")
                    {
                        //Console.ForegroundColor = ConsoleColor.Green;
                        //Console.WriteLine("Total score: {0:f1}", score);
                        //Console.ForegroundColor = ConsoleColor.Gray;
                        yourScore(score, rounds, series);
                        Environment.Exit(0);
                    }
                    //if (yourCow == "score")
                    //{
                    //    yourScore(score);
                    //    yourCow = Console.ReadLine();
                    //}
                    result2 = int.TryParse(yourCol, out userCow);
                }
            }

            return userCow;

        }


        //метод, който да генерира случайни размери на матрицата, ако на потребителя не му се занимава
        static int[] generateMatrixSizes(Random rand)
        {
            //Random rand = new Random();
            //Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            //Random rand2 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            //Random rand = new Random(Guid.NewGuid().GetHashCode());
            //Random rand2 = new Random();
            //var seed = (int)DateTime.Now.Ticks;
            //Random rand = new Random((int)DateTime.Now.Ticks);



            int[] autoMatrixSizes = new int[2];

            //autoMatrixSizes[0] = rand.Next(2, 11);
            //System.Threading.Thread.Sleep(70);
            //rand = new Random((int)DateTime.Now.Ticks);
            //autoMatrixSizes[1] = rand.Next(2, 11);

            for (int i = 0; i < autoMatrixSizes.Length; i++)
            {
                
                autoMatrixSizes[i] += rand.Next(2, 11);
                

            }


            return autoMatrixSizes;


        }



        //Метод да се извиква когато потребителя е направил повече от 1 грешен отговор
        static void doYouWantHelp(int wrongNumbers, int RightRows, int RightCols, double score, int rounds, int series)
        {
            Random rand = new Random();
            if (wrongNumbers > 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Do you want a little help ? YES or NO");
                Console.ForegroundColor = ConsoleColor.Gray;
                //string wantHelp = Console.ReadLine().ToLower();
                string wantHelp = checkYesNo(score, rounds, series);

                if (wantHelp == "yes")
               {
                    int rowsOrColsToShow = rand.Next(1, 3);
                    switch (rowsOrColsToShow)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Rows is {0}", RightRows);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Cols is {0}", RightCols);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        default:
                            break;
                    }
                }
                
                
                
                
            }
        }


        //Метод, който да проверя дали потребителя въвежда yes or no и без други простотии
        static string checkYesNo(double score, int rounds, int series)
        {
            Random rand = new Random();
            string userAnswer = Console.ReadLine().ToLower();
            while (userAnswer == "score")
            {
                yourScore(score, rounds, series);
                userAnswer = Console.ReadLine();
            }

            if (userAnswer == "quit" || userAnswer == "exit" || userAnswer == "изход")
            {
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("Total score: {0:f1}", score);
                //Console.ForegroundColor = ConsoleColor.Gray;
                yourScore(score, rounds, series);
                Environment.Exit(0);
            }
            //if (userAnswer == "score")
            //{
            //    yourScore(score);
            //    userAnswer = Console.ReadLine().ToLower();
            //}

            if (userAnswer == "yes")
            {
                return userAnswer;
            }
            else if (userAnswer == "no")
            {
                return userAnswer;
            }

            int wrongCounter = 1;

            while (userAnswer != "yes" || userAnswer != "no")
            {
                wrongCounter++;
                if (wrongCounter > 2 && wrongCounter < 4)
                {
                    Console.WriteLine("Хайде де не е толкова трудно. Това не е тест за интелигентност.");
                    userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        return userAnswer;
                    }
                    else if (userAnswer == "no")
                    {
                        return userAnswer;
                    }

                    wrongCounter++;
                }
                else if (wrongCounter >= 4 && wrongCounter < 6)
                {
                    Console.WriteLine("Даваш всичко от себе си да ме счупиш нали ? ...");
                    userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        return userAnswer;
                    }
                    else if (userAnswer == "no")
                    {
                        return userAnswer;
                    }

                    wrongCounter++;
                }
                else if (wrongCounter >= 6 && wrongCounter < 8)
                {
                    Console.WriteLine("Защо се самонаказваш ? Няма да ме счупиш.");
                    userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        return userAnswer;
                    }
                    else if (userAnswer == "no")
                    {
                        return userAnswer;
                    }

                    wrongCounter++;
                }
                else if (wrongCounter >= 8 && wrongCounter < 10)
                {
                    Console.WriteLine("Ще ме накараш аз да взема решение вместо теб нали ?");
                    userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        return userAnswer;
                    }
                    else if (userAnswer == "no")
                    {
                        return userAnswer;
                    }

                    wrongCounter++;
                }
                else if (wrongCounter >= 10 && wrongCounter < 12)
                {
                    Console.WriteLine("Последно предупреждение и вземам нещата в свои виртуални ръце :D");
                    userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        return userAnswer;
                    }
                    else if (userAnswer == "no")
                    {
                        return userAnswer;
                    }

                    wrongCounter++;
                }
                else if (wrongCounter >= 12)
                {
                    //Old version
                    //int randNum = rand.Next(0, 2);
                    //if (randNum == 0)
                    //{
                    //    userAnswer = "yes";
                    //    break;
                    //}
                    //else
                    //{
                    //    userAnswer = "no";
                    //    break;
                    //}

                    int randNum = rand.Next(0, 101);

                    if (randNum % 2 == 0)
                    {
                        userAnswer = "no";
                        break;
                    }
                    else
                    {
                        userAnswer = "yes";
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Непозна. Опитай пак");
                    userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        return userAnswer;
                    }
                    else if (userAnswer == "no")
                    {
                        return userAnswer;
                    }

                }

                //wrongCounter++;

            }

            return userAnswer;
        }




        //Метод, който ще изчислява точките. Ще приема 2 параметъра. Единия булев, дали играта е в режим с помощ или не = тоест true или false. Вторият параметър който ще взема е променливата с точките досега на потребителя. Ще връща един параметър и това е нова стойност на променливата , която пази точките.


        static double calcUserPoint(bool helpOrNot, int rows, int cols)
        {
            Random rand = new Random();
            double randSum = 0;
            //double min = 0.0;
            //double max = 0.0;
            //Първо проверявам в какъв режим е играта - с помощ или без
            if (helpOrNot)      //ако е в режим с помощ е логично да дам по-малко точки.
            {
                double min = 1.0;
                double max = 5.0;

                if (rows >= 5 && cols >= 5)
                {
                    min = 5.0;
                    max = 10;

                    randSum = min + rand.NextDouble() * (max - min);
                    return randSum;
                }
                else
                {
                    randSum = min + rand.NextDouble() * (max - min);
                    return randSum;
                }

                //randSum = rand.NextDouble() * (max - min) + min;
                

            }
            else        //ако е в режим без да се иска помощ повече точки
            {
                double min = 5.0;
                double max = 15.0;

                if (rows >= 5 && cols >= 5)
                {
                    min = 15.0;
                    max = 25.0;

                    randSum = min + rand.NextDouble() * (max - min);
                    return randSum;
                }
                else
                {
                    randSum = min + rand.NextDouble() * (max - min);
                    return randSum;
                }

                //randSum = rand.NextDouble() * (max - min) + min;
               
            }


            //По-късно да добавя проверка за сериика. Примерно ако се направи повече от 3 верни отговора да дава бонус точки.


            
        }



        //Метод, който оцветява ред и колона, където е елементът за повече помощ
        static void colourRowCol(int[,] matrix, int rows, int cols, int guessingRow, int guessingCol)
        {
            Random rand = new Random();
            


            for (int c = 0; c < cols; c++)
            {
                if (c == guessingCol)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(new string(' ', 7) + "cols" + c);
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
                else
                {
                    Console.Write(new string(' ', 7) + "cols" + c);
                }

            }

            Console.WriteLine();
            for (int r = 0; r < rows; r++)
            {


                //for (int c = 0; c < cols; c++)
                //{
                //    Console.Write(new string(' ', 6) + "cols" + c);
                //}

                //Console.WriteLine();

                if (r == guessingRow)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("row" + r + new string(' ', 5));
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
                else
                {
                    Console.Write("row" + r + new string(' ', 5));
                }


                for (int cols2 = 0; cols2 < cols; cols2++)
                {
                    //Console.Write("cols" + cols + new string(' ', 5));
                    //matrix[r, cols2] = rand.Next(11, 100);
                    //matrix[r, cols2] = rand.Next(11, 100);
                   //matrix[r, cols2] = checkForEqualNums(matrix, r, cols2, matrix[r, cols2]);
                    if (matrix[r, cols2] == matrix[guessingRow, guessingCol])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //Console.Write(matrix[guessingRow, guessingCol] + new string(' ', 10));
                        Console.Write(String.Format("{0,-10}", matrix[guessingRow, guessingCol]) + new string(' ', 2));
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        //Console.Write(matrix[r, cols2] + new string(' ', 10));
                        Console.Write(String.Format("{0,-10}", matrix[r, cols2]) + new string(' ', 2));
                    }


                }

                Console.WriteLine();
                Console.WriteLine();
            }

            for (int c = 0; c < cols; c++)
            {

                if (c == guessingCol)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(new string(' ', 7) + "cols" + c);
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
                else
                {
                    Console.Write(new string(' ', 7) + "cols" + c);
                }

            }
            Console.WriteLine();
        }




        //Да напиша метод, който да премахне повтарящите се числа в матрицата. Да приема като аргументи реда и колоната до който е стигнал цикъла, и генерираното случайно число, за да ги сравни и ако са еднакви да се генерира случайно число толкова пъти колкото е нужно , за да са различни

        
        static int checkForEqualNums(int[,] matrix, int rows, int cols, int randomNumber)
        {
            Random rand = new Random();


            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r, c] == randomNumber)
                    {
                        int equalNumber = matrix[r, c];
                        
                        equalNumber++;
                        randomNumber = rand.Next(equalNumber, 100);
                        
                        return randomNumber;
                    }
                }

            }

            return randomNumber;

            //if (matrix[rows, cols] == randomNumber)
            //{
            //    randomNumber = rand.Next(randomNumber + 1, 100);
            //    return randomNumber;
            //}
            //else
            //{
            //    return randomNumber;
            //}
            //while (matrix[rows, cols] == number)
            //{
            //    number = rand.Next(11, 100);
            //    return number;
            //}

            

        }


        //метод, който чрез рундовете да изчислява серийките. На всеки 3 последователни правилни отговора серийката се увеличава
        static int calcPositiveSeries(int rounds, int series)
        {
            if (rounds % 3 == 0)
            {
                series++;
            }

            return series;
        }





        //Метод, който по всяко време да показва резултата на играча, щом изпише score
        static void yourScore(double score, int rounds, int series)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("At the moment your score is {0:f1}", score);
            Console.WriteLine("Your series {0}", series);
            Console.WriteLine("Total played games {0}", rounds);
            Console.ForegroundColor = ConsoleColor.Gray;
        }


        //метод, който да брои отрицателната сериика на играча
        static int negativeSeries(int badSeries)
        {
            badSeries++;
            return badSeries;
        }



        /////////////////////////////////Край на методите.../////////////////////////////////////////////////////////

        static void Main(string[] args)
        {
            Random rand = new Random();
            double yourPoints = 0.0;
            int rounds = 1;
            int series = 0;
            int badSeries = 0;
            
            //string command = Console.ReadLine().ToLower();

            while (true)
            {
                Console.WriteLine("Do you want rows and cols of matrix to be autogenerated: YES or NO");
                Console.WriteLine("If you want to see your score anytime in game, just write score to see it.");
                string autoGenerate = checkYesNo(yourPoints, rounds, series);
                //string autoGenerate = Console.ReadLine().ToLower();

                if (autoGenerate == "yes")
                {
                    int[] matrixRowsCols = generateMatrixSizes(rand);

                    int autoRows = matrixRowsCols[0];
                    int autoCols = matrixRowsCols[1];

                    infoBegin matrixInfo = new infoBegin() { matrixRows = autoRows, matrixCols = autoCols };
                    Console.WriteLine("Size of your matrix is: matrix[{0}, {1}]", matrixInfo.matrixRows ,matrixInfo.matrixCols);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Game {0}", rounds);
                    Console.WriteLine("Do you want help ? (see the numbers of rows and cols");
                    Console.WriteLine("Answer with YES or NO. No matter upper or lowercase");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    //string help = Console.ReadLine().ToLower();
                    string help = checkYesNo(yourPoints, rounds, series);

                    if (help == "yes")
                    {
                        series = calcPositiveSeries(rounds, series);
                        yourPoints +=  generateMatrixHelp(matrixInfo.matrixRows, matrixInfo.matrixCols, yourPoints, rounds, series);

                        
                        //тук по-късно да сложа точковата система и по-скоро при да вадя от точките. Първо да проверя колко са точките на потребителя и ако са нула няма какво да му се вземе. Ако са му повече от нула тогава да му се вземе определен брой точки. 
                    }
                    else
                    {
                        series = calcPositiveSeries(rounds, series);
                        yourPoints += generateMatrix(matrixInfo.matrixRows, matrixInfo.matrixCols,yourPoints, rounds, series);
                        
                        //тук при правилен отговор да се дава определен брой точки.
                    }



                }
                else
                {
                    Console.WriteLine("Enter matrix[rows]: ");
                    //int rows = int.Parse(Console.ReadLine());
                    int rows = checkInfo(yourPoints, rounds, series);


                    Console.WriteLine("Enter matrix[cols]: ");
                    //int cols = int.Parse(Console.ReadLine());
                    int cols = checkInfo(yourPoints, rounds, series);

                    infoBegin matrixInfo = new infoBegin() { matrixRows = rows, matrixCols = cols };

                    Console.WriteLine("Size of your matrix is: matrix[{0}, {1}]", matrixInfo.matrixRows, matrixInfo.matrixCols);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Game {0}", rounds);
                    Console.WriteLine("Do you want help ? (see the numbers of rows and cols");
                    Console.WriteLine("Answer with YES or NO. No matter upper or lowercase");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    //string help = Console.ReadLine().ToLower();
                    string help = checkYesNo(yourPoints, rounds, series);

                    if (help == "yes")
                    {
                        series = calcPositiveSeries(rounds, series);
                        yourPoints += generateMatrixHelp(matrixInfo.matrixRows, matrixInfo.matrixCols,yourPoints, rounds, series);
                        
                        //тук по-късно да сложа точковата система и по-скоро при да вадя от точките. Първо да проверя колко са точките на потребителя и ако са нула няма какво да му се вземе. Ако са му повече от нула тогава да му се вземе определен брой точки. 
                    }
                    else
                    {
                        series = calcPositiveSeries(rounds, series);
                        yourPoints += generateMatrix(matrixInfo.matrixRows, matrixInfo.matrixCols, yourPoints, rounds, series);
                        
                        //тук при правилен отговор да се дава определен брой точки.
                    }
                }



                //class for input information

                //infoBegin matrixInfo = new infoBegin() { matrixRows = rows, matrixCols = cols };
               


                




                











                //Това най-отдолу
                Console.WriteLine("Do you want one more game: yes or no");
                //string command = Console.ReadLine().ToLower();
                string command = checkYesNo(yourPoints, rounds, series);
                if (command == "no")
                {
                    Console.WriteLine("Your points {0:f1}", yourPoints);
                    Console.WriteLine("Your series: {0}", series);
                    Console.ReadLine();
                    break;

                }

                rounds++;
                    

            }



            
            


        }
    }
}
