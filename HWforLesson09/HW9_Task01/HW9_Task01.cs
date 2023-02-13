// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5-> "2, 4"
// M = 4; N = 8-> "4, 6, 8"

// Ввод значений M и N
int InputDimension(string msg)
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

//  Функция вывода четных натуральных чисел в терминал
void EvenOutput(int M, int N)
{
  if (M > N)
  {
    return;
  }
  else
  {
    Console.Write($"{M}, ");
    EvenOutput(M+=2, N);
  }
}

Console.Clear();
int numberM = InputDimension("Введите значение M -> ");
int numberN = InputDimension("Введите значение N -> ");

if (numberM % 2 == 1)
{
  numberM++;
}
Console.Write($"Четные натуральные числа между {numberM} и {numberN} это: ");
EvenOutput(numberM, numberN);