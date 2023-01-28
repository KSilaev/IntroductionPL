// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции

int InputIntNumber(string Mes)
{
  System.Console.Write(Mes + " : ");
  int IntNumber = Convert.ToInt32((System.Console.ReadLine()));
  if (IntNumber > 0)
  {
    return IntNumber;
  }
  else
  {
    System.Console.WriteLine("Вы ввели отрицательное число!");
    return -1;
  }
}

int ToRank(int X, int Y)
{
  int Result = 1;
  for (int i = 1; i <= Y; i++)
  {
    Result = Result * X;
  }
  return Result;
}

int IntNumber = InputIntNumber("Введите целое положительное число");
int Rank = InputIntNumber("Введите целое положительное число - степень, в которую будем возводить");
if (IntNumber != -1 && Rank != -1)
{
  System.Console.WriteLine($"Результатом возведения числа {IntNumber} в степень {Rank} будет {ToRank(IntNumber, Rank)}");
}