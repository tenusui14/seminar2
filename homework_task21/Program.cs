// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату x для точки А: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для точки А: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z для точки А: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для точки B: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z для точки B: ");
int bz = Convert.ToInt32(Console.ReadLine());
// формула  ab = sqrt(bx - ax)^2 + (by - ay)^2 + (bz - az)^2
double pow1 = Math.Pow(bx - ax, 2);
double pow2 = Math.Pow(by - ay, 2);
double pow3 = Math.Pow(bz - az, 2);
double result = Math.Sqrt(pow1 + pow2 + pow3);
//Console.WriteLine("Расстояние равно: " + result);

Console.WriteLine($"Расстояние равно: {result:f2}");