// Задача 28: Подсчитать сумму цифр в числе

int InPut(string message)
{
    Console.Write(message);
    string numberStr = Console.ReadLine();
    int numberInt = int.Parse(numberStr);
    return numberInt;
}

int resultSum(int number)
{
    int result = 0;
    int digit = 0;
    string count = number.ToString();
    int i = 0;
    while(i<count.Length)
    {
        digit = number % 10;
        number = number / 10;
        result = result + digit;
        i++;
    }
    return result;
}

int n = InPut("Введите число: ");
int ourResult = resultSum(n);

Console.WriteLine($"Сумма цифр в числе = {ourResult}");