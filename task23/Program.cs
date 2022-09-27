/* 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();
Console.WriteLine("Вы находитесь в программе, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Для продолжения нажмите Enter...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= number; i++)
{   
    if (i == number) {
        int mult = i * i * i;
        Console.Write($"{mult}.");
    } else {
        int mult = i * i * i;
        Console.Write($"{mult}, ");
    }
}

