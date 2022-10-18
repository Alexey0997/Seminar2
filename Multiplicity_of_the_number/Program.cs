// Проверить кратность числа 7 и 23.
Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите число: ");
int number = int.Parse(Console.ReadLine()!);
if(number%7 == 0 && number%23 == 0)
{
    Console.WriteLine($"Уважаемый пользователь число {number} кратно 7 и 23.");
}
else
{
     Console.WriteLine($"Уважаемый пользователь число {number} некратно 7 и 23.");
}