// Задача 48: Показать двумерный массив размером m×n заполненный целыми числами.


void PrintFillMatrix(int[,] matrFill)
{
    Random numberToFill = new Random();

    for(int j = 0; j<matrFill.GetLength(0); j++)
    {
        for(int k=0; k<matrFill.GetLength(1); k++)
        {
        
            matrFill[j,k] = numberToFill.Next(1,100);
            Console.Write($"{matrFill[j,k]}  ");        
        }
        Console.WriteLine();
    }

}

int[,] matrix = new int [2,5];
PrintFillMatrix(matrix);
