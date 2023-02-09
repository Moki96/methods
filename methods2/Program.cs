static string SplitWord2(string text)
{
    string[] WordsSplit2 = text.Split(' ');
    string newText = ReverseWord(WordsSplit2);
    return newText;
}
static string ReverseWord(string[] text)
{
    Array.Reverse(text);
    string str = string.Join(" ", text);
    return str;
}

Console.WriteLine("Введите предложение: ");

string invertedText = Console.ReadLine();

invertedText = SplitWord2(invertedText);


Console.WriteLine(invertedText);
Console.ReadLine();