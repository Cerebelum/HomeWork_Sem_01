// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for (int i = 1; i < (num - 1); i++) // Можно начать с 2, но вдруг переделывать на нечетные))
{
    if (i%2 == 0)
    {
        Console.Write(i + ", ");
    }
}
if (num%2 != 0)
{
    Console.Write(num - 1);
}
else
{
    Console.Write(num);
}

// так компактнее
// Console.Write("Введите число: ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// for (int i = 1; i < (num - 1); i++)
//     if (i%2 == 0) Console.Write(i + ", ");
// if (num%2 != 0) Console.Write(num - 1);
// else Console.Write(num);

// самый примитивный вариант
// Console.Write("Введите число: ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// if (num%2 != 0) num = num - 1;
// for (int i = 2; i < num; i+=2)
//     Console.Write(i + ", ");
// Console.Write(num);