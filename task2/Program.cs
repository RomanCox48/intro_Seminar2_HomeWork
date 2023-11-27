// Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.


Console.WriteLine("Введите значения x и y, отличные от `0`.");
Console.WriteLine("Введите значение x:");
int x = Convert.ToInt32(Console.ReadLine());
while (x == 0)
{
    Console.WriteLine("Введите значение x, отличное от `0`:");
    x = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите значение y:");
int y = Convert.ToInt32(Console.ReadLine());
while (y == 0)
{
    Console.WriteLine("Введите значение y, отличное от `0`:");
    y = Convert.ToInt32(Console.ReadLine());
}

if (x > 0 && y>0)
{
    Console.WriteLine("Номер координатной четверти для точки x = "+ x+" и y = "+y+" равен 1");
}
else if (x < 0 && y>0)
{
    Console.WriteLine("Номер координатной четверти для точки x = "+ x+" и y = "+y+" равен 2");
}
else if (x < 0 && y<0)
{
    Console.WriteLine("Номер координатной четверти для точки x = "+ x+" и y = "+y+" равен 3");
}
else
{
    Console.WriteLine("Номер координатной четверти для точки x = "+ x+" и y = "+y+" равен 4");
}