using System;
using System.Collections.Generic;
using System.Linq;

/*
* Programming Challenge from HackerRank - DiagonalDifference
* Given a square matrix, calculate the absolute difference between the sums of its diagonals.
* 
* Stdin : 3
* Stdin : 1 2 3
*         4 5 6
*         9 8 9
* StdOut : 2
* 
* FisrtDiagonal = 1 + 5 + 9 = 15
* SecondDiagonal = 3 + 5 + 9 = 17
* Absolute Difference = |15 - 17| = 2
* 
* Author : lrasata
*/

namespace DiagonalDifference
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */
        public static bool CheckNumberLimit(int number)
        {
            if (number > 100 || number < -100)
            {
                Console.WriteLine("Numbers must be between -100 and 100");
                return false;
            }
            return true;

        }
        public static int diagonalDifference(List<List<int>> arr, int n)
        {
            int differenceDiagonal = -1;
            if (arr.Count != n)
            {
                Console.WriteLine("matrix should NxN dimension");
            }
            else
            {
                int sumFirstDiagonal = 0;
                int sumSecondDiagonal = 0;
                for(int i = 0; i < arr.Count; i++)
                { 
                    if (!CheckNumberLimit(arr[i][i]))
                    {
                        return differenceDiagonal;
                    }
                    sumFirstDiagonal += arr[i][i];
                    if (!CheckNumberLimit(arr[i][arr.Count - i - 1]))
                    {
                        return differenceDiagonal;
                    }
                    sumSecondDiagonal += arr[i][arr.Count - i - 1];
               
                }
                differenceDiagonal = Math.Abs(sumFirstDiagonal - sumSecondDiagonal) ;
                

            }
            return differenceDiagonal;

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr, n);
            Console.WriteLine(result);
        }

    }
}
