// Задача 40: В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

double[] arr = new double[5];

void FillArray()
{
    Random number = new Random();
    Console.WriteLine("Сгенерирован случайный массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.NextDouble()*40 - 20; // вычитал в интернете как делать рандомные числа для вещественных, для расширения границ.
        Console.Write($"{arr[i]}  ");
    }
}

FillArray();
double max = arr[0];
double min = arr[0];
double result;
for(int i = 0; i<arr.Length; i++)
{
    if(arr[i]>max)
    max = arr[i];
    else if (arr[i] < min)
    min = arr[i];
}

result = max - min;

Console.WriteLine();
Console.WriteLine($"Минимальное число в массиве = {min}");
Console.WriteLine($"Максимальное число в массиве = {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами = {result}");