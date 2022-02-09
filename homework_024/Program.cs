// Задача 24. Найти кубы чисел от 1 до N

int InPut(string message)
{
    Console.Write(message);
    string aStr = Console.ReadLine();
    int aInt = int.Parse(aStr);

    return aInt;
}

int a = InPut("Введите число до которого хотите посмотреть кубы чисел: ");
int i = 1;

while(i < a) // Цикл для выведения кубов чисел, решил сделать без массива
{
    Console.Write($"Куб числа {i} = ");
    Console.WriteLine(i*i*i);
    i++;
}