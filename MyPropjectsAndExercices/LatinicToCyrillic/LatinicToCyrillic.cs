using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinicToCyrillic
{
    class LatinicToCyrillic
    {
        
        //според фонетиката
        static string Bulgarian(string latin)
        {
            //тук са тежките случаи от времето на мирката четворки и шестици за ч и ш
            latin = latin.Replace("6", "ш");
            latin = latin.Replace("4", "ч");
            latin = latin.Replace("3", "е");
            latin = latin.Replace("7", "т");
            latin = latin.Replace("ch", "ч");
            latin = latin.Replace("ia", "я");
            latin = latin.Replace("iu", "ю");
            latin = latin.Replace("sht", "щ");

            latin = latin.Replace("a", "а");
            latin = latin.Replace("b", "б");
            latin = latin.Replace("v", "ж");
            latin = latin.Replace("g", "г");
            latin = latin.Replace("d", "д");
            latin = latin.Replace("e", "е");
            latin = latin.Replace("w", "в");
            latin = latin.Replace("z", "з");
            latin = latin.Replace("i", "и");
            latin = latin.Replace("j", "й");
            latin = latin.Replace("k", "к");
            latin = latin.Replace("a", "а");
            latin = latin.Replace("l", "л");
            latin = latin.Replace("m", "м");
            latin = latin.Replace("n", "н");
            latin = latin.Replace("o", "о");
            latin = latin.Replace("p", "п");
            latin = latin.Replace("r", "р");
            latin = latin.Replace("s", "с");
            latin = latin.Replace("t", "т");
            latin = latin.Replace("u", "у");
            latin = latin.Replace("f", "ф");
            latin = latin.Replace("h", "х");
            latin = latin.Replace("c", "ц");
            latin = latin.Replace("`", "ч");
            latin = latin.Replace("[", "ш");
            latin = latin.Replace("]", "щ");
            latin = latin.Replace("y", "ъ");
            latin = latin.Replace("x", "ь");
            latin = latin.Replace("\\", "ю");
            latin = latin.Replace("q", "я");

            

            return latin;
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////




        
        static string PhoneticTraditional(string latin)
        {
            latin = latin.Replace("6", "ш");
            latin = latin.Replace("4", "ч");
            latin = latin.Replace("3", "е");
            latin = latin.Replace("7", "т");
            latin = latin.Replace("ch", "ч");
            latin = latin.Replace("ia", "я");
            latin = latin.Replace("iu", "ю");
            latin = latin.Replace("sh", "ш");
            latin = latin.Replace("sht", "щ");
            latin = latin.Replace("tc", "ц");

            latin = latin.Replace("d", "а");
            latin = latin.Replace("/", "б");
            latin = latin.Replace(";", "в");
            latin = latin.Replace("j", "г");
            latin = latin.Replace("o", "д");
            latin = latin.Replace("e", "е");
            latin = latin.Replace("g", "ж");
            latin = latin.Replace("p", "з");
            latin = latin.Replace("r", "и");
            latin = latin.Replace("x", "й");
            latin = latin.Replace("u", "к");
            latin = latin.Replace(".", "л");
            latin = latin.Replace("'", "м");
            latin = latin.Replace("l", "н");
            latin = latin.Replace("f", "о");
            latin = latin.Replace("m", "п");
            latin = latin.Replace(",", "р");
            latin = latin.Replace("i", "с");
            latin = latin.Replace("k", "т");
            latin = latin.Replace("w", "у");
            latin = latin.Replace("b", "ф");
            latin = latin.Replace("n", "х");
            latin = latin.Replace("[", "ц");
            latin = latin.Replace("\\", "ч");
            latin = latin.Replace("t", "ш");
            latin = latin.Replace("y", "щ");
            latin = latin.Replace("c", "ъ");
            latin = latin.Replace("a", "ь");
            latin = latin.Replace("z", "ю");
            //latin = latin.Replace("iy", "ю");
            //latin = latin.Replace("yi", "ю");
            //latin = latin.Replace("ui", "ю");
            latin = latin.Replace("s", "я");

           

            return latin;
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        
        static string Phonetic(string latin)
        {
            //тук са тежките случаи от времето на мирката четворки и шестици за ч и ш
            latin = latin.Replace("6", "ш");
            latin = latin.Replace("4", "ч");
            latin = latin.Replace("3", "е");
            latin = latin.Replace("7", "т");
            latin = latin.Replace("ch", "ч");
            latin = latin.Replace("ia", "я");
            latin = latin.Replace("iu", "ю");
            latin = latin.Replace("sh", "ш");
            latin = latin.Replace("sht", "щ");
            latin = latin.Replace("tc", "ц");

            latin = latin.Replace("a", "а");
            latin = latin.Replace("b", "б");
            latin = latin.Replace("v", "в");
            latin = latin.Replace("g", "г");
            latin = latin.Replace("d", "д");
            latin = latin.Replace("e", "е");
            latin = latin.Replace("x", "ж");
            latin = latin.Replace("z", "з");
            latin = latin.Replace("i", "и");
            latin = latin.Replace("j", "й");
            latin = latin.Replace("k", "к");
            latin = latin.Replace("l", "л");
            latin = latin.Replace("m", "м");
            latin = latin.Replace("n", "н");
            latin = latin.Replace("o", "о");
            latin = latin.Replace("p", "п");
            latin = latin.Replace("r", "р");
            latin = latin.Replace("s", "с");
            latin = latin.Replace("t", "т");
            latin = latin.Replace("u", "у");
            latin = latin.Replace("f", "ф");
            latin = latin.Replace("h", "х");
            latin = latin.Replace("c", "ц");
            latin = latin.Replace("q", "ч");
            latin = latin.Replace("w", "ш");
            latin = latin.Replace("]", "щ");
            latin = latin.Replace("y", "ъ");
            latin = latin.Replace("\\", "ь");
            latin = latin.Replace("`", "ю");
            latin = latin.Replace("[", "я");

            

            return latin;
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static string BulgarianTypewritter(string latin)
        {
            //тук са тежките случаи от времето на мирката четворки и шестици за ч и ш
            latin = latin.Replace("6", "ш");
            latin = latin.Replace("4", "ч");
            latin = latin.Replace("3", "е");
            latin = latin.Replace("7", "т");
            latin = latin.Replace("ch", "ч");
            latin = latin.Replace("ia", "я");
            latin = latin.Replace("iu", "ю");
            latin = latin.Replace("sh", "ш");
            latin = latin.Replace("sht", "щ");
            latin = latin.Replace("tc", "ц");

            latin = latin.Replace("d", "а");
            latin = latin.Replace("/", "б");
            latin = latin.Replace(";", "в");
            latin = latin.Replace("h", "г");
            latin = latin.Replace("o", "д");
            latin = latin.Replace("e", "е");
            latin = latin.Replace("g", "ж");
            latin = latin.Replace("p", "з");
            latin = latin.Replace("r", "и");
            latin = latin.Replace("x", "й");
            latin = latin.Replace("u", "к");
            latin = latin.Replace(".", "л");
            latin = latin.Replace(";", "м");
            latin = latin.Replace("k", "н");
            latin = latin.Replace("f", "о");
            latin = latin.Replace("m", "п");
            latin = latin.Replace(",", "р");
            latin = latin.Replace("i", "с");
            latin = latin.Replace("j", "т");
            latin = latin.Replace("w", "у");
            latin = latin.Replace("b", "ф");
            latin = latin.Replace("n", "х");
            latin = latin.Replace("[", "ц");
            latin = latin.Replace("'", "ч");
            latin = latin.Replace("t", "ш");
            latin = latin.Replace("y", "щ");
            latin = latin.Replace("c", "ъ");
            latin = latin.Replace("a", "ь");
            latin = latin.Replace("z", "ю");
            latin = latin.Replace("s", "я");

           

            return latin;
        }



        //примат език  (я - q, ia) , (ч - ch, 4) , (ш - sh, 6) , (у,ь - u),  
        static string Idiots(string latin)
        {
            //тук са тежките случаи от времето на мирката четворки и шестици за ч и ш
            latin = latin.Replace("6", "ш");
            latin = latin.Replace("4", "ч");
            latin = latin.Replace("3", "е");
            latin = latin.Replace("7", "т");
            latin = latin.Replace("ch", "ч");
            latin = latin.Replace("ia", "я");
            latin = latin.Replace("iu", "ю");
            latin = latin.Replace("sht", "щ");
            latin = latin.Replace("tc", "ц");

            latin = latin.Replace("a", "а");
            latin = latin.Replace("b", "б");
            latin = latin.Replace("v", "в");
            latin = latin.Replace("g", "г");
            latin = latin.Replace("d", "д");
            latin = latin.Replace("e", "е");
            latin = latin.Replace("w", "ж");
            latin = latin.Replace("z", "з");
            latin = latin.Replace("i", "и");
            latin = latin.Replace("j", "й");
            latin = latin.Replace("k", "к");
            latin = latin.Replace("a", "а");
            latin = latin.Replace("l", "л");
            latin = latin.Replace("m", "м");
            latin = latin.Replace("n", "н");
            latin = latin.Replace("o", "о");
            latin = latin.Replace("p", "п");
            latin = latin.Replace("r", "р");
            latin = latin.Replace("s", "с");
            latin = latin.Replace("t", "т");
            latin = latin.Replace("y", "у");
            latin = latin.Replace("f", "ф");
            latin = latin.Replace("h", "х");
            latin = latin.Replace("c", "ц");
            latin = latin.Replace("`", "ч");
            latin = latin.Replace("[", "ш");
            latin = latin.Replace("]", "щ");
            latin = latin.Replace("y", "у");
            latin = latin.Replace("u", "ь");
            latin = latin.Replace("\\", "ю");
            latin = latin.Replace("q", "я");



            return latin;
        } 








        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string in Latinic to be converted to cyrillic: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string latin = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            string bulgarian = string.Empty;
            string phonetTrad = string.Empty;
            string phonetic = string.Empty;
            string bulgTypewritter = string.Empty;
            string idiots = string.Empty;



            if (latin.Any(char.IsUpper))
            {
                latin = latin.ToLower();
                bulgarian = Bulgarian(latin);
                phonetTrad = PhoneticTraditional(latin);
                phonetic = Phonetic(latin);
                bulgTypewritter = BulgarianTypewritter(latin);
                idiots = Idiots(latin);

                bulgarian = bulgarian.ToUpper();
                phonetTrad = phonetTrad.ToUpper();
                phonetic = phonetic.ToUpper();
                bulgTypewritter = bulgTypewritter.ToUpper();
                idiots = idiots.ToUpper();

                //latin = latin.ToUpper();

                Console.WriteLine();
                Console.WriteLine("Your converted string in Bulgaran now is: ");
                Console.WriteLine(bulgarian);
                Console.WriteLine();
                Console.WriteLine("Your converted string in Phonetic Traditional now is: ");
                Console.WriteLine(phonetTrad);
                Console.WriteLine();
                Console.WriteLine("Your converted string in Phonetic now is: ");
                Console.WriteLine(phonetic);
                Console.WriteLine();
                Console.WriteLine("Your converted string in Bulgaran Typewritter now is: ");
                Console.WriteLine(bulgTypewritter);
                Console.WriteLine();
                Console.WriteLine("Your converted string in Idiots language now is: ");
                Console.WriteLine(idiots);
                Console.WriteLine();

                Console.WriteLine("Do you want to copy some of cyrillic text on clipboard? Yes:No");
                Console.ForegroundColor = ConsoleColor.Green;
                string toCopy = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (toCopy == "yes")
                {
                    Console.WriteLine("Which text do you want to copy: ");
                    Console.WriteLine("1.Bulgarian. \n2.Phonetic Traditional. \n3.Phonetic. \n4.Bulgarian Typewritter");
                    Console.Write("Choose from 1 to 4");
                    string answer = Console.ReadLine();
                    int answerInt = 0;

                    while (!int.TryParse(answer, out answerInt))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong data type. I expect number not this shit -> {0}", answer);
                        Console.WriteLine("Try again to enter something useful");
                        Console.ForegroundColor = ConsoleColor.Green;
                        answer = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (answerInt)
                    {
                        case 1:
                            Clipboard.SetText(bulgarian);
                            Console.WriteLine("The tex in Bulgarian was successfully copied on clipboard");
                            break;
                        case 2:
                            Clipboard.SetText(phonetTrad);
                            Console.WriteLine("The tex in Phonetic Traditional was successfully copied on clipboard");
                            break;
                        case 3:
                            Clipboard.SetText(phonetic);
                            Console.WriteLine("The tex in Phonetic was successfully copied on clipboard");
                            break;
                        case 4:
                            Clipboard.SetText(bulgTypewritter);
                            Console.WriteLine("The tex in Bulgarian Typewriter was successfully copied on clipboard");
                            break;
                        default:
                            Console.WriteLine("Sorry. Not exists that menu. Try again (1-4)");
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.Gray;

                }


                //Console.WriteLine("Do you want to copy translate to clipboard? Yes : NO");
                //string toCopy = Console.ReadLine().ToLower();
                //if (toCopy == "yes")
                //{
                //    Clipboard.SetText(latin);
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.WriteLine("The text was copied successfull on clipboard. You can paste it anywhere.");
                //    Console.ForegroundColor = ConsoleColor.Gray;
                //}



            }
            else
            {
                //latin = BulgarianTypewritter(latin);
                bulgarian = Bulgarian(latin);
                phonetTrad = PhoneticTraditional(latin);
                phonetic = Phonetic(latin);
                bulgTypewritter = BulgarianTypewritter(latin);
                idiots = Idiots(latin);

                //bulgarian = bulgarian.ToUpper();
                //phonetTrad = phonetTrad.ToUpper();
                //phonetic = phonetic.ToUpper();
                //bulgTypewritter = bulgTypewritter.ToUpper();

                Console.WriteLine();
                Console.WriteLine("Your converted string in Bulgarian now is: ");
                Console.WriteLine(bulgarian);
                Console.WriteLine();
                Console.WriteLine("Your converted string in Phonetic Traditional now is: ");
                Console.WriteLine(phonetTrad);
                Console.WriteLine();
                Console.WriteLine("Your converted string in Phonetic now is: ");
                Console.WriteLine(phonetic);
                Console.WriteLine();
                Console.WriteLine("Your converted string in Bulgaran Typewritter now is: ");
                Console.WriteLine(bulgTypewritter);
                Console.WriteLine();
                Console.WriteLine("Your converted string in Idiot language now is: ");
                Console.WriteLine(idiots);
                Console.WriteLine();


                Console.WriteLine("Do you want to copy some of cyrillic text on clipboard? Yes:No");
                Console.ForegroundColor = ConsoleColor.Green;
                string toCopy = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (toCopy == "yes")
                {
                    Console.WriteLine("Which text do you want to copy: ");
                    Console.WriteLine("1.Bulgarian. \n2.Phonetic Traditional. \n3.Phonetic. \n4.Bulgarian Typewritter");
                    Console.Write("Choose from 1 to 4: ");
                    Console.ForegroundColor = ConsoleColor.Green;

                    string answer = Console.ReadLine();
                    int answerInt = 0;

                    while (!int.TryParse(answer, out answerInt))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong data type. I expect number not this shit -> {0}", answer);
                        Console.WriteLine("Try again to enter something useful");
                        Console.ForegroundColor = ConsoleColor.Green;
                        answer = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (answerInt)
                    {
                        case 1:
                            Clipboard.SetText(bulgarian);
                            Console.WriteLine("The tex in Bulgarian was successfully copied on clipboard");
                            break;
                        case 2:
                            Clipboard.SetText(phonetTrad);
                            Console.WriteLine("The tex in Phonetic Traditional was successfully copied on clipboard");
                            break;
                        case 3:
                            Clipboard.SetText(phonetic);
                            Console.WriteLine("The tex in Phonetic was successfully copied on clipboard");
                            break;
                        case 4:
                            Clipboard.SetText(bulgTypewritter);
                            Console.WriteLine("The tex in Bulgarian Typewriter was successfully copied on clipboard");
                            break;
                        default:
                            Console.WriteLine("Sorry. Not exists that menu. Try again (1-4)");
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.Gray;

                }

                //Console.WriteLine("Do you want to copy translate to clipboard? Yes : NO");
                //string toCopy = Console.ReadLine().ToLower();
                //if (toCopy == "yes")
                //{
                //    Clipboard.SetText(latin);
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.WriteLine("The text was copied successfull on clipboard. You can paste it anywhere.");
                //    Console.ForegroundColor = ConsoleColor.Gray;
                //}
            }


            Console.ReadLine();

        }
    }
}
