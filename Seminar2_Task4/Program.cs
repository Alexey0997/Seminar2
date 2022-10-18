// Найти расстояние между двумя точками в пространстве 2D/3D.
Console.Clear();
// Запрос координат точки 1.
Console.WriteLine("Уважаемый пользователь, введите координату X точки 1: ");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 1: ");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки 1 (при расчете в 2D введите 0): ");
int Z1 = int.Parse(Console.ReadLine());
// Запрос координат точки 2.
Console.WriteLine("Уважаемый пользователь, введите координату X точки 2: ");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 2: ");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки 2 (при расчете в 2D введите 0): ");
int Z2 = int.Parse(Console.ReadLine());
// Рассчет расстояния между точками 1 и 2.
double distance = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
Console.WriteLine($"Расстояние между точками 1 и 2 = {distance}.");