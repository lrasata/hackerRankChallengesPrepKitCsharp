using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

/*
* Programming Challenge from HackerRank - LonelyInteger
* Given an array of integers, where all elements but one occur twice, find the unique element.
* Example : [1 2 3 4 3 2 1] - The unique element is 4.
* 
* Stdin : 5
* Stdin : 1 2 3 2 1
* StdOut : 3
* 
* 
* Author : lrasata
*/

namespace LonelyInteger
{
    class Result
    {

        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int LonelyInteger(List<int> a, int n)
        {
            if (a.Count != n)
            {
                Console.WriteLine("Size of the array must be N.");
                return -1;
            } else
            {
                if (n < 1 || n > 100)
                {
                    Console.WriteLine("N must be an integer between 1 and 100");
                    return -1;
                }
                else
                {
                    a.Sort();
                    if (a.Count == 1)
                    {
                        return a[0]; 
                    } else
                    {
                        for (int i = 0; i < n; i = i + 2)
                        {
                            if ( i + 1  == a.Count )
                            {
                                return a[i];
                            } else
                            {
                                if (a[i] != a[i + 1])
                                {
                                    return a[i];

                                }
                            }

                        }

                    }
                    return -1;

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

            Console.WriteLine(Result.LonelyInteger(arr, n));
        }
    }
}
