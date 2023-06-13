// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstTask = number % 7;
int secondTask = number % 23;
if (firstTask == 0 && secondTask == 0){
    Console.WriteLine("Число кратно 7 и 23 одновременно");
}
else{
    Console.WriteLine("Условие не выполнено, число не кратно одному или ");
}
