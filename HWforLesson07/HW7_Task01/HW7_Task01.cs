// Задача 1.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Заполнеим массив случайными вещественными числами
void Fill2DArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-100, 100) / 10.0;
    }
  }
}

//  Функция вывода элементов массива на терминал
void Print2DArray(double[,] array)
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

Console.Write("Введите количество строк в массиве: ");
int numberOfRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());

double[,] Matrix = new double[numberOfRows, numberOfColumns];
Fill2DArray(Matrix);
Print2DArray(Matrix);