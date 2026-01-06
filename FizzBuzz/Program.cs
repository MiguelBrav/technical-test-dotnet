// See https://aka.ms/new-console-template for more information


for (int i = 1; i <= 50; i++)
{
    string output = i.ToString();

    if (i % 5 == 0 && i % 3 == 0)
    {
        output = "AB";
    }
    else if (i % 5 == 0)
    {
        output = "B";
    }
    else if (i % 3 == 0)
    {
        output = "A";
    }

    Console.WriteLine(output);
}