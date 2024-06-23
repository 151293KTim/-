int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int num=0;
for(int a=0; a<array.Length; a++)
{
    if(array[a]>=10&&array[a]<=90)
        num=num+1;
}
Console.WriteLine(num);