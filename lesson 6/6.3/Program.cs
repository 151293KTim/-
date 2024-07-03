// Задайте произвольную строку. Выясните, является ли она палиндромом.
bool polyndrom (string text){
    int size= text.Length;
    for (int i = 0; i < size/2; i++)
    {
        if (text[i]!=text[size-1-i])
            return false;
    }
    return true;
}

Console.Write("введите строку ");
string text=Console.ReadLine();
Console.WriteLine (polyndrom(text));