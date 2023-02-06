// Задача 2.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

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

Console.Write("Введите номер строки искомого элемента: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца искомого элемента: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());

// Как в условии массив делаю 4х4
int[,] Matrix = new int[4, 4];
Fill2DArray(Matrix);
Print2DArray(Matrix);

if (rowNumber-1 < Matrix.GetLength(0) && columnNumber-1 < Matrix.GetLength(1))
{
  Console.WriteLine($"Искомый элемент массива равен {Matrix[rowNumber-1, columnNumber-1]}");
}
else
{
  Console.WriteLine($"{rowNumber}{columnNumber} -> такого элемента в массиве нет");
}
