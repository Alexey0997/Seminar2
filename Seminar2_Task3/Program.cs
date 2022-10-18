// Задать номер четверти, показать диапазоны для возможных координат. 
Console.Clear();
Console.Write("Уважаемый пользователь, введите координату Х: ");
int X = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine()!);
if(X > 0 && Y > 0)
{
    Console.Write("Первая четверть. Диапазон возможных координат Х(0, PositiveInfinity), Y(0, PositiveInfinity).");
}
if(X < 0 && Y > 0)
{
    Console.Write("Вторая четверть. Диапазон возможных координат Х(NegativeInfinity, 0), Y(0, PositiveInfinity).");
}
if(X < 0 && Y < 0)
{
    Console.Write("Третья четверть. Диапазон возможных координат Х(NegativeInfinity, 0), Y(NegativeInfinity, 0).");
}
if(X > 0 && Y < 0)
{
    Console.Write("Четвертая четверть. Диапазон возможных координат Х(0, PositiveInfinity), Y(NegativeInfinity, 0).");
}