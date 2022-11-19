// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


void PrintElement(int [,] matrix, int i, int j)
{
Console.WriteLine($"\nЭлемент массива с такой позицией содержит цифру {matrix[i-1, j-1]}");
}

Console.Clear();

int [,] matrix = new int [3,3];
matrix [0,0] = 6;
matrix [0,1] = 3;
matrix [1,1] = 5;
matrix [1,2] = 5;
matrix [2,0] = 6;
matrix [1,0] = 7;
matrix [0,2] = 8;
matrix [2,1] = 9;
matrix [2,2] = 2;

Console.WriteLine("В этой программе вы можете найти любой элемент массива из трёх строк и трёх колонок по его позиции. Давайте скорее попробуем!");

Console.WriteLine("\nВведите позицию элемента по горизонтали от 1 до 3: ");
int i = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите позицию элемента по вертикали от 1 до 3: ");

int j = int.Parse(Console.ReadLine() ?? "0");

if (i > matrix.GetLength(0) || j > matrix.GetLength(1) || i < 1 || j < 1) Console.WriteLine("\nОх. Такого элемента в массиве нет. Всего три столбца и три строки, помните?)");
else PrintElement(matrix, i, j);

Console.WriteLine();

