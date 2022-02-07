// Задача 6. Выяснить является ли число чётным.

int number = new Random().Next(1,100);
Console.WriteLine("Сгенерировано число:" + number);


//делим с остатком на 2
int ostatok = number % 2;

if(ostatok == 0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число является нечётным");
}