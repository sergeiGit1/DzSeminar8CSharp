// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = 2;
int cols = 2;
Console.WriteLine("Первая матрица:");
int[,] firstMatrix = GetMatrix(rows, cols);
PrintMatrix(firstMatrix);
Console.WriteLine("Вторая матрица:");
int[,] secondMatrix = GetMatrix(rows, cols);
PrintMatrix(secondMatrix);
Console.WriteLine("Произведение матриц:");
GetMatrixProduct(firstMatrix, secondMatrix, rows, cols);

/// <summary>
/// Метод находит произведение двух матриц
/// </summary>
/// <param name="firstMatr">Первая матрица</param>
/// <param name="secondMatr">Вторая матрица</param>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
void GetMatrixProduct(int[,] firstMatr, int[,] secondMatr, int rows, int cols)
{
    int[,] matrProduct = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < rows; k++)
            {
                matrProduct[i, j] += firstMatr[i, k] * secondMatr[k, j];
            }
            Console.Write(matrProduct[i, j] + "\t");
        }
        if (i == cols % 2)
        {
            Console.WriteLine();
        }
    }
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