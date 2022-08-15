/*Задача 27: Напишите программу, которая 
принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()!);

int Summa(int x)
{
    int summa = 0;
    while (x > 0)
    {
        int digit = x % 10;
        summa = summa + digit;
        x = x / 10;
    }
    return summa;
}
Console.WriteLine(Summa(x));