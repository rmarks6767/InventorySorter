# Inventory Sorter
This program utilizes the merge sort algorithm, to sort an inventory alphabetically and numeically.  

# About the Merge Sort Algorithm
The merge sort algorithm uses various recursion to sort lists or arrays into small sub arrays/lists in order to sort the items nummberically or alphabetically.  
## The algorithm consists of three steps:
* The main inputs of the user
* The Merge Sort aspect
* The Merge of thee data

### The Main inputs Section
The program will take the inputs of the user, given it be numerical or alphabetical.  It then assigns each of them to a 
### The Merge Sort aspect

### The Regmerge of the data



# Break down of the code


User Input:
```
Console.WriteLine("How many items would you like to analyze?");
int inputs = int.Parse(Console.ReadLine());
```
### Initializes the array that is going to hold the user's inputs as well as the array that will hold the sorted values:
```
string[] inventory = new string[inputs];
string[] sortedItems = new string[inputs]; 
```
### Gathers the input from the user based on how many items they have in their inventory
```
for (int i = 0; i < inputs; i++)
{
  Console.Clear();
  Console.Write("Item " + i);
  string entered = Console.ReadLine();
  inventory[i] = entered;
}
```
### Calls the function MergeSort and passes through the inventory array.  This will be equal to the sorted array when it returns.
```
sortedItems = MergeSort(inventory);
```
### After the value returns, it will be outputed to the user to show the sorted values.
```
for (int f = 0; f < inventory.Length; f++)
{
  Console.Write(sortedItems[f] + ", ");
}
```
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
```
