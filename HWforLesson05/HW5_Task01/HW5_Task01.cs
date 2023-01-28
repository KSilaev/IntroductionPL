// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArr(int Count, int Min, int Max)
{
  int[] ArrNums = new int[Count];
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

int[] RndArr;
int OddCount = 0;

RndArr = FillArr(7, 100, 999);
//Выведем массив на экран, чтобы проверить работу программы
PrintArr(RndArr);
for (int i = 0; i < RndArr.Length; i++)
{
  if (RndArr[i] % 2 == 0)
  {
    OddCount++;
  }
}
System.Console.WriteLine($"Количество четных чисел в массиве {OddCount}");