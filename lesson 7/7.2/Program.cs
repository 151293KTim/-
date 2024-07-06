// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("введите значение M: ");
int M= int.Parse(Console.ReadLine());

Console.Write("введите значение N: ");
int N=int.Parse(Console.ReadLine());
int Akkerman(int M, int N){
    if (M==0)
        return N+1;
     else if (N==0)
        return Akkerman (M-1, 1);
    else 
        return Akkerman (M-1, Akkerman(M, N-1));
}
Console.WriteLine (Akkerman(M,N));