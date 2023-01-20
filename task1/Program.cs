// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: "); 
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("первое число больше второго");
}
else if (num1 < num2)
{
    Console.WriteLine("первое число меньше второго");
}
else
{
    Console.WriteLine("Оба числа равны ");
}
