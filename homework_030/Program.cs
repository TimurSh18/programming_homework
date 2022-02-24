// Задача 30: Показать кубы чисел, заканчивающихся на четную цифру
// Если я правильно понял задание
// нужно возводить в куб четные числа, а не показывать кубы, которые заканчиваются на четную цифру

int[] arr = new int[10];

void FullArray()
{
   Random number = new Random();

   for(int i = 0; i<arr.Length; i++)
   {
       arr[i] = number.Next(1,100);
       Console.WriteLine($"{arr[i]}  ");
   }
}
Console.WriteLine("Сгенерирован массив из случайных чисел: ");
FullArray();

int ostatok, result;
Console.WriteLine("Кубы чисел оканчивающиеся на четные числа: ");
for(int i = 0; i<arr.Length; i++)
{
    ostatok = arr[i]%2;
    if(ostatok == 0)
    {
        result = arr[i]*arr[i]*arr[i];
        Console.Write($"{result}   ");
    }
}