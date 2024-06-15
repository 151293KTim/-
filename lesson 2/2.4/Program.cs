//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
int num = int.Parse(Console.ReadLine()!);
string res="";
while (num>0)
{
    res=num%10+","+res;
    num=num/10;

}
Console.WriteLine(res);