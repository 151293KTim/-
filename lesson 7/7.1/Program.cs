// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

Console.Write("введите значение M: ");
int M= int.Parse(Console.ReadLine());

Console.Write("введите значение N: ");
int N=int.Parse(Console.ReadLine());
void printnum(int M, int N){
    if (M<=N){
        Console.WriteLine(M);
        printnum(M+1,N);
    }
}
printnum (M,N);