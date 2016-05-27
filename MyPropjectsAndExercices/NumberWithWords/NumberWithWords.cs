using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWithWords
{
    class NumberWithWords
    {

        //check for thousands (проверява за хилядни)
        static void thousand(int number)
        {
            int checkForThousand = number / 1000;
            int hundreds = (number / 100) % 10;
            int checkForTenths = (number / 10) % 10;
            int tens = (number % 10);

            if (checkForThousand != 0)
            {
                switch (checkForThousand)
                {
                    case 1:
                        Console.Write("Хиляда");
                        break;
                    case 2:
                        Console.Write("Две хиляди");
                        break;
                    case 3:
                        Console.Write("Три хиляди");
                        break;
                    case 4:
                        Console.Write("Четири хиляди");
                        break;
                    case 5:
                        Console.Write("Пет хиляди");
                        break;
                    case 6:
                        Console.Write("Шест хиляди");
                        break;
                    case 7:
                        Console.Write("Седем хиляди");
                        break;
                    case 8:
                        Console.Write("Осем хиляди");
                        break;
                    case 9:
                        Console.Write("Девет хиляди");
                        break;
                    default:
                        Console.Write("Невалидно число");
                        break;
                }


                if (hundreds != 0 && checkForTenths != 0 && tens == 0)
                {
                    Console.Write(" и ");
                }
                else
                {
                    Console.Write(" ");
                }


            }
            


        }



        //check for hundreds
        static void hundreds(int number)
        {
            int checkForHundreds = (number / 100) % 10;
            int checkForTenths = (number / 10) % 10;
            int tens = (number % 10);

            if (checkForHundreds != 0)
            {
                switch (checkForHundreds)
                {
                    case 1:
                        Console.Write("сто");
                        break;
                    case 2:
                        Console.Write("двеста");
                        break;
                    case 3:
                        Console.Write("триста");
                        break;
                    case 4:
                        Console.Write("четиристотин");
                        break;
                    case 5:
                        Console.Write("петстотин");
                        break;
                    case 6:
                        Console.Write("шестстотин");
                        break;
                    case 7:
                        Console.Write("седемстотин");
                        break;
                    case 8:
                        Console.Write("осемстотин");
                        break;
                    case 9:
                        Console.Write("деветстотин");
                        break;
                    default:
                        break;
                }
            }


            //if (checkForTenths != 0)
            //{
            //    Console.Write(" и ");
            //}

        }



        //check for tenths(Проверка за десетици)
        static void tenths(int number)
        {
            int checkForTenths = (number / 10) % 10;
            int fromElevenToNinetten = number % 100;
            int tens = (number % 10);

            if (checkForTenths != 0)
            {
                switch (checkForTenths)
                {
                    case 1:
                        if (fromElevenToNinetten == 11)
                        {
                            Console.Write("Единадесет");
                        }
                        else if (fromElevenToNinetten == 12)
                        {
                            Console.Write("Дванадесет");
                        }
                        else if (fromElevenToNinetten == 13)
                        {
                            Console.Write("Тринадесет");
                        }
                        else if (fromElevenToNinetten == 14)
                        {
                            Console.Write("Четиринадесет");
                        }
                        else if (fromElevenToNinetten == 15)
                        {
                            Console.Write("Петнадесет");
                        }
                        else if (fromElevenToNinetten == 16)
                        {
                            Console.Write("Шестнадесет");
                        }
                        else if (fromElevenToNinetten == 17)
                        {
                            Console.Write("Седемнадесет");
                        }
                        else if (fromElevenToNinetten == 18)
                        {
                            Console.Write("Осемнадесет");
                        }
                        else if (fromElevenToNinetten == 19)
                        {
                            Console.Write("Деветнадесет");
                        }
                        else
                        {
                            Console.Write("десет");
                        }
                        
                        break;
                    case 2:
                        Console.Write("двадесет");
                        break;
                    case 3:
                        Console.Write("тридесет");
                        break;
                    case 4:
                        Console.Write("четиридесет");
                        break;
                    case 5:
                        Console.Write("петдесет");
                        break;
                    case 6:
                        Console.Write("шестдесет");
                        break;
                    case 7:
                        Console.Write("седемдесет");
                        break;
                    case 8:
                        Console.Write("осемдесет");
                        break;
                    case 9:
                        Console.Write("деветдесет");
                        break;
                    default:
                        break;
                }


                if (tens != 0 && fromElevenToNinetten > 19)
                {
                    Console.Write(" и ");
                }


            }
        }
        

        //check units(единици)
        static void units(int number)
        {
            int checkUnits = number % 10;
            int fromElevenToNinetten = number % 100;

            if (checkUnits != 0 || fromElevenToNinetten > 19)
            {
                switch (checkUnits)
                {
                    case 0:
                        Console.Write("Нула");
                        break;
                    case 1:
                        Console.Write("Едно");
                        break;
                    case 2:
                        Console.Write("Две");
                        break;
                    case 3:
                        Console.Write("Три");
                        break;
                    case 4:
                        Console.Write("Четири");
                        break;
                    case 5:
                        Console.Write("Пет");
                        break;
                    case 6:
                        Console.Write("Шест");
                        break;
                    case 7:
                        Console.Write("Седем");
                        break;
                    case 8:
                        Console.Write("Осем");
                        break;
                    case 9:
                        Console.Write("Девет");
                        break;
                    default:
                        break;
                }
            }
        }




        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            //Random rand = new Random();
            //int number = rand.Next(0, 1000);

            Console.WriteLine(number);

            thousand(number);
            hundreds(number);
            tenths(number);
            units(number);

        }
    }
}
