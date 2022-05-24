// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] GetArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int[,] ChangeToSquareEvenIndex(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
            else arr[i, j] = arr[i, j];
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($" {array[i, j]}   ");
            else Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int row = 5;
int col = 10;
int min = 1;
int max = 7;

int[,] mainArray = GetArray(row, col, min, max);
PrintArray(mainArray);
Console.WriteLine("***********************************************");
int[,] chagedArray = ChangeToSquareEvenIndex(mainArray);
PrintArray(chagedArray);