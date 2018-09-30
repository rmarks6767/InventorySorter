using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort_V3
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Takes input from the user of how many numbers they would like to sort
            Console.WriteLine("How many items would you like to analyze?");
            int inputs = int.Parse(Console.ReadLine());
            //initializes an array of numbers from the number of inputs received from the user
            string[] inventory = new string[inputs];
            string[] sortedItems = new string[inputs];  //This array will be the place the final sorted values are stored

            //collects the input from the user and sets it equal to the numbers array
            for (int i = 0; i < inputs; i++)
            {
                Console.Clear();
                Console.Write("Item " + i);
                string entered = Console.ReadLine();
                inventory[i] = entered;
            }
            sortedItems = MergeSort(inventory);

            for (int f = 0; f < inventory.Length; f++)
            {
                Console.Write(sortedItems[f] + ", ");
            }
        }
        public static string[] MergeSort(string[] inventory)
        {
            if (inventory.Length <= 1)
            {
                return inventory;
            }

            int middle = inventory.Length / 2;
            string[] left = new string[middle];
            string[] right = new string[middle];
            if (inventory.Length % 2 == 0)
            {
                right = new string[middle];
            }
            else
            {
                right = new string[middle + 1];
            }
                for (int i = 0; i < middle; i++)
            {
                left[i] = inventory[i];
            }
            MergeSort(left);
            int counter = 0;
            for (int g = middle; g < inventory.Length; g++)
            {
                right[counter] = inventory[g];
                counter++;
            }
            MergeSort(right);

            
            // numbers holds the array, start holds where the first array starts, middle holds its end, and middle + 1 is the start of right array
            return Merge(inventory, left, right);
        }
        private static string[] Merge(string[] inventory, string[] left, string[] right)
        {
            int counter = left.Length + right.Length;

            int leftTotal = 0;
            int rightTotal = 0;

            for (int q = 0; q < counter; q++)
            {
                if (leftTotal > left.Length)
                {
                    inventory[q] = right[leftTotal];
                    leftTotal++;
                }
                else if (rightTotal > right.Length)
                {
                    inventory[q] = left[rightTotal];
                    rightTotal++;
                }
            }
            for (int g = 0; g < left.Length; g++)
            {
                inventory[g] = left[leftTotal];
                leftTotal++;
            }
            for (int g = 0; g < right.Length; g++)
            {
                inventory[g] = right[rightTotal];
                rightTotal++;
            }
            /*if (string.Compare(left[0], right[0]) < 0)
            {
                inventory[0] = left[leftTotal];
                leftTotal++;
            }
            else
            {
                inventory[0] = right[rightTotal];
                rightTotal++;
            }*/
            return inventory;
        }
    }
}
