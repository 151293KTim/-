// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void EnterNum()
{
    string Answer;
    while (true)
    {
        Console.Write("Введите значение: ");
        Answer=Console.ReadLine();
        if(Answer=="q")
        return;
        else
        {
            int num=int.Parse(Answer);
            int sum=0;
            for(; num>0; num/=10)
                sum+=num%10;
            if (sum%2==0)
                {
                Console.WriteLine("Сумма четная");
                return;
                }
        }        
    }
}
EnterNum();