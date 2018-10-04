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
            //Takes input from the user of how many items they would like to sort
            Console.WriteLine("How many items are in your inventory?");
            string input = Console.ReadLine();

            int inputs = Int32.Parse(input);
            //initializes an array of numbers from the number of inputs received from the user
            string[] inventory = new string[inputs];
            Console.Clear();
            int total = inputs;
            Console.WriteLine("Total Items in inventory: " + total);

            Console.WriteLine();

            //collects the input from the user and sets it equal to the numbers array
            for (int i = 0; i < inputs; i++)
            {
                Console.Write("Item " + (i + 1) + ":");
                string entered = Console.ReadLine().Trim();
                inventory[i] = entered;
            }
            Console.Clear();
            int low = 0;
            int high = inventory.Length - 1;

            
            MergeSort(inventory, low, high, total);

            Console.WriteLine("Your inventory sorted: ");
            for (int f = 0; f < inventory.Length; f++)
            {
                Console.Write(inventory[f]);
                if (f < inventory.Length - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void MergeSort(string[] inventory, int low, int high, int total)
        {
            int mid = (low + high) / 2;

            if (low < high)
            {
                MergeSort(inventory, low, mid, total);
                MergeSort(inventory, mid + 1, high, total);

                Merge(inventory, low, mid, high, total);
            }
            return;
        }
        private static void Merge(string[] inventory, int low, int mid, int high, int total)
        {
            string[] result = new string[total];
            
            int left = low;
            int counter = low;
            int right = mid + 1;

            while(left <= mid && right <= high)
            {
                if (string.Compare(inventory[left], inventory[right]) < 0)
                {
                    result[counter] = inventory[left];
                    counter++;
                    left++;
                }
                else
                {
                    result[counter] = inventory[right];
                    counter++;
                    right++;
                }
             }
            while(left <= mid)
            {
                result[counter] = inventory[left];
                counter++;
                left++;
            }
            while(right <= high)
            {
                result[counter] = inventory[right];
                counter++;
                right++;
            }
            for (int y = low; y < counter; y++)
            {
                inventory[y] = result[y];
            }
            return;
        }
    }
}
