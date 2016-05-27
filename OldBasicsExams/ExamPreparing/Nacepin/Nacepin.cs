using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nacepin
{
    class Nacepin
    {

        static decimal biggest(decimal us, decimal uk, decimal chinese)
        {
            decimal result = Math.Max(Math.Max(us, uk), chinese);
            return result;
        }



        static decimal minimal(decimal us, decimal uk, decimal chinese)
        {
            decimal result = Math.Min(Math.Min(us, uk), chinese);
            return result;
        }






        static void Main(string[] args)
        {
            #region currencies
            decimal usd = 0.58m;
            decimal gbp = 0.41m;
            decimal cny = 0.27m;
            #endregion



            #region variables
            decimal USstore = decimal.Parse(Console.ReadLine());
            decimal boxWeightInUSA = decimal.Parse(Console.ReadLine());
            decimal UKstore = decimal.Parse(Console.ReadLine());
            decimal boxWeightInUK = decimal.Parse(Console.ReadLine());
            decimal ChineseStore = decimal.Parse(Console.ReadLine());
            decimal boxWeightChinese = decimal.Parse(Console.ReadLine());
            #endregion#

            #region results
            decimal USresult = (USstore / usd) / (decimal)boxWeightInUSA;
            decimal UKresult = (UKstore / gbp) / (decimal)boxWeightInUK;
            decimal ChineseResult = (ChineseStore * cny) / (decimal)boxWeightChinese;

            #endregion

            decimal big = biggest(USresult, UKresult, ChineseResult);
            decimal min = minimal(USresult, UKresult, ChineseResult);
            decimal saved = big - min;



            //Console.WriteLine("{0:f2} lv", biggest(USresult, UKresult, ChineseResult));
            //Console.WriteLine("{0:f2} lv", minimal(USresult, UKresult, ChineseResult));

            if (min == USresult)
            {
                Console.WriteLine("US online store. {0:f2} lv/kg", min);
            }
            else if(min == UKresult)
            {
                Console.WriteLine("UK online store. {0:f2} lv/kg", min);
            }
            else
            {
                Console.WriteLine("Chinese store. {0:f2} lv/kg", min);
            }
            Console.WriteLine("Difference {0:f2} lv/kg", saved);



        }
    }
}
