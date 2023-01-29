// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("Заполните массив числами");

int[] set = new int[8];
void MyArray(int[] col)
{
    for (int index = 0; index < set.Length; index++)
    {
        Console.Write($"Введите элемент массива под индексом {index}:\t");
        set[index] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Вывод массива:\t");

    for (int index = 0; index < set.Length; index++)
    {
        Console.Write($"{set[index]} ");
    }
}

MyArray(set);
