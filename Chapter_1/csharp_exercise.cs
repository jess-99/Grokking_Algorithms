using System;

public class BinarySearchExample
{
    public static int? BinarySearch(int[] list, int item)
    {

        int low = 0;
        int high = list.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = list[mid];
            if (guess == item) return mid;
            if (guess > item)
            {
                high = mid - 1;
            }
            else{
                low = mid + 1;
            }
        }
        return null;
    }

    public static void Main()
    {
        int[] myList = { 1, 3, 5, 7, 9 };
        int? result = BinarySearch(myList, 9);
        
        if (result.HasValue)
        {
            Console.WriteLine($"Item found at index: {result.Value}");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }
}