// Задача № 4. Найти максимальное из трёх чисел

int FindMaxNumber(int first, int second, int third)
{
     int max = first;
     
     if(second > max)
     max = second;
     if(third > max)
     max = third;

 return max;
}

Console.Write("Введите первое число -> ");
string firstStr = Console.ReadLine();
Console.Write("Введите второе число -> ");
string secondStr = Console.ReadLine();
Console.Write("Введите третье чилсо -> ");
string thirdStr = Console.ReadLine();

int numberOne = int.Parse(firstStr);
int numberTwo = int.Parse(secondStr);
int numberThree = int.Parse(thirdStr);

int result = FindMaxNumber(numberOne, numberTwo, numberThree);
Console.WriteLine($"Пользователем даны следующие числа -> {numberOne}, {numberTwo}, {numberThree}");
Console.Write($"Наибольшим числом является: {result}");