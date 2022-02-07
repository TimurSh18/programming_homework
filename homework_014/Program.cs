Console.Write("Введите число: ");

string valueStr = Console.ReadLine();
if (int.TryParse(valueStr, out int valueInt))
{
    string resultValue = valueInt.ToString(); // Число обратно в строку
   if(resultValue.Length >=3)
   Console.WriteLine($"Третья цифры числа =   {valueStr[2]}"); // выводится 3 цифра числа [0, 1, 2]
   else
   Console.WriteLine("Число не трёхзначное");
}

else
Console.WriteLine("В данном числе отсутствует третья цифра");