// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число 1: ");
string Num1 = Console.ReadLine();
int Number1 = Convert.ToInt32(Num1);

Console.Write("Введите число 2: ");
string Num2 = Console.ReadLine();
int Number2 = Convert.ToInt32(Num2);

if (Number1 > Number2)
{
  System.Console.WriteLine($"Первое число {Num1} больше второго числа {Num2}");
}
else if (Number1 < Number2)
{
  System.Console.WriteLine($"Второе число {Num2} больше первого числа {Num1}");
}
else
{
  System.Console.WriteLine($"Второе число {Num2} равно первому числу {Num1}");
}