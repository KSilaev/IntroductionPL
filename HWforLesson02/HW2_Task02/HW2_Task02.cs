// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Ввод и проверка введенного числа
int InputIntNumber(string Mes)
{
  System.Console.Write(Mes + " : ");
  int IntNumber = Convert.ToInt32((System.Console.ReadLine()));
  if (IntNumber > 100)
  {
    return IntNumber;
  }
  else
  {
    if (IntNumber < 0)
    {
      System.Console.WriteLine("Вы ввели отрицательное число!");
    }
    else
    {
      System.Console.WriteLine("В этом числе нет третьей цыфры!");
    }
  }
  return -1;
}

// Вычисление третьей цифры введенного числа
int Rank3 = 0;
int Num = InputIntNumber("Введите положительное целое число");

// Третью цифру ищем только в трех и более -значных числах, иначе ничего не делаем
if (Num != -1)
{
  while (Num > 1000)
  {
    Num = Num / 10;
  }
  Rank3 = Num % 10;
  Console.WriteLine($"Третья цифра введенного числа: {Rank3}");
}