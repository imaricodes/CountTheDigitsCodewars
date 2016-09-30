using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace junk
{
    class Program
    {

      


        public static int ConvertToArrayOfSquaredDigits(int n, int d)
        {
           
            //count and square, convert to string, assign to string array
            string [] squaredArray = new string[n + 1];
            int count2 = 0;
            for (int i = 0; i < n + 1; i++)
            {
                //create array of 0 - n
                string result = (count2 * count2).ToString(); 
                squaredArray[i] =  result;
                count2++;
            }
            
            //create charList that will contain chars parsed from  squaredArray[] string elements
            List<char> charList = new List<char>();

            for (int i = 0; i < squaredArray.Length; i++)
            { 
                //split squaredArray sting elements into chars[]
                var chars = squaredArray[i].ToCharArray();

                //loop through chars[], adding each char element to charList<>
                foreach (var item in chars)
                {
                    charList.Add(item);
                }
            }

            //intitialize counter for recording how many times d (passed in as argument) occurs in charList<> 
            int targetDigitCounter = 0;

            //loop over charList<> and compare each element to d
            for (int i = 0; i < charList.Count; i++)
            {
                if (charList[i].ToString() == d.ToString())
                {
                    targetDigitCounter++;
                    Console.WriteLine("Current Target Digit Count: " + targetDigitCounter);
                }

            }

          

            return targetDigitCounter;
            
        }


        static void Main(string[] args)
        {
            int d = 6;
            int result = ConvertToArrayOfSquaredDigits(5,d);

            Console.WriteLine("d is: " + d);
            Console.WriteLine(" d occurs {0} times in the set", result);
            Console.ReadKey();
        }

    }
}
