// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Сортировка массива
void DescendingSort(int[,] arr)
{
  int temp;
  for (int k = 0; k < arr.GetLength(0); k++)
  {
    for (int i = 0; i < arr.GetLength(1); i++)
    {
      for (int j = 0; j < arr.GetLength(1) - 1; j++)
      {
        if (arr[k, j] < arr[k, j + 1])
        {
          temp = arr[k, j];
          arr[k, j] = arr[k, j + 1];
          arr[k, j + 1] = temp;
        }
      }
    }
  }
}

Console.Clear();
int numberOfRows = InputDimension("Введите количество строк в массиве -> ");
int numberOfColumns = InputDimension("Введите количество столбцов в массиве -> ");

int[,] Matrix = new int[numberOfRows, numberOfColumns];
Fill2DArray(Matrix);
Console.WriteLine("Исходный массив:");
Print2DArray(Matrix);

DescendingSort(Matrix);
Console.WriteLine("Отсортированный массив:");
Print2DArray(Matrix);