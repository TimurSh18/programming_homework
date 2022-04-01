// Задача 54: В матрице чисел найти сумму элементов главной диагонали.
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

int[,] matrix = new int [3,3];
PrintFillMatrix(matrix);

int sum = 0, z = 0, i = 0;
    while(i<matrix.GetLength(0))
    {
        while(z<matrix.GetLength(1))
        {
            sum += matrix[i,z];
            z++;
            break;
        }
        i++;
        
    }

Console.WriteLine($"Сумма равна {sum}");