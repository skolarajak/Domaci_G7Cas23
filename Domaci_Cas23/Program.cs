using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_Cas23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            string UserInput;

            do
            {
                Console.Write("Unesite broj (ostaviti prazno za kraj rada) >");
                UserInput = Console.ReadLine();

                if (UserInput != "")
                {
                    Numbers.Add(Convert.ToInt32(UserInput));
                }

            } while (UserInput != "");

            Console.WriteLine("GetLowest = {0}", BasicStats.GetLowest(Numbers));
            Console.WriteLine("GetHighest = {0}", BasicStats.GetHighest(Numbers));
            Console.WriteLine("GetAverage = {0}", BasicStats.GetAverage(Numbers));
            Console.WriteLine("GetSum = {0}", BasicStats.GetSum(Numbers));
            Console.ReadKey();
        }
    }
}
