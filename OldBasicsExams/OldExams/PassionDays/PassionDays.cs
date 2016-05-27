using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionDays
{
    class PassionDays
    {
        static void Main(string[] args)
        {
            decimal startMoney = decimal.Parse(Console.ReadLine());
            decimal moneyLeft = 0.0m;
            string command = Console.ReadLine();
            int purchases = 0;
            char[] letter = new char[command.Length];

            while (command == "mall.Enter")
            {
                if (command == "mall.Enter")
                {

                    while (true)
                    {
                        command = Console.ReadLine();
                        if (command == "mall.Exit")
                        {
                            break;
                        }


                        decimal letterValue = 0;
                        decimal valueWithDiscount = 0;


                        for (int i = 0; i < command.Length; i++)
                        {
                            letter[i] = command[i];
                            letterValue = (decimal)letter[i];


                            if (char.IsUpper(letter[i]))
                            {
                                //valueWithDiscount = letterValue - 50;
                                valueWithDiscount = letterValue * 0.5m;
                                //moneyLeft = startMoney - valueWithDiscount;
                                if (startMoney < valueWithDiscount)
                                {
                                    continue;
                                }
                                moneyLeft = startMoney - valueWithDiscount;
                                purchases++;
                            }
                            else if (char.IsLower(letter[i]))
                            {
                                //valueWithDiscount = letterValue - 70;
                                valueWithDiscount = letterValue * 0.3m;
                                if (startMoney < valueWithDiscount)
                                {
                                    continue;
                                    moneyLeft = startMoney - valueWithDiscount;
                                    purchases++;
                                }
                                else if (letter[i] == '%')
                                {
                                    if (startMoney > 0)
                                    {
                                        startMoney /= 2;
                                        purchases++;
                                    }

                                }
                                else if (letter[i] == '*')
                                {
                                    startMoney += 10;
                                }
                                else
                                {
                                    valueWithDiscount = letterValue;
                                    if (startMoney < valueWithDiscount)
                                    {
                                        continue;
                                    }

                                    moneyLeft = startMoney - valueWithDiscount;
                                    purchases++;
                                }



                                //else
                                //{
                                //    moneyLeft = startMoney - letterValue;

                                //}


                                //if (letter[i] == '%')
                                //{
                                //    moneyLeft = startMoney / 2;
                                //    purchases++;
                                //}
                                //else if (letter[i] == '*')
                                //{
                                //    startMoney += 0.05m;
                                //    moneyLeft = startMoney - letterValue;
                                //}
                            }











                           

                        }






                        if (purchases == 0)
                        {
                            Console.WriteLine("No purchases. Money left: {0:f2} lv.”", startMoney);
                        }
                        else if (purchases > 0)
                        {
                            Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, moneyLeft);
                        }





                    }
                }




            }
        }
    }
}
