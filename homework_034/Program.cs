// Задача 34: Написать программу замену элементов массива на противоположные.

int[] arr = new int[8];

void FillArray()
{
   Random number = new Random();
   Console.WriteLine("Сгенерирован случайный массив: ");
   for(int i = 0; i<arr.Length; i++)
   {
       arr[i] = number.Next(-10, 11);
       Console.Write($"{arr[i]}  ");
   }
}

FillArray();
// Далее метод замены чисел массива на противоположные, то есть, умножаем каждое число на -1

Console.WriteLine();
Console.WriteLine("Массив с замененными числами: ");

for(int i = 0; i<arr.Length; i++)
{
    arr[i] = arr[i] * -1;
    Console.Write($"{arr[i]}  ");
}