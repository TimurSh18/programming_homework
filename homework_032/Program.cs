// Задача 32: Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] arr = new int[8];

void FullArray()
{
   Random number = new Random();

   for(int i = 0; i<arr.Length; i++)
   {
       arr[i] = number.Next(0,2);
       Console.WriteLine($"{arr[i]}  ");
   }
}
FullArray();