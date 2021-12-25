using System;
using System.Collections.Generic;
using System.Linq;

/*
* Programming Challenge from HackerRank - MinMaxSum
* Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
* Then print the respective minimum and maximum values as a single line of two space-separated long integers.
* 
* Stdin : 1 2 3 4 5
* StdOut : 10 14
* 
* The min of the sum of 4 items is 1 + 2 + 3 + 4.
* The max sum of 4 items is 2 + 3 + 4 + 5.
* 
* Author : lrasata
*/

namespace MiniMaxSum
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr, int elementNumber, int numberOfElementstoSum)
        {
            
            if (arr.Count != elementNumber)
            {
                Console.WriteLine("Array Input must have 5 elements");
                return;
            } else
            {
                arr.Sort();
                double min = 0;
                for (int index = 0; index < numberOfElementstoSum; index++)
                {
                    min = arr[index] + min;
                }
                double max = 0;
                for (int index = 1; index < arr.Count; index++)
                {
                    max = arr[index] + max;
                }
                Console.WriteLine(min + " " + max);

            }

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int elementNumber = 5;
            int numberOfElementstoSum = 4;
            Result.miniMaxSum(arr, elementNumber, numberOfElementstoSum);
        }
    }
}
