//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите 1 цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7) {Console.WriteLine("Введенное значение не является днём недели.");}
else {
    if (number == 6 || number == 7) {Console.WriteLine("День является выходным");}
        else{ Console.WriteLine("День не является выходным");}
}