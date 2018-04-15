using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _9_28ClassStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int quanWeights;
            int[] weights = new int[15];
            int low;
            int high;
            int sum;
            int avg;

            quanWeights = FillArray(weights);

            WriteLine(quanWeights);

            for (int x = 0; x < quanWeights; ++x)
            {
                WriteLine(weights[x]);
            }

            Statistics(weights, quanWeights, out low, out high, out sum, out avg);

            WriteLine("Low is {0} and high is {1} and sum is {2} and avg is {3}", low, high, sum, avg);
            ReadLine();

        }

        private static void Statistics(int[] weightArray, int quantity, out int low, out int high, out int sum, out int avg)
        {
            sum = 0;
            low = weightArray[0];
            high = weightArray[0];
            avg = weightArray[0];

            for (int x = 0; x < quantity; ++x)
            {
                sum = sum + weightArray[x];
                if (low > weightArray[x])
                {
                    low = weightArray[x];
                }
                if (high < weightArray[x])
                {
                    high = weightArray[x];
                }
            }
            if (quantity != 0)
            {
                avg = sum / quantity;
            }
        }

        private static int FillArray(int[] weightArray)
        {
            string strWeight;
            int weight = 0;
            int position = 0;

            Write("Key in a weight, or 999 to quit.  ");

            while (position < 15 && weight != 999)
            {
                strWeight = ReadLine();

                if (int.TryParse(strWeight, out weight))
                {
                    if (weight != 999)
                    {
                        weightArray[position] = weight;
                        ++position;
                        Write("Key in the next weight:  ");
                    }
                }
                else
                {
                    Write("Invalid, key in a valid number for weight");
                }
            }

            return position;


        }
    }
}