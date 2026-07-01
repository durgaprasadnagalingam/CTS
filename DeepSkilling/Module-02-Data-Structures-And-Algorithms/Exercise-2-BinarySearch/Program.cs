using System;

class Program
{
    static int BinarySearch(int[] arr, int key)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == key)
                return mid;

            if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };

        int key = 50;

        int index = BinarySearch(numbers, key);

        if (index != -1)
            Console.WriteLine($"Element found at index {index}");
        else
            Console.WriteLine("Element not found");
    }
}