// Задача 38: Найти сумму чисел одномерного массива стоящих на нечетной позиции.

//        [1] индекс = 0, но позиция нечетная; [2] индекс = 1, но позиция четная, исхожу из этой логики.
// Представим массив: {1, 2, 3, 4, 5}
// позиция != индексу.


int[] arr = new int[8];

void FillArray()
{
    Random number = new Random();
    Console.WriteLine("Сгенерирован случайный массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(1, 1000);
        Console.Write($"{arr[i]}  ");
    }
}

FillArray();

int result = 0;
int i =0;
while(i<arr.Length)
{
    result += arr[i];
    i += 2;
}

Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции = {result}");
