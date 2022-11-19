// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] FillMatrix(int m, int n)
{
double[,] result = new double[m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
result[i, j] = new Random().NextDouble();
}
}
return result;
}


void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 24} ");
else Console.Write($"{matrix[i,j], 24}");
}
Console.WriteLine();
}
}


Console.Clear();
int m = 4;
int n = 5;
double [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
