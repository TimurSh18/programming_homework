// Задача 16: Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным.

int day = 0;
while(day < 1 || day > 7)
{
    Console.Write("Введите день недели от 1 до 7 -> ");
    string dayStr = Console.ReadLine();
    int.TryParse(dayStr, out day);
}

string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};


if (day == 6 || day == 7)
    Console.WriteLine($"Вы выбрали ***{array[day-1]}*** - выходной");
else 
    Console.WriteLine($"Вы выбрали ***{array[day-1]}*** - рабочий день");
