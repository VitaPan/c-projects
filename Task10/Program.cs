// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

using System.Text; // Добавила строчку чтобы у меня терминал видел русский язык

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int twoFirstDigits = number / 10;
int secondDigit = twoFirstDigits % 10;

if (number < 1000 && number > 99)
{
    Console.WriteLine($"Вторая цифра заданного числа {number} => {secondDigit}");
}
else
{
    Console.WriteLine("Введенный параметр не соответсвует трехзначному числу");
}