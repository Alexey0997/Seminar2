// Определить номер четверти плоскости, в которой находится точка
// с координатами Х и Y при условии, что координаты не равны нулю. 
Console.Clear();
Console.Write("Уважаемый пользователь, введите координату Х: ");
int X = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine()!);
if(X > 0 && Y > 0)
{
    Console.Write("Первая четверть.");
}
if(X < 0 && Y > 0)
{
    Console.Write("Вторая четверть.");
}
if(X < 0 && Y < 0)
{
    Console.Write("Третья четверть.");
}
if(X > 0 && Y < 0)
{
    Console.Write("Четвертая четверть.");
}