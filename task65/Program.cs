// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void DataN(int m, int n)
{
    if (m <= n) 
    {
        DataN(m, n - 1);
        Console.Write($"{n} ");
    }
}

Console.WriteLine("введи число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введи число N: ");
int n = int.Parse(Console.ReadLine());
if (m>n) Console.WriteLine("некорректный ввод");
else DataN(m, n);
