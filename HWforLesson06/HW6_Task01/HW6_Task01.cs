// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2-> 2
// 1, -7, 567, 89, 223-> 3

int[] InputNumbers()
{
  Console.Write("Какое количество целых чисел изволите ввести? -> ");
  int M = Convert.ToInt32(Console.ReadLine());
  int[] Numbers = new int[M];
  string Temp;
  int Num;
  for (int i = 0; i < M; i++)
  {
    Console.Write($"Введите число {i + 1} -> ");
    Temp = Console.ReadLine();
    while (!int.TryParse(Temp, out Num))
    {
      Console.Write("Вы ввели не целое число! Попробуйте еще разок -> ");
      Temp = Console.ReadLine();
    }
    Numbers[i] = Num;
  }
  return Numbers;
}

int PositiveCount(int[] Arr)
{
  int Count = 0;
  for (int i = 0; i < Arr.Length; i++)
  {
    if (Arr[i]>0)
    {
      Count++;
    }
  }
  return Count;
}

Console.Clear();
int[] UserNumbers = InputNumbers();
Console.Write($"Количество введенных чисел больше 0: {PositiveCount(UserNumbers)}");