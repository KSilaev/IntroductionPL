// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число : ");
string Num = Console.ReadLine();
int N = Convert.ToInt32(Num);

System.Console.Write($"Четные числа до {N} включительно: ");
for (int i = 2; i <= N; i+=2)
{
  System.Console.Write($"{i}; ");
}