//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
int x = int.Parse(Console.ReadLine()!);
if (x >= 10 & x <=99)
{
    int n1 = x/10;
    int n2 = x%10;
    if (n1 > n2)
    {
        Console.WriteLine(n1+" наибольшая цифра");
    }
    else if (n1 < n2)
    {
        Console.WriteLine(n2+" наибольшая цифра");
    }
    else 
    {
        Console.WriteLine("цифры равны");
    }
}
else {
    Console.WriteLine("значение вне диапазона");
}
