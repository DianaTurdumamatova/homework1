// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным  (делится ли оно на два без остатка).
// Например:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine());
int b = num % 2;
if(b == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
