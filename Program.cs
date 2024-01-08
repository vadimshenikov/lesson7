//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

int getLengthArray()
{
    Console.WriteLine("Введите длинну массива:");
    int m = int.Parse(Console.ReadLine());
    return m;
}

int[] arr = fillArray(getLengthArray());


int[] fillArray(int len)
{
    Random random = new Random();
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = random.Next(0, 100);
    }
return arr;
}

int printArray(int[] arr, int index)
{
    if(index != 0)
    {
        Console.WriteLine(arr[index]);
        index = index - 1;
        return printArray(arr, index);
    }
    return 0;
}
printArray(arr, arr.Length-1);