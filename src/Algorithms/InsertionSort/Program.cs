// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Welcome to Insertion Sort!");

int[] array = [58, 41, 59, 42, 31];

//InsertionSort(array);
//WriteCurrentArray(array);
var originLength = array.Length;
for (int i = 1; i < originLength; i++)
{
    var key = array[i];
    var previousIndex = i - 1;

    while (previousIndex >= 0 && array[previousIndex] > key)
    {
        array[previousIndex + 1] = array[previousIndex];
        previousIndex--;
    }

    array[previousIndex + 1] = key;
}

WriteCurrentArray(array);

static void WriteCurrentArray(int[] array) => Console.WriteLine("Array: " + string.Join(", ", array));


static void InsertionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 1; i < n; ++i)
    {
        int key = arr[i];
        int j = i - 1;

        // Move elements of arr[0..i-1],
        // that are greater than key,
        // to one position ahead of
        // their current position
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}

//public static class ArrayExtensions
//{
//    public static void WrapElement(this int[] array, int previousIndex) => 

//}
