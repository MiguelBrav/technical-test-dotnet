// See https://aka.ms/new-console-template for more information
// Exercise 1
int[] numbers = { 5, 10, 15, 20, 25 };

foreach (int i in numbers)
{
    Console.WriteLine(i);
}

// Exercise 2
int[] values = { 3, 6, 9, 12 };

foreach (int i in values)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

// Exercise 3
string[] names = { "Ana", "Luis", "Pedro", "Sofia" };
int position = 2;

if (names.Length > position)
{
    Console.WriteLine(names[position]);
}

// Exercise 4
int[] data = { 7, 14, 21 };

Console.WriteLine(data.LastOrDefault());

// Exercise 5
int[] arr = { 1, 2, 3, 4, 5 };

int[] reversed = arr.Reverse().ToArray();

foreach (int i in reversed)
{
    Console.WriteLine(i);
}

// Exercise 6
int[] original = { 10, 20, 30 };

int[] result = ReverseArray(original);

foreach (int i in result)
{
    Console.WriteLine(i);
}

// Exercise 7
List<int> numberList = new List<int> { 2, 4, 6, 8 };

// Correct way to loop through a list using index
for (int i = 0; i < numberList.Count; i++)
{
    Console.WriteLine(numberList[i]);
}

// Exercise 8
List<int> sumValues = new List<int> { 5, 10, 15, 20 };

int sum = 0;

foreach (int i in sumValues)
{
    sum += i;
}

// Reverse array manually
int[] ReverseArray(int[] parameter)
{
    int[] result = new int[parameter.Length];
    int index = 0;

    for (int i = parameter.Length - 1; i >= 0; i--)
    {
        result[index] = parameter[i];
        index++;
    }

    return result;
}
