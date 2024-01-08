//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
int[] getNum()
{
    Console.WriteLine("Введите M:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите N:");
    int n = int.Parse(Console.ReadLine());
    return [m, n];
}

int getAck(int n, int m)
{
    if(n == 0)
    {
        return m + 1;
    } else
    if((n != 0) && (m == 0))
    {
        return getAck(n - 1, 1);
    } else
    {
        return getAck(n - 1, getAck(n, m - 1));
    }
}

int[] num = getNum();
Console.WriteLine(getAck(num[0], num[1]));