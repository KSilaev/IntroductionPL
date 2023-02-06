// Задача 3.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

// Заполнение массива случайными числами от 1 до 100 (отошел от условия)
void Fill2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 100);
    }
  }
}

//  Функция вывода элементов двумерного массива на терминал
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

//  Функция вывода элементов одномерного вещественного массива на терминал
void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

Console.Write("Введите количество строк в массиве: ");
int numberOfRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int[numberOfRows, numberOfColumns];
Fill2DArray(Matrix);
Print2DArray(Matrix);

// Все средние арифметические буду хранить в одномерном массиве, потом его легко вывести на экран
double[] AverageValues = new double[Matrix.GetLength(1)];

// Не стал оформлять расчет среднего арифметического функцией, ведь ее вызывать пришлось бы один раз
for (int i = 0; i < Matrix.GetLength(1); i++)
{
  double Sum = 0.0;
  for (int j = 0; j < Matrix.GetLength(0); j++)
  {
    Sum += Matrix[j, i];
  }
  AverageValues[i] = Sum / Matrix.GetLength(0);
}

Console.Write("Средние арифметические значения элементов в каждом столбце: ");
PrintArray(AverageValues);