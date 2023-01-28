// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

float[] FillArr(int Count)
{
  float[] ArrNums = new float[Count];
  Random rnd = new Random();
  for (int i = 0; i < Count; i++)
  {
    // Ограничил диапазон случайных чисел, чтобы проверять легче было
    // И по условиям задачи массив-то вещественных чисел, а в примере приведены целые. Поэтому и я генерирую целые
    ArrNums[i] = rnd.Next(-99, 99);
  }
  return ArrNums;
}

void PrintArr(float[] Arr)
{
  int Count = Arr.Length;
  for (int i = 0; i < Count; i++)
  {
    System.Console.WriteLine($"Элемент массива {i} равен {Arr[i]}");
  }
}

float[] RndArr;
float Max, Min;

RndArr = FillArr(7);
Max = RndArr[0];
Min = RndArr[0];
//Выведем массив на экран, чтобы проверить работу программы
PrintArr(RndArr);
for (int i = 1; i < RndArr.Length; i ++)
{
  if (Max < RndArr[i])
  {
    Max = RndArr[i];
  }
  else
  {
    if (Min > RndArr[i])
    {
      Min = RndArr[i];
    }
  }
}
System.Console.WriteLine($"Разность между максимальным {Max} и минимальным {Min} элементами составляет {Max-Min}");