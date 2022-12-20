// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void DataN(int n)
{
    if (n != 0) 
    {
        DataN(n - 1);
        Console.Write($"{n} ");
    }
}


Console.WriteLine("Введи число N: ");
int n = int.Parse(Console.ReadLine());
DataN(n);