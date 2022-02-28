// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

int[] arr = new int[8];

void FillArray()
{
   Random number = new Random();
   Console.WriteLine("Сгенерирован случайный массив: ");
   for(int i = 0; i<arr.Length; i++)
   {
       arr[i] = number.Next(100, 1000);
       Console.Write($"{arr[i]}  ");
   }
}

FillArray();

    int odd = 0;
    int even = 0;
    int ostatok;
   for(int i = 0; i<arr.Length; i++)
   {
      ostatok = arr[i]%2;
      if(ostatok == 0)
      even += 1;
      else if(ostatok != 0)
      odd +=1;
   }

Console.WriteLine();
Console.WriteLine($"Количество четных чисел = {even}");
Console.WriteLine($"Количество нечетных чисел = {odd}");

