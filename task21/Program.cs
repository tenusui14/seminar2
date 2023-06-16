// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите координату x для точки А: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для точки А: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для точки B: ");
int by = Convert.ToInt32(Console.ReadLine());

double powX = Math.Pow(ax - ay, 2);
double powY = Math.Pow(bx - by, 2);
double result = Math.Sqrt(powX + powY);
//Console.WriteLine("Расстояние равно: " + result);

Console.WriteLine($"Расстояние равно: {result:f2}");


