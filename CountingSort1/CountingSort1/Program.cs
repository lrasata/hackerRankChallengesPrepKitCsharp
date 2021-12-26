using System;
using System.Collections.Generic;
using System.Linq;

/*
* Programming Challenge from HackerRank - Counting Sort 1
* Another sorting method, the counting sort, does not require comparison. 
* Instead, you create an integer array whose index range covers the entire range of values 
* in your array to sort. Each time a value occurs in the original array, 
* you increment the counter at that index. 
* At the end, run through your counting array, 
* printing the value of each non-zero valued index that number of times.
* 
* Input :
* 4
* 1 1 3 2 1 1
* 
* Output :
* 0 4 1 3
* 
* Author : lrasata
*/

namespace CountingSort1
{
    class Result
    {

        /*
         * Complete the 'countingSort' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static List<int> countingSort(List<int> arr, int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                result.Add(0);
            }
            for (int j = 0; j < arr.Count; j++)
            {
                result[arr[j]]++;
            }
            return result;

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.countingSort(arr, n);

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
