// Дан текст, в котором пробелы необходимо заменить черточками, 
// маленькие буквы "к" - большими "К", а большие "С" - маленькими "с".
Console.Clear();
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы Вас послали вместо нашего милого Винценгороде,"
            + "Вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;       // Размер - длина текста. 
    for(int i = 0; i < length; i++) // Начиная с первой буквы до окончания текста. 
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '!'); // Меняем пробелы на "!".
Console.WriteLine(newText);               // Печатаем новый текст. 
Console.WriteLine();                      // Вводим пустую строку.
newText = Replace(newText, 'к', 'К');     // Меняем буквы "к" на "К".
Console.WriteLine(newText);               // Печатаем новый текст. 
Console.WriteLine();                      // Вводим пустую строку.
newText = Replace(newText, 'С', 'с');     // Меняем буквы "С" на "с".
Console.WriteLine(newText);               // Печатаем новый текст. 
Console.WriteLine();
newText = Replace(newText, 'я', 'I');     // Меняем буквы "я" на "I".
Console.WriteLine(newText);               // Печатаем новый текст. 
Console.WriteLine();
newText = Replace(newText, '!', '-');     // Меняем "!" на "-".
Console.WriteLine(newText);               // Печатаем новый текст. 
Console.WriteLine();
