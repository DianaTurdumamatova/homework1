// Напишите программу, которая на вход принимает два числа и
// выдает, какое число большее, а какое меньшее.
// Например: 
// а = 5; б = 7 -> макс 7
// а = 2; б = 10 -> макс 10
// а = -9; б = -3 ->макс = -3

Console.Clear();
Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
    Console.WriteLine($"{a} больше {b}");
} 
else if(a < b)
{
    Console.WriteLine($"{a} меньше {b}");
}else
{
    Console.WriteLine($"{a} = {b}");
}
