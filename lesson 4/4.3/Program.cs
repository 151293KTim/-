//Напишите программу,
//  которая перевернёт одномерный массив первый элемент станет последним, второй – предпоследним и т.д
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
void RevMas(int[] array)
{
    int size=array.Length;
    for (int a = 0; a < size/2; a++)
        (array[a],array[size-1-a])=(array[size-1-a],array[a]);
}
int num=int.Parse(Console.ReadLine());
int[] mas=MasNum(num);
Print (mas);
RevMas(mas);
Console.WriteLine();
Print (mas);