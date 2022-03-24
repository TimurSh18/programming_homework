// Задача 46: Написать программу масштабирования фигуры (Работал по объяснению с вебинара)


using System.Text;

string strValue = "(0,0) (2,0) (2,2) (0,2)";
Console.WriteLine("Введите множитель: ");
int k = int.Parse(Console.ReadLine());

// удаляем "(" и ")"
strValue = strValue.Replace("(", "").Replace(")","").Replace(",", " ");

//Разбиваем строку на массив, разделитем будет являться " " - пробел
string[] strArray = strValue.Split(" ");
string result = string.Empty;

Console.WriteLine();
StringBuilder builder = new StringBuilder();


for(int i = 0; i < strArray.Length; i = i + 2)
{
    int x = k * int.Parse(strArray[i]);
    int y = k * int.Parse(strArray[i+1]);

    Console.WriteLine($"x = {x}, y = {y}");

    builder.Append($"({x}, {y}) ");
}

Console.WriteLine("=====================");

Console.WriteLine(builder.ToString());