// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Введите число 1: ");
string Num1 = Console.ReadLine();
int Number1 = Convert.ToInt32(Num1);

Console.Write("Введите число 2: ");
string Num2 = Console.ReadLine();
int Number2 = Convert.ToInt32(Num2);

Console.Write("Введите число 3: ");
string Num3 = Console.ReadLine();
int Number3 = Convert.ToInt32(Num3);

int MaxNumber = Number1;

if (Number1 > MaxNumber)
{
  MaxNumber = Number1;
}
if (Number2 > MaxNumber)
{
  MaxNumber = Number2;
}
if (Number3 > MaxNumber)
{
  MaxNumber = Number3;
}
System.Console.WriteLine($"Максимальное число из введенных {MaxNumber}");