// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int even = num%2;
if (num == 0)
{
    Console.Write("Наверное, вы ввели 0?");
}
else if (even == 0)
{
    Console.Write($"Число {num} чётное");
}
else
{
    Console.Write($"Число {num} нечётное");
}