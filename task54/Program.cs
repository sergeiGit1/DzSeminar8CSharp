// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 

int[,] matrix = GetMatrix(3, 3);
Console.WriteLine("Изначальная матрица");
PrintMatrix(matrix);

Console.WriteLine();
Console.WriteLine("Отсортированная матрица:");
SortingMatrix(matrix);
PrintMatrix(matrix);

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

/// <summary>
/// Метод сортирует матрицу 
/// </summary>
/// <param name="matr">Входящая матрица</param>
void SortingMatrix(int[,] matr)
{
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] > matr[i, j])
                {
                    temp = matr[i, k];
                    matr[i, k] = matr[i, j];
                    matr[i, j] = temp;
                }
            }
        }
    }
}







