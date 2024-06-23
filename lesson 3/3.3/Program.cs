double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; 
double min=array[0];
for(int a=0; a<array.Length; a++)
{
    if(array[a]<min)
        min=array[a];
}
Console.WriteLine(min);
double max=array[0];
for(int a=0; a<array.Length; a++)
{
    if(array[a]>max)
        max=array[a];
}
Console.WriteLine(max);
