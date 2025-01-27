static int[] QuickSort(int[] arr)
{
    if (arr.Length < 2)
        return arr;

    var pivot = arr[0];
    var less = arr[1..].Where(x => x <= pivot).ToArray();
    var greater = arr[1..].Where(x => x > pivot).ToArray();

    return [.. QuickSort(less), pivot, .. QuickSort(greater)];
}


static void Test(int[] array)
{
    int[] sortedArray = QuickSort(array);
    Console.WriteLine(string.Join(", ", sortedArray));
};

Test([ 1, 2, 3, 4, 5 ]);

Test([5, 4, 3, 2, 1]);

Test([3, 3, 2, 1, 3, 4, 1]);

Test([42]);

Test([]);

Console.ReadKey();