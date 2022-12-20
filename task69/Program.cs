// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int DataEntry (string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int PowNumbers(int a, int b)
{
    if (b<=0) return 1;
    return PowNumbers(a, b-1) * a;
}

Console.Clear();
int a = DataEntry("Введите число a: ");
int b = DataEntry("Введите число b: ");
Console.WriteLine(PowNumbers(a, b));