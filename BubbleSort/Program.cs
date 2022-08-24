
int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
//int[] result = BubbleSort(array); // common way
int[] result = BubbleSortBetterWay(array); // best way
foreach (var item in result)
{
    Console.Write(" " + item);
}
Console.ReadKey();

// Time O(n^2) space O(1)
int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                swap(i, j, array);
            }
        }
    }
    return array;
}

// Best O(n) Time O(1) space worst  O(n^2) time O(1) space average O(n^2) time O(1) space
int[] BubbleSortBetterWay(int[] array)
{
    bool isSorted = false;
    int count = 0;
    while (!isSorted)
    {
        isSorted = true;
        for (int i = 0; i < array.Length - 1 - count; i++)
        {
            if (array[i] > array[i+1])
            {
                swap(i, i + 1, array);
                isSorted = false;
            }
        }
        count++;
    }
    return array;
}

void swap(int i, int j, int[] array)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

