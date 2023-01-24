// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int InputIntNumber(string Mes)
{
  System.Console.Write(Mes + " : ");
  //  int IntNumber = Convert.ToInt32((System.Console.ReadLine()));
  //  return IntNumber;
  return Convert.ToInt32((System.Console.ReadLine()));
}

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
  return (Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));
}

int Point1x = InputIntNumber("Ввведите координату X точки 1");
int Point1y = InputIntNumber("Ввведите координату Y точки 1");
int Point1z = InputIntNumber("Ввведите координату Z точки 1");
int Point2x = InputIntNumber("Ввведите координату X точки 2");
int Point2y = InputIntNumber("Ввведите координату Y точки 2");
int Point2z = InputIntNumber("Ввведите координату Z точки 2");

System.Console.WriteLine("Расстояние между точками: " + Math.Round(Distance3D(Point1x, Point1y, Point1z, Point2x, Point2y, Point2z),2) + " единиц");