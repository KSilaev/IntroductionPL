// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

// Ввод и проверка введенного номера дня недели
int InputDayNumber(string Mes)
{
  System.Console.Write(Mes + " : ");
  int IntDayNumber = Convert.ToInt32((System.Console.ReadLine()));
  if (IntDayNumber > 7 | IntDayNumber < 1)
  {
    System.Console.WriteLine("Вы ввели несуществующий номер дня недели!");
    return -1;
  }
  return IntDayNumber;
}

// Проверяем день недели
string[] Weekends = {"нет", "нет", "нет", "нет", "нет", "да", "да"};
int DayNum = InputDayNumber("Введите номер дня недели (число от 1 до 7)");

// Проверку делаем только в случае правильного ввода пользователем, иначе ничего не делаем
if (DayNum != -1)
{
  Console.WriteLine($"Является ли день с введенным номером {DayNum} выходным? -> {Weekends[DayNum - 1]}");
}