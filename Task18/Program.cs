// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти ");
Console.Write ("quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());



string Point(int quarter)
{
if(quarter == 1) return "X > 0, Y > 0";
if(quarter == 2) return "X > 0, Y < 0";
if(quarter == 3) return "X < 0, Y < 0";
if(quarter == 4) return "X < 0, Y > 0"; 
return "Введен некорректный номер четверти";
}
string result = Point (quarter);
Console.WriteLine(result);