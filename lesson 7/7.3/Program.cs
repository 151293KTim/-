// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int[] array={1,2,3,4,5};
void printnum (int[] array, int i){
    if(i>=0){
        Console.WriteLine (array[i]);
        printnum(array,i-1);
    }
}
printnum (array, array.Length-1);