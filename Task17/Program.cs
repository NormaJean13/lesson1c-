Console.WriteLine("Введите координаты точки ");
Console.Write ("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write ("y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
if(xc > 0 && yc > 0) return "Диапазон соответствует первой четверти";
if(xc < 0 && yc > 0) return "Диапазон соответствует второй четверти";
if(xc < 0 && yc < 0) return "Диапазон соответствует третьей четверти";
if(xc > 0 && yc < 0) return "Диапазон соответствует четвертой четверти"; 
return "Введены некорректные координаты";
}
string result = Quarter (x, y);
Console.WriteLine(result);