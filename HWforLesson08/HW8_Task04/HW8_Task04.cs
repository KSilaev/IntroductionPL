// Задача * 4.Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

// Заполнение массива по спирали натуральными числами от 1 
void FillSpiral(int[,] array)
{
  int i = 0;
  int j = 0;
  for (int num = 1; num <= array.GetLength(0) * array.GetLength(1); num++)
  {
    array[i, j] = num;
    if (i <= j + 1 && i + j < array.GetLength(0) - 1)
      ++j; //направо
    else if (i < j && i + j >= array.GetLength(1) - 1)
      ++i; //вниз
    else if (i >= j && i + j > array.GetLength(0) - 1)
      --j; //налево
    else
      --i; //вверх
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

Console.Clear();
int dimension = InputDimension("Введите размерность матрицы -> ");

int[,] Matrix = new int[dimension, dimension];
FillSpiral(Matrix);
Console.WriteLine("Заполненная по спирали матрица:");
Print2DArray(Matrix);