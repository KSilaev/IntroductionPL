// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

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

int[] FillArr(int Count, int Min, int Max)
{
  int [] ArrNums = new int[Count];
  Random rnd = new Random();
  for (int i = 0; i < Count; i++)
  {
    ArrNums[i] = rnd.Next(Min, Max);
  }
  return ArrNums;
}

void PrintArr(int[] Arr)
{
  int Count = Arr.Length;
  for (int i = 0; i < Count; i++)
  {
    System.Console.WriteLine($"Элемент массива {i} равен {Arr[i]}");
  }
//  return;
}

int ArrCount = InputIntNumber("Введите количество элементов массива");
int MinLimit = InputIntNumber("Введите минимальный порог случайных значений");
int MaxLimit = InputIntNumber("Введите максимальный порог случайных значений");
int[] RndArr;

if (ArrCount != -1 && MinLimit != -1 && MaxLimit != -1)
{
  RndArr = FillArr(ArrCount,MinLimit,MaxLimit);
  PrintArr(RndArr);
}