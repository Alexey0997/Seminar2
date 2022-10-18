//  По двум заданным числам проверить является ли одно квадратом другого.
Console.Clear();
Console.Write("Уважаемый пользователь, введите первое число: ");
int number1 = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if(number1 == number2 * number2)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
if(number2 == number1 * number1)
{
    Console.WriteLine($"Число {number2} является квадратом числа {number1}");
}
if(number2 != number1 * number1 && number1 != number2 * number2)
{
    Console.WriteLine($"Одно число не является квадратом другого.");
}