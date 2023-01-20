// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("это четное число?");
Console.Write("введите свой номер: ");
int num = int.Parse(Console.ReadLine());
if (num%2 == 0)
  Console.WriteLine("YES");
else Console.WriteLine("NO");

