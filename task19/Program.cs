/* 
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
// Функция разворота пятизначного числа
int ReverseNum(int number)
{
    int reverseNumber = 0;
    int calcNum = number;
    for (int i = 1; i <= 5; i++)
    {
        int remainder = calcNum % 10;
        int temp = remainder * (int)Math.Pow(10, 5 - i);
        calcNum = calcNum / 10;
        reverseNumber = reverseNumber + temp;
    }
    return reverseNumber;
}

Console.Clear();
Console.WriteLine("Программа для определения является ли введенное вами число палиндромом. Для продолжения нажмите Enter...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num >= 10000 && num < 100000)
{
    int reverseNumber = ReverseNum(num);
    if (num == reverseNumber)
    {
        Console.Write($"Число {num} равно обратному ему числу {reverseNumber}, значит данное число ПАЛИНДРОМ");
    }
    else
    {
        Console.Write($"Число {num} НЕ равно обратному ему числу {reverseNumber}, значит данное число НЕ ПАЛИНДРОМ");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число, повторите попытку");
}



