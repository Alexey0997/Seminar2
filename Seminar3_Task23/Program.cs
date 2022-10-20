// Напишите программу, которая на вход принимает число (N) и выдает
// таблицу кубов чисел от 1 до N. Например, 3-> 1, 8, 27.
Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите целое число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
Console.WriteLine($"Таблица кубов от 1 до {number}: ");
while(count <= number)
{
    int result = count * count * count;
    Console.Write($"{result}, ");
    count++;
}