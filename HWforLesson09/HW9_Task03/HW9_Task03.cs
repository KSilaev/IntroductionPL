// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

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

//Функция Аккермана по определению
int Akkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0)
  {
    return Akkerman(m - 1, 1);
  }
  else
  {
    return (Akkerman(m - 1, Akkerman(m, n - 1)));
  }
}

Console.Clear();
int numberM = InputNumber("Введите значение M -> ");
int numberN = InputNumber("Введите значение N -> ");

Console.Write(Akkerman(numberM, numberN));