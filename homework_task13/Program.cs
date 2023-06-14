// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Input(string message){
Console.WriteLine(message);
string? value = Console.ReadLine();
int digits = Convert.ToInt32(value);
return digits;
}
int getThird(int number){
    while (number > 999){
        number = number / 10;
    }
    return number % 10;
}
bool CorrectNumber(int number){
    if(number < 100){
        Console.WriteLine("Третьей цифры нет ");
        return false;
    }
    return true;
}

int number = Input("Введите число: ");
if (CorrectNumber(number)) {
    Console.WriteLine(getThird(number));
}