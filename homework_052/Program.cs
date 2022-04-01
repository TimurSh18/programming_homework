// Задача 52: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.


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


int[,] matrix = new int [5, 6];
PrintFillMatrix(matrix);
Console.WriteLine("===================================");

int firstOst, secondOst;
for(int z = 0; z<matrix.GetLength(0); z++) // 
{
    for(int q = 0; q<matrix.GetLongLength(1); q++)
    {
        firstOst = z%2;
        secondOst = q%2;
        if(q != 0 && z != 0)
        {
            if(firstOst == 0 && secondOst == 0)
            matrix[z,q] = matrix[z,q]*matrix[z,q];
        }
        
        
        Console.Write($"{matrix[z,q]}  ");
    }
    Console.WriteLine();
}