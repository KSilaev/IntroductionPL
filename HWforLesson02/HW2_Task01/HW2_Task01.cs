// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

// Ввод и проверка введенного числа
int InputIntNumber (string Mes)
{
  System.Console.Write(Mes + " : ");
  int IntNumber = Convert.ToInt32((System.Console.ReadLine()));
  if (IntNumber > 99 && IntNumber < 1000)
  {
    return IntNumber;
  }
  System.Console.WriteLine("Вы ввели не трехзначное или отрицательное число!");
  return -1;
}

// Вычисление второй цифры введенного числа
int Rank = 0;
int Num = InputIntNumber("Введите положительное трехзначное число");

// Вторую цифру ищем только в трехзначных числах, иначе ничего не делаем
if (Num != -1)
{
  Num = Num / 10;
  Rank = Num % 10;
  Console.WriteLine($"Вторая цифра введенного числа: {Rank}");
}