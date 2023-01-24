// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Проверку на ввод 0 не стал делать

System.Console.Write("Ввведите число : ");
int Num = Convert.ToInt32((System.Console.ReadLine()));

if (Num > 0)
{
  for (int i = 1; i <= Num; i++)
  {
    System.Console.Write(Math.Pow(i, 3) + ", ");
  }
}
else
{
  for (int i = -1; i >= Num; i--)
  {
    System.Console.Write(Math.Pow(i, 3) + ", ");
  }
}