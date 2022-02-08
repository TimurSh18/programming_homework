// Задача 16: Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным.

int InPut(string message)
{
    Console.Write(message);
    string dayStr = Console.ReadLine();
    int dayInt = int.Parse(dayStr);

    return dayInt;
}

string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

int day = InPut("Введите день недели от 1 до 7: ");

if (day == 6 || day == 7)
    Console.WriteLine($"Вы выбрали ***{array[day-1]}*** - выходной");

else if (day < 1 || day > 7)
    Console.WriteLine("Такого дня недели не существует");

else 
    Console.WriteLine($"Вы выбрали ***{array[day-1]}*** - рабочий день");
