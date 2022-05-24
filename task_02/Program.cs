// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] GetTableDouble(int m, int n)
{
    double[,] table = new double[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().NextDouble() * 100;
        }
    }
    return table;
}

void PrintTable(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write(tab[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

int m = 8;
int n = 4;
double[,] TableDouble = GetTableDouble(m, n);
PrintTable(TableDouble);