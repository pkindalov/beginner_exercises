using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class FallenInLove
    {

        //помощни методи, които изчисляват простички неща - броят на # на редоветем, точките за фон, 
        //тилдите и др.


        //изчислява общо всички знаци на реда
        static int calcTotalCharacters(int n)
        {
            int flowerBeginPartTotal = 6;
            int totalCharacters = (n * 4) + flowerBeginPartTotal;
            return totalCharacters;
        }

        //Смята частите на цветето, но само горния ред
        static int calcFlowerPart()
        {
            int flowerBeginPartTotal = 6;
            int flowerPart = flowerBeginPartTotal / 3;
            return flowerPart;
        }


        //смята точките за фон
        static int dotsBackground(int n)
        {
            int result = (n * 4) / 2;
            return result;
        }



        //метод, който чертае най-горният ред, защото е еднакъв в примерите
        static void drawTop(int n)
        {
            int flowerBeginPartTotal = 6;
            int totalCharacters = calcTotalCharacters(n);
            //int totalCharacters = (n * 4) + flowerBeginPartTotal;


            //int flowerPart = flowerBeginPartTotal / 3;
            int flowerPart = calcFlowerPart();
            //int backgroundDots = (n * 4) / 2;
            int backgroundDots = dotsBackground(n);

            Console.Write(new string('#', flowerPart));
            Console.Write(new string('.', backgroundDots));
            Console.Write(new string('#', flowerPart));
            Console.Write(new string('.', backgroundDots));
            Console.Write(new string('#', flowerPart));
            Console.WriteLine();
        }


        //метод, който чертае най-долния ред
        static void drawBottom(int n)
        {
            int flowerBeginPartTotal = 6;
            int totalCharacters = (n * 4) + flowerBeginPartTotal;


            int flowerPart = flowerBeginPartTotal / 3;
            int backgroundDots = (n * 4) / 2 + 2;

            Console.Write(new string('.', backgroundDots));
            Console.Write(new string('#', flowerPart));
            Console.Write(new string('.', backgroundDots));
            Console.WriteLine();


        }


        //метод, който чертае първите 4 реда на цветето
        static void drawFlowerTop(int n)
        {

            for (int i = 1; i < n; i++)
            {
                //Console.WriteLine(i);
                Console.Write(new string('#', 1));
                Console.Write(new string('~', i));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', dotsBackground(n - i)));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', dotsInMiddle(i)));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', dotsBackground(n - i)));
                Console.Write(new string('#', 1));
                Console.Write(new string('~', i));
                Console.Write(new string('#', 1));
                Console.WriteLine();
                

            }
            
        }


        //метод, който чертае точките в средата
        static int dotsInMiddle(int n)
        {
            return n * 2;

        }


        //метод, който чертае тилдите след 5 ред и отгоре-надолу(5,4,3,2,1)
        static void drawTilds(int n)
        {
            //for (int i = n ; i >= n; i--)
            //{
            //    Console.Write(new string('~', i + 1));
            //}
           


        }



        //метод, който чертае 2та част от цветето след 4ред
        static void drawFlowerSecondPart(int n)
        {
            //for (int i = 1, p = 0; i <= n + 2; i+= 2, p++)
            //{
            //    Console.Write(new string('.', i));
            //    Console.Write(new string('#', 1));
            //    //Console.Write(new string('~', n - i));
            //    //drawTilds(n - (i - 2));
            //    Console.Write(new string('~', n - p));
            //    Console.WriteLine();

            //}

            for (int i = 0; i <= n; i++)
            {
                Console.Write(new string('.', i * 2 + 1));
                Console.Write(new string('#', 1));
                Console.Write(new string('~', n - i));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', (n * 2) - 2 * i));
                Console.Write(new string('#', 1));
                Console.Write(new string('~', n - i));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', i * 2 + 1));
                Console.WriteLine();
            }


        }




        //метод , който чертае последната част от растението - стъблото
        static void drawFlowerStalk(int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', (n * 2) + 2));
                Console.Write(new string('#', 2));
                Console.Write(new string('.', (n * 2) + 2));
                Console.WriteLine();
            }


        }






        //////////////////////////////////////////////////////////////////////////////////////////////









        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            drawTop(n);
            drawFlowerTop(n);
            drawFlowerSecondPart(n);
            drawFlowerStalk(n);
            drawBottom(n);

            Console.ReadLine();
        }
    }
}
