// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Ввод размерности массива с проверкой
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

// Заполнение массива случайными числами от 1 до 9 (судя по условию)
void Fill2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

//  Функция вывода элементов массива на терминал
void Print2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

// Поиск номера строки с наименьшей суммой элементов
int FindMinSumRow(int[,] arr)
{
  int minSum = 0;
  int rowIndex = 0;
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    minSum += arr[0, i];
  }
  for (int k = 0; k < arr.GetLength(0); k++)
  {
    int Sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
      Sum += arr[k, i];
    }
    if (minSum > Sum)
    {
      minSum = Sum;
      rowIndex = k;
    }
  }
  return rowIndex + 1;
}

Console.Clear();
int numberOfRows = InputDimension("Введите количество строк в массиве -> ");
int numberOfColumns = InputDimension("Введите количество столбцов в массиве -> ");

int[,] Matrix = new int[numberOfRows, numberOfColumns];
Fill2DArray(Matrix);
Console.WriteLine("Исходный массив:");
Print2DArray(Matrix);

System.Console.WriteLine($"Минимальная сумма элементов в строке {FindMinSumRow(Matrix)}");