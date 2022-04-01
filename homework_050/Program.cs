// Задача 50: В двумерном массиве n×k заменить четные элементы на противоположные.

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

int[,] matrix = new int [2,3];
PrintFillMatrix(matrix);

Console.WriteLine();

int ostatok;

for(int q = 0; q<matrix.GetLength(0); q++)
    {
        for(int z=0; z<matrix.GetLength(1); z++)
        {
            ostatok = matrix[q,z] % 2;
            if(ostatok == 0)
            {
                matrix[q,z] = matrix[q,z] * -1;
            
            }
             Console.Write($"{matrix[q,z]}  ");     
        }
        Console.WriteLine();
    }

