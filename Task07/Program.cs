// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.WriteLine("Введите число  ");
int num = Convert.ToInt32(Console.ReadLine());
num = num / 10 % 10;
int num_ost = num / 10;
if (100 < num < 1000)
    Console.WriteLine($"{num_ost}");