// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
char[,] chararray ={{'k', 'a', 't', 'y', 'a'},
                    {'s','u', 'p', 'e', 'r'}};
string chtostr (char[,] array)
{
    string rez = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rez+=array[i,j];
        }
    } 
    return rez;
}
Console.WriteLine(chtostr(chararray));