//Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.
string strlow (string super){
    return super.ToLower();
}
Console.Write("введите строку");
string text=Console.ReadLine();
Console.WriteLine (strlow(text));