// Задача 20. Задать номер четверти, показать диапазоны для возможных координат.

int InPut(string message)
{
    Console.Write(message);
    string aStr = Console.ReadLine();
    int aInt = int.Parse(aStr);

    return aInt;
}

int quarter = 0;
while(quarter < 1 || quarter > 4)
{
int quarterCheck = InPut("Введите нужную вам четверть (от 1 до 4) ->  ");
quarter = quarterCheck;
}

if(quarter == 1)
Console.WriteLine("I четверть -> x == (0; +бесконечность) y == (0; +бесконечность)");

else if (quarter == 2)
Console.WriteLine("II четверть -> x == (-бесконечность; 0) y == (0; +бесконечность)");


else if(quarter == 3)
Console.WriteLine("III четверть -> x == (-бесконечность; 0) y == (-бесконечность; 0)");

else if (quarter == 4)
Console.WriteLine("IV четверть -> x == (0; +бесконечность) y == (-бесконечность; 0)");
