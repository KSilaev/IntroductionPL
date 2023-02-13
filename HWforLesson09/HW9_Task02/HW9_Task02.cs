// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

// Ввод значений M и N
int InputNumber(string msg)
{
  Console.Write(msg);
  string Temp;
  int Num;
  Temp = Console.ReadLine();
  while (!int.TryParse(Temp, out Num) || Num < 0)
  {
    Console.Write("Вы ввели не натуральное число! Попробуйте еще разок -> ");
    Temp = Console.ReadLine();
  }
  return Num;
}

//  Функция, вычисляющая сумму натуральных чисел от M до N
int EvenSum(int M, int N)
{
  int Sum = M;
  if (M > N)
  {
    return 0;
  }
  else
  {
    M++;
    Sum += EvenSum(M, N);
    return Sum;
  }
}

Console.Clear();
int numberM = InputNumber("Введите значение M -> ");
int numberN = InputNumber("Введите значение N -> ");

Console.Write($"Сумма натуральных чисел между {numberM} и {numberN} равна: {EvenSum(numberM, numberN)}");