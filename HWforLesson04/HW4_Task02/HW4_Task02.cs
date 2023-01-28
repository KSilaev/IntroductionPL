// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции

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

int DigitSum(int Number)
{
  int Result = 0;
  int Digit;
  while (Number > 0)
  {
    Digit = Number % 10;
    Result = Result + Digit;
    Number = Number / 10;
  }
  return Result;
}

int IntNumber = InputIntNumber("Введите целое положительное число");

if (IntNumber != -1)
{
  System.Console.WriteLine($"Сумма цифр числа {IntNumber} равна {DigitSum(IntNumber)}");
}