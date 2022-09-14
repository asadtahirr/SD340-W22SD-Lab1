


string Concatenate(string wordArg,int intArg)
{
    string result = "";
    for (int i=0; i < intArg; i++)
    {
        result += wordArg;
    }
    return result;
}

string Impermanent (string wordArg, int intArg)
{
    int lenghtOfWord = wordArg.Length;

    int finalLenght = lenghtOfWord - intArg;

    return wordArg.Substring(0, finalLenght);
}

MyDelegate newDelegate = Concatenate;
MyDelegate impermanentDelegate = Impermanent;

Console.WriteLine(newDelegate("Hey",3));
Console.WriteLine(impermanentDelegate("Iloveyou", 3));

public delegate string MyDelegate(string wordArg, int intArg);
