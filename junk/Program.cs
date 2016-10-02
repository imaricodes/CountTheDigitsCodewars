using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Codewars kata: Count the Digit
//Input: n = any number 0 - n; d = any number >= 0 and <=9
//Square all numbers 0-n (including 0 and n). How many times does digit d occur in all numbers produced?
//Note: Looking at other solutions, this can be refactored greatly. Linq and Enumerable seem to be good tools to do this. To do list.

namespace junk
{
    class Program
    {

        //My solution:

        public static int NbDig(int n, int d)
        {

            //count and square 0-n, convert each squared result to string, assign to string type squaredArray[]
            string[] squaredArray = new string[n + 1];
            int count2 = 0;
            for (int i = 0; i < n + 1; i++)
            {
                //create array of 0 - n
                string result = (count2 * count2).ToString();
                squaredArray[i] = result;
                count2++;
            }


            //create charList<char> that will contain chars parsed from squaredArray[] string elements
            List<char> charList = new List<char>();

            for (int i = 0; i < squaredArray.Length; i++)
            {
                //split squaredArray sting elements into chars[]
                var chars = squaredArray[i].ToCharArray();

                //loop through chars[], adding each char element to charList<char>
                foreach (var item in chars)
                {
                    charList.Add(item);
                }
            }


            //intitialize counter for recording how many times d (passed in as argument) occurs in charList<char> 
            int targetDigitCounter = 0;

            //loop over charList<> and compare each element to d, if equality found, increment targetDigitCounter
            for (int i = 0; i < charList.Count; i++)
            {
                if (charList[i].ToString() == d.ToString())
                {
                    targetDigitCounter++;

                }

            }


            //return targetDigitCounter, which indicates how many times d occurs in set
            return targetDigitCounter;

        }
        

        //More efficient solutions from Kata users:

        /*public static int NbDig(int n, int d)
        {
            return Enumerable.Range(0, n + 1).Sum(i => (i * i).ToString().Count(c => c == d.ToString().First()));
        }
        */

        //or

        /*public static int NbDig(int n, int d)
        {
            return 
                Enumerable.Range(0, n + 1)
                    .Select(number => Math.Pow(number, 2))
                    .Select(number => $"{number}".ToCharArray())
                    .Sum(number => number.Count(dig => dig == Convert.ToChar(d + 48)));
        }
        */


        static void Main(string[] args)
        {
            int d = 2;
            int n = 5;
            int result = NbDig(n, d);
            Console.WriteLine();
            Console.WriteLine("d is: " + d);
            Console.WriteLine();
            Console.WriteLine("d occurs {0} times in the set", result);
            Console.ReadKey();
        }

    }
}
