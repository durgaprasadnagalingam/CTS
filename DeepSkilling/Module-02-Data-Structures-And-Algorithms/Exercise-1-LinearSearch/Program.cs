using System;

class Program
{
    static int LinearSearch(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
                return i;
        }

        return -1;
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        int key = 30;

        int index = LinearSearch(numbers, key);

        if (index != -1)
            Console.WriteLine($"Element found at index {index}");
        else
            Console.WriteLine("Element not found");
    }
}