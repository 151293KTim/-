//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] MasNum(int size)
{
    int[] array = new int[size];
    for (int a = 0; a < size; a++)
    {
        array[a] = new Random().Next(100, 1000);
    }
    return array;
}
void Print(int[] array)
{
    for (int a = 0; a < array.Length; a++)
    {
        Console.Write(array[a]+" ");
    }
}
int SearchNum(int [] array)
{
    int count=0;
    for (int a = 0; a < array.Length; a++)
    {
        if(array [a]%2==0)
            count++;
    }
    return count;
}
int num=int.Parse(Console.ReadLine());
int[] mas=MasNum(num);
Print (mas);
Console.WriteLine(SearchNum(mas));
