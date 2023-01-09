// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

using System.Text;
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
var enc1251 = Encoding.GetEncoding(1251);

System.Console.OutputEncoding = System.Text.Encoding.UTF8;
System.Console.InputEncoding = enc1251;

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
}
else if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    Console.WriteLine("Иди работай");
}
