// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int BinarySearch(int[] arr, int target)
{
    int down = 0;
    int up = arr.Length - 1;

    while (down <= up)
    {
        int mid = (down + up) / 2;
        int item = arr[mid];

        if (item == target)
        {
            return item;
        }

        if (item > target)
            up = mid - 1;
        else
            down = mid + 1;
    }

    return ~down;
}

int[] arr = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

Console.WriteLine($"Element found: {BinarySearch(arr, 15)}");
Console.WriteLine($"Element found: {BinarySearch(arr, 13)}");
Console.WriteLine($"Element found: {BinarySearch(arr, 4)}");
Console.WriteLine($"Element found: {BinarySearch(arr, 1)}");
Console.WriteLine($"Element found: {BinarySearch(arr, -1)}");
Console.ReadKey();