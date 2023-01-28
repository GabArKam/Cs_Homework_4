// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите степень");
int B = Convert.ToInt32(Console.ReadLine());

int Power(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++) result *= A;
    return result;
}

int Result = Power(A, B);
Console.WriteLine(Result);
