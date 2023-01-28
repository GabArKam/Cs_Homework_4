// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

int Sum(int x)
{
    int result = 0;
    for (int n = x; n > 0; result += n % 10, n /= 10);
    return result;
}

int Result = Sum(x);
Console.WriteLine($"Сумма цифр введенного числа равна {Result}");
