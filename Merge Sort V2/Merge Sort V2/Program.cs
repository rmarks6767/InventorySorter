using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes input from the user of how many numbers they would like to sort
            Console.WriteLine("How many numbers would you like to analyze?");
            int inputs = int.Parse(Console.ReadLine());
            //initializes an array of numbers from the number of inputs received from the user
            int[] numbers = new int[inputs];
            int[] sortedNumbers = new int[inputs];  //This array will be the place the final sorted values are stored

            //collects the input from the user and sets it equal to the numbers array
            for (int i = 0; i < inputs; i++)
            {
                Console.Clear();
                Console.Write("Enter a number: ");
                int entered = int.Parse(Console.ReadLine());
                numbers[i] = entered;
            }

            sortedNumbers = MergeSort(numbers);

            for (int f = 0; f < numbers.Length; f++)
            {
                Console.Write(sortedNumbers[f] + ", ");
            }
        }

        static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int counter = 0, leftIndex = 0, rightIndex = 0;


            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[0] < right[0])
                {
                    result[counter] = left[0];

                    int[] savedValueL = new int[left.Length - 1];
                    for (int p = 0; p < savedValueL.Length; p++)
                    {
                        savedValueL[p] = left[p + 1];
                    }
                    left = new int[left.Length - 1];
                    for (int g = 0; g < left.Length; g++)
                    {
                        left[g] = savedValueL[g];
                    }
                    leftIndex++;
                    counter++;
                }
                else
                {
                    result[counter] = right[0];

                    int[] savedValueR = new int[right.Length - 1];
                    for (int p = 0; p < savedValueR.Length; p++)
                    {
                        savedValueR[p] = right[p + 1];
                    }
                    right = new int[right.Length - 1];
                    for (int g = 0; g < right.Length; g++)
                    {
                        right[g] = savedValueR[g];
                    }
                    rightIndex++;
                    counter++;
                }
            }


            while (leftIndex < left.Length)
            {
                result[counter] = left[0];

                int[] savedValueL = new int[left.Length - 1];
                for (int p = 0; p < savedValueL.Length; p++)
                {
                    savedValueL[p] = left[p + 1];
                }
                left = new int[left.Length - 1];
                for (int g = 0; g < left.Length; g++)
                {
                    left[g] = savedValueL[g];
                }
                leftIndex++;
                counter++;
            }
            while (rightIndex < right.Length)
            {
                result[counter] = right[0];

                int[] savedValueR = new int[right.Length - 1];
                for (int p = 0; p < savedValueR.Length; p++)
                {
                    savedValueR[p] = right[p + 1];
                }
                right = new int[right.Length - 1];
                for (int g = 0; g < right.Length; g++)
                {
                    right[g] = savedValueR[g];
                }
                rightIndex++;
                counter++;
            }


            return result;
        }
        static int[] MergeSort(int[] numbers)
        {
            int[] left, right;
            int[] total = new int[numbers.Length];

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

            if (numbers.Length <= 1)
            {
                return numbers;
            }
            int middle = numbers.Length / 2;

            for (int q = 0; q < middle; q++)
            {
                left[q] = numbers[q];
            }
            int counter = 0;
            for (int q = middle; q < numbers.Length; q++)
            {
                right[counter] = numbers[q];
                counter++;
            }

            left = MergeSort(left);
            right = MergeSort(right);

            total = Merge(left, right);



            return total;
        }
    }
}
