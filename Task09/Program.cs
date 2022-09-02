// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);
// int firstDigit = num / 10; //7
// int secondDigit = num % 10; //8
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {num} -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {num} -> {secondDigit}");


int MaxDigit(int number)
{
    int firstDigit = number / 10; 
    int secondDigit = number % 10; 
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit = MaxDigit(12);
Console.WriteLine($"Наибольшая цифра числа {12} -> {maxDigit}");