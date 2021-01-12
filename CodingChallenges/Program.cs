using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Does this work");
            long theSum = 0;
            int whileLoopInt = 1;

            while (whileLoopInt < 1000)
            {
                if (whileLoopInt % 3 == 0 || whileLoopInt % 5 == 0)
                {
                    theSum = theSum + whileLoopInt;
                }

                whileLoopInt++;
            }

            Console.WriteLine(theSum);
            //I got 233168
        }
    }
}
