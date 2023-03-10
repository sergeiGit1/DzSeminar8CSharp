// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = Get3DArray(2, 2, 2);
Print3DArray(array);

/// <summary>
/// Метод заполняет трехмерный массив числами от 10 до 99
/// </summary>
/// <param name="cols">Количество столбцов</param>
/// <param name="rows">Количество строк</param>
/// <param name="page">Количество страниц</param>
/// <returns>Заполненный трехмерный массив целых чисел</returns>
int[,,] Get3DArray(int cols, int rows, int page)
{
    int[,,] threeDimensionalArray = new int[cols, rows, page];
    int number = 10;
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < page; k++)
            {
                threeDimensionalArray[i, j, k] = number;
                number += 11; // условия чтоб числа были рандомными не было
            }
        }
    }
    return threeDimensionalArray;
}

/// <summary>
/// Печатает трехмерный массив с индексами, который передали на вход
/// </summary>
/// <param name="inputArray">Входящий массив</param>
void Print3DArray(int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write($"{inputArray[i, j, k]}({i})({j})({k}) \t");
            }
            Console.WriteLine();
        }
    }
}

