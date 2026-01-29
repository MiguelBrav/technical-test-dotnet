// HAMMING distance

string text1 = "patitosv";
string text2 = "paratosa";

int result = hammingDistance(text1, text2);

Console.WriteLine(result);

int hammingDistance(string textOne, string textTwo)
{
    int distance = 0;

    if (textOne.Length != textTwo.Length)
    {
        throw new Exception("Different lengths");
    }

    for (int i = 0; i < textOne.Length; i++)
    {
        if (textOne[i] != textTwo[i])
            distance++;
    }

    return distance;
}
