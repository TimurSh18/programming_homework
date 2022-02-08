// Задача 14: Найти третью цифру числа или сообщить, что её нет.

Console.Write("Введите число: ");

string valueStr = Console.ReadLine();
if (int.TryParse(valueStr, out int valueInt)) //Проверка на число
{
    string resultValue = valueInt.ToString(); // Число обратно в строку
   if(resultValue.Length >=3)
   Console.WriteLine($"Третья цифра числа =  {valueStr[2]}"); // выводится 3 цифра числа [0, 1, 2]
   else
   Console.WriteLine("В числе отсутствует третья цифра");
}

else
Console.Write("Вы ввели не число!");