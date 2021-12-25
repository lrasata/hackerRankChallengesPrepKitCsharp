using System.IO;
using System;

/*
* Programming Challenge from HackerRank - TimeConversion
* Given a time in -hour AM/PM format, convert it to military (24-hour) time.
* Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
*       - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
* 
* Stdin : 07:05:45PM
* Stdout : 19:05:45
* 
* Author : lrasata
*/
namespace TimeConversion
{
    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string TimeConversion(string s)
        {
            DateTime d = DateTime.Parse(s);
            return d.ToString("HH:mm:ss");
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.TimeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
