// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

//  Функция вывода элементов одной матрицы на терминал
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

void MatrixMultiplication(int[,] Martrix1, int[,] Martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(1); k++)
      {
        sum += Martrix1[i, k] * Martrix2[k, j];
      }
      resultMatrix[i, j] = sum;
    }
  }
}

Console.Clear();
int numberOfColumnsRows = InputDimension("Введите количество столбцов в первой матрице и оно же количество строк во второй матрице -> ");
int numberOfRows = InputDimension("Введите количество строк в первой матрице -> ");
int numberOfColumns = InputDimension("Введите количество столбцов во второй матрице -> ");

int[,] Matrix1 = new int[numberOfRows, numberOfColumnsRows];
int[,] Matrix2 = new int[numberOfColumnsRows, numberOfColumns];

Fill2DArray(Matrix1);
Fill2DArray(Matrix2);
Console.WriteLine("Исходные матрицы:");
Print2DArray(Matrix1);
Print2DArray(Matrix2);

int[,] resultMatrix = new int[numberOfRows, numberOfColumns];
MatrixMultiplication(Matrix1,Matrix2,resultMatrix);
Console.WriteLine("Результирующая матрица:");
Print2DArray(resultMatrix);