// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Проверяем яаляется ли число четным");
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result > 0)
{
 Console.WriteLine("число нечетное");
}
if (result == 0)
{
 Console.WriteLine("число четное");
}