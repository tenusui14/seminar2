//Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом. (Зеркальным числом 12321)


Console.WriteLine("Введите пятизначное число: ");

int num = Convert.ToInt32(Console.ReadLine());
int numForReverse = num;
int reverse = 0;
if (num < 100000){
    while (numForReverse > 0){
        reverse = reverse*10 + numForReverse%10;
        numForReverse = numForReverse / 10;
    }
    if (reverse == num) {Console.WriteLine($"Число {num} ЯВЛЯЕТСЯ палиндромом");}
    else {Console.WriteLine($"Число {num} НЕ является палиндромом");}
}
else Console.WriteLine($"ОШИБКА. Введенное число {num} не является пятизначным");
