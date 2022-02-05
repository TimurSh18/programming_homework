// Задача 2.  Даны 2 числа. Показать большее и меньшее число

Console.Write("Введите первое число: ");
string firstNumber = Console.ReadLine();
Console.Write("Введите второе число: ");
string secondNumber = Console.ReadLine();

int numberOne = int.Parse(firstNumber);
int numberTwo = int.Parse(secondNumber);

if(numberOne > numberTwo)
{
    Console.Write($"Наибольшее число = {numberOne}. Наименьшее число = {numberTwo}");
}
else
{
    Console.Write($"Наибольшее число = {numberTwo}. Наименьшее число = {numberOne}");
}