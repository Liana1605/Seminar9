// Задача 67: Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int DataSum(int number)
{
    if (number > 0) 
    {
         return number%10 + DataSum(number/10);
    }
    return 0;
}


Console.WriteLine("введи число n: ");
int n = int.Parse(Console.ReadLine());
int result = DataSum(n);
Console.WriteLine($"Сумма цифр числа n равна: {result} ");