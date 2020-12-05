using System;
using System.Collections.Generic;
using System.Linq;

namespace Domaci_Cas23
{
    class BasicStats
    {

        public static int GetLowest(List<int> Numbers)
        {
            int LowestNumber = Numbers.First();

            foreach(int Number in Numbers)
            {
                if (Number < LowestNumber)
                {
                    LowestNumber = Number;
                }
            }

            return LowestNumber;
        }

        public static int GetHighest(List<int> Numbers)
        {
            int HighestNumber = 0;

            foreach(int Number in Numbers)
            {
                if (Number > HighestNumber)
                {
                    HighestNumber = Number;
                }
            }

            return HighestNumber;
        }

        public static int GetSum(List<int> Numbers)
        {
            int sum = 0;
            foreach(int Number in Numbers)
            {
                sum += Number;
            }

            return sum;
        }
        public static double GetAverage(List<int> Numbers)
        {
            return (double) GetSum(Numbers) / (double) Numbers.Count();
        }

    }
}
