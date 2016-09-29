using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace junk
{
    class Program
    {

      


        public static int[] ConvertToArrayOfDigits(int value)
        {
           
            int n = 4;
            int d = 1;

            //count and square, assign to array
            int[] squaredArray = new int[n + 1];
            int count2 = 0;
            for (int i = 0; i < n + 1; i++)
            {
                //create array of 0 - n 
                squaredArray[i] =  count2 * count2;
                count2++;
            }
            
            //determine how long next array needs to be by 'counting' all digit in square array elements
            int count3 = 0;
            for (int i = 0; i < squaredArray.Length; i++)
            {
                count3 = count3 + squaredArray[i].ToString().Length;
            }



            Console.WriteLine("There are {0} digits in the set after each item in set is squared",count3);
            int size2 = count3;

            //create array to split squared array values into. Length of this array is size2 = count3




            Console.ReadKey();

            int targetDigitCount = 0;
            
            //how many digits in value assigned to int size
            //int size = DetermineDigitCount(value);

            //array created length of int size.. this will hold all separated digits
            int[] digits = new int[size2];

            //sequentially assign each digit of value to digits[ ]
            for (int index = 0; index < size2; index++)
            {
                digits[index] = squaredArray[index] % 10;
                squaredArray[index] = squaredArray[index] / 10;

                //count number of times d occurs in digits[]
                if (digits[index] == d)
                {
                    targetDigitCount++;
                }

            }
    

          

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" d occurs {0} times", targetDigitCount);
            return digits;
        }

        private static int DetermineDigitCount(int x)
        {
            // This bit could be optimised with a binary search
            return x < 10 ? 1
                 : x < 100 ? 2
                 : x < 1000 ? 3
                 : x < 10000 ? 4
                 : x < 100000 ? 5
                 : x < 1000000 ? 6
                 : x < 10000000 ? 7
                 : x < 100000000 ? 8
                 : x < 1000000000 ? 9
                 : 10;
        }

        static void Main(string[] args)
        {
            ConvertToArrayOfDigits(34445444);

            Console.ReadKey();
        }
    }
}
