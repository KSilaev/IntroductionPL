// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArr(int Count)
{
  int[] ArrNums = new int[Count];
  Random rnd = new Random();
  for (int i = 0; i < Count; i++)
  {
// Ограничил диапазон случайных чисел, чтобы проверять легче было
    ArrNums[i] = rnd.Next(-15,15);
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
}

int[] RndArr;
int UnevenSum = 0;

RndArr = FillArr(7);
//Выведем массив на экран, чтобы проверить работу программы
PrintArr(RndArr);
for (int i = 1; i < RndArr.Length; i += 2)
{
  UnevenSum += RndArr[i];
}
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {UnevenSum}");