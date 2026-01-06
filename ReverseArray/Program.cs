// Reverse ARRAY manually

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//int[] result = ReverseManual(numbers);

ReverseInPlace(numbers);

foreach (int n in numbers)
{
    Console.WriteLine(n);
}

Console.WriteLine("--------------------------------------------------");

//foreach (int n in result)
//{
//    Console.WriteLine(n);
//}

Console.WriteLine("--------------------------------------------------");

foreach (int n in numbers)
{
    Console.WriteLine(n);
}

// reverse array using magic method
int[] ReverseArray(int[] parameter)
{
    return parameter.Reverse().ToArray();
}

// reverse array manually (returns new array)
int[] ReverseManual(int[] array)
{
    int[] result = new int[array.Length];

    int index = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[index] = array[i];
        index++;
    }

    return result;
}

// reverse array in the same reference (in-place)
void ReverseSameReference(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

// reverse array in-place
void ReverseInPlace(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
