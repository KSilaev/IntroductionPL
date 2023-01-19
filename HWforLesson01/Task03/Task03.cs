// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число : ");
string Num = Console.ReadLine();
int Number = Convert.ToInt32(Num);

if (Number % 2 == 0)
{
  System.Console.WriteLine($"Число {Num} четное");
}
else
{
  System.Console.WriteLine($"Число {Num} нечетное");
}