//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

int[] getNum()
{
    Console.WriteLine("Введите M:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите N:");
    int n = int.Parse(Console.ReadLine());
    return [m, n];
}

int GetNaturalNum(int firstNum, int secondNum)
{
    if(firstNum <= secondNum)
    {
        Console.WriteLine(firstNum);
        return GetNaturalNum(++firstNum, secondNum);
    }
    return 0;
}

//Console.WriteLine(getNum()[0]);
int[] i = getNum();
GetNaturalNum(i[0], i[1]);