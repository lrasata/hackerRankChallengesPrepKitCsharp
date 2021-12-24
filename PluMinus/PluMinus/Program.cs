using System;
using System.Collections.Generic;
using System.Linq;

/*
* Programming Challenge from HackerRank - PlusMinus
* Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
* Print the decimal value of each fraction on a new line with  places after the decimal.
* 
* Stdin : 6
* Stdin : -4 3 -9 0 4 1
* Result : 
* 0.500000
* 0.333333
* 0.166667
* 
* Here the array has n=6 elements, 3 positive integers, 2 negative integers, and 1 zero
* Result are 3/6 = 0.500000, 2/6 = 0.333333, 1/6 = 0.166667
* 
* Author : lrasata
*/

namespace PluMinus
{
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static bool IsNaturalNumberAndLessThan100(int n )
        {
            if ( n >= 0 || n <= 100)
            {
                return true;
            } 
            return false;
        }

        public static bool IsIntegerAndLessThan100(int n)
        {
            if (n>100 || n<-100)
            {
                return false;
            }
            return true;

        }
        public static void PlusMinus(List<int> arr, int n)
        {
            if (arr.Count != n)
            {
                Console.WriteLine("The size of your array should be equal to n");
            } else
            {
                if (Result.IsNaturalNumberAndLessThan100(n))
                {
                    int positive = 0;
                    int negative = 0;
                    int zero = 0;
                    foreach(int i in arr)
                    {
                        if (Result.IsIntegerAndLessThan100(i))
                        {
                            if (i > 0)
                            {
                                positive++;
                            }
                            if ( i < 0)
                            {
                                negative++;
                            }
                            if ( i == 0)
                            {
                                zero++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("I should be and Inetegr between -100 and 100");
                            return;
                        }
                    }
                    decimal positiveRatio = positive / (decimal) n;
                    decimal negativeRatio = negative / (decimal) n;
                    decimal zeroRatio = zero / (decimal) n;

                    Console.WriteLine(decimal.Round(positiveRatio, 6));
                    Console.WriteLine(decimal.Round(negativeRatio, 6));
                    Console.WriteLine(decimal.Round(zeroRatio, 6));

                }
                else
                {
                    Console.WriteLine("N should be between 0 and 1OO");
                }
            }

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.PlusMinus(arr, n);
        }
    }

}
