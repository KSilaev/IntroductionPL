// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не используйте строки

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

int ReverseNumber(int Number)
{
  int i, Digit, ReverseNum = 0;
  for (i = Number; i > 0; i = i / 10)
  {
    Digit = i % 10;
    ReverseNum = (ReverseNum * 10) + Digit;
  }
  return ReverseNum;
}

int intNumber = InputIntNumber("Введите целое положительное число");

if (intNumber != -1)
{
  if (intNumber == ReverseNumber(intNumber))
  {
    Console.WriteLine($"Введенное число {intNumber} является палиндромом");
  }
  else
  {
    Console.WriteLine($"Введенное число {intNumber} не является палиндромом!");
  }
}