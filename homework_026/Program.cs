// Задача 26: Возведите число А в натуральную степень B используя цикл

int InPut(string message)
{
    Console.Write(message);
    string firstNumberStr = Console.ReadLine();
    int firstNumber = int.Parse(firstNumberStr);
    return firstNumber;
}

void Multiplication(int numberfirst, int numbersecond)
{

    int i = 1;
     int result = numberfirst;
    while(i<numbersecond)
    {
        result = result*numberfirst;
     
        i++;
      }
      Console.Write($"Результат вычисления = {result}");  
    }

    

int digit = InPut("Введите число, которое вы собираетесь возводить в степень: ");


int number = 0;
while( number < 1)
{
  Console.Write("Введите натуральную степень в которую вы хотите возвести число: ");
  string numberStr = Console.ReadLine();
  int.TryParse(numberStr, out number);
}

Multiplication(digit, number);

