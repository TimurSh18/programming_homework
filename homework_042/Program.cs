// Задача 42. Выяснить, сколько чисел больше 0 было введено с клавиатуры

int[] numbers = new int[8];

void FillArray()
{
    int digit = 1;
   for(int i = 0; i<numbers.Length; i++)
   {
       Console.Write($"Введите {digit} число:  ");
       numbers[i] = int.Parse(Console.ReadLine());
       digit++;
   }

   Console.WriteLine("Сгенерирован массив из введённых чисел: "); 

   int pos = 0;
   while(pos<numbers.Length)
   {
       Console.Write($"{numbers[pos]}; ");
       pos++;
   }
   Console.WriteLine();
}

FillArray();

int position = 0;
int result = 0;
while(position<numbers.Length)
{
    if(numbers[position]>0)
    result++;
    position++;
}


Console.WriteLine($"Количество чисел больше 0 = {result}");