using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort_Algorithm_Test
{
    class Program
    {
        static void Main(string[] args)
        {
           //int counter = 0;
            Console.WriteLine("How many numbers would you like to analyze?");


            int inputs = int.Parse(Console.ReadLine());


            int[] numbers = new int[inputs];
            int[] sortedNumbers = new int[inputs];

            for (int i = 0; i < inputs; i++)
            {
                Console.Clear();
                Console.Write("Enter a number: ");
                int entered = int.Parse(Console.ReadLine());
                numbers[i] = entered;
            }
            
            sortedNumbers = mergeSort(numbers);

            for (int f = 0; f < numbers.Length; f++)
            {
                Console.Write(sortedNumbers[f] + ", ");
            }
        }

        public static int[] mergeSort(int[] numbers)
        {

            int length = numbers.Length;

            if (length < 2)
            {
                return numbers;
            }
            else
            {
                int[][] a = split(numbers);
                int[] left, right;


                left = a[0];
                right = a[1];
                int[] result = new int[left.Length + right.Length];

                Console.WriteLine(result.Length + "lengRes");

                result = merge(mergeSort(left), mergeSort(right));
                return result;
            }


        }
        public static int[] merge(int[] left, int[] right)
        {
           int counter = 0, leftIndex = 0, rightIndex = 0;
        int[] result = new int[left.Length + right.Length];

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {

                    result[counter] = left[leftIndex];
                    leftIndex = leftIndex + 1;
                    counter = counter + 1;
                }
                else
                {
                    result[counter] = right[rightIndex];
                    rightIndex = rightIndex + 1;
                    counter = counter + 1;
                }
            }

            Console.WriteLine(leftIndex + "!!");
            Console.WriteLine(rightIndex + "!");
            Console.WriteLine(right.Length + " ! " + left.Length + " ! " + result.Length);

            while (0 > left.Length)
            {
                for (int p = 0; p < leftIndex; p++)
                {
                    result[counter] = left[p];
                    counter = counter + 1;
                }
            }
            while(0 > right.Length)
            {
                for (int p = 0; p < rightIndex; p++)
                {
                    result[counter] = right[p];
                    counter = counter + 1;
                }
            }
            

            return result;
        }
        public static int[][] split(int[] numbers)
        {
            int[] left, right;


            int b = 0, c = 0;

            if (numbers.Length % 2 == 0)
            {
                b = numbers.Length / 2;
                c = numbers.Length / 2;
            }
            else if (numbers.Length % 2 == 1)
            {
                b = numbers.Length / 2;
                c = numbers.Length / 2 + 1;
            }
            left = new int[b];
            right = new int[c];

            for (int o = 0; o < b; o++)
            {
                left[o] = numbers[o];
            }
            for (int o = 0; o < right.Length; o++)
            {
                right[o] = numbers[o + b];
            }


            int[][] a = new int[][] { left, right };
            return a;

        }


    }
}