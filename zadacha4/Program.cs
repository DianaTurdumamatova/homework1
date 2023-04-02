// Напишите программу, которая на вход принимает три числа и 
// выдает максимаальное из этих чисел.
// Например: 
// 2,3,7 -> 7
// 44,5,9 -> 44

Console.Clear();
Console.Write("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число:");
int num3 = int.Parse(Console.ReadLine());
int max = 0;
if(num1 > max);
{
    max = num1; 
}if(num2 > max)
{
    max = num2;
}if(num3 > max)
{
    max = num3;
}
Console.WriteLine("max = " + max);
