static void Print(string TextPrint)
{
    Console.WriteLine(TextPrint);
}


static string[] SplitText(string text)

{


    string[] SplitString = text.Split(new char[] { ' ' });

    OutputText(SplitString);
    return SplitString;

}


static void OutputText(string[] Args)
{
    Console.WriteLine(Args);
    for (int i = 0; i < Args.Length; i++)
    {
        Console.WriteLine(Args[i]);
    }
}


Print("Введите свое длинное предложение");
SplitText(Console.ReadLine());