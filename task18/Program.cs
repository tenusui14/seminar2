// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти для осей х - у");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1) Console.WriteLine("х > 0, y > 0");
else if (num == 2) Console.WriteLine("х < 0, y > 0");
else if (num == 3) Console.WriteLine("х < 0, y < 0");
else if (num == 4) Console.WriteLine("х  > 0, y < 0");
else Console.WriteLine("Невозможно определить");