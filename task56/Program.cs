// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

int rows = 3;
int cols = 4;
int[,] matrix = GetMatrix(rows, cols);
PrintMatrix(matrix);
FindMinSum(matrix, rows);

/// <summary>
/// Метод считает сумму элементов строки и выводит строку с минимальной суммой
/// </summary>
/// <param name="matrix">Входящая матрица</param>
/// <param name="rows">Количество строк</param>
void FindMinSum(int[,] matrix, int rows)
{
    int[] sum = new int[rows];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
            if (j == matrix.GetLength(1))
            {
                i++;
            }
        }
    }
    int min = int.MaxValue;
    int minIndex = 0;
    for (int k = 0; k < sum.Length; k++)
    {
        if (sum[k] < min)
        {
            min = sum[k];
            minIndex = k;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {minIndex + 1}");
}

/// <summary>
/// Метод заполняет двумерный массив числами от 1 до 10
/// </summary>
/// <param name="cols">Количество столбцов</param>
/// <param name="rows">Количество строк</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
int[,] GetMatrix(int cols, int rows)
{
    int[,] matrix = new int[cols, rows];
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}

/// <summary>
/// Метод печатает матрицу, которую передали на вход
/// </summary>
/// <param name="inputMatrix">Переданная матрица</param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


