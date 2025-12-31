using System.Linq;

string text = "abc123eiqwrwjndapwaasdqwesadoaspdañsdcpzox0casasdqeopñldkjfuggjtk";

char searchCharacter = 'a';

int repeatCount = CountCharacter(text, searchCharacter);

Console.WriteLine(repeatCount);

int CountCharacter(string textToAnalyze, char searchCharacter)
{
    int repeatCount = 0;

    foreach (char c in textToAnalyze)
    {
        if (c == searchCharacter)
        {
            repeatCount++;
        }
    }

    return repeatCount;
}

int CountCharacterLinq(string textToAnalyze, char searchCharacter)
{
    return textToAnalyze.Where(c => c == searchCharacter).Count();
}
