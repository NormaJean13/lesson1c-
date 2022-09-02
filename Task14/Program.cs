Console.Clear();
Console.WriteLine("Привет пользователь, введи число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num7 = 7;
int num23 = 23;


if ((num1 % num7 == 0) && (num1 % num23 == 0))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
