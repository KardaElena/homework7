// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double GetArithmeticMean(int [,] matrix, int j)
{
double summ = 0;
double arithmeticMean;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ = matrix[i,j] + summ;
        }
arithmeticMean = summ/matrix.GetLength(0);
return arithmeticMean;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} ");
else Console.Write($"{matrix[i,j], 5}");
}
Console.WriteLine();
}
}

Console.Clear();

int [,] matrix = {{5, 5, 2}, {3, 4, 4}, {2, 3, 3}, {3, 5, 1}};

PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine();

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double am = GetArithmeticMean(matrix, j);
    Console.Write($"{am}; ");
}

Console.WriteLine();
Console.WriteLine();

