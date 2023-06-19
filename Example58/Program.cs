/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
using System;
using static System.Console;
Clear();

WriteLine("Введите число m: ");
int m = int.Parse(ReadLine());
WriteLine("Введите число n: ");
int n = int.Parse(ReadLine());
WriteLine("Введите число m1: ");
int m1 = int.Parse(ReadLine());
WriteLine("Введите число n1: ");
int n1 = int.Parse(ReadLine());
int[,] array = GetArray(m, n);
PrintArray(array);
WriteLine();
int[,] array1 = GetArray1(m1, n1);
PrintArray(array1);
WriteLine();

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(1, 10);
            }
       }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 5} ");
        }
    WriteLine();
    }
}
int[,] GetArray1(int m1, int n1)
{
    int[,] result1 = new int[m1, n1];
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
            {
                result1[i, j] = new Random().Next(1, 10);
            }
       }
    return result1;
}
void PrintArray1(int[,] inArray1)
{
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray1.GetLength(1); j++)
        {
            Write($"{inArray1[i, j], 5} ");
        }
    WriteLine();
    }
}
int[,] ProductOfArrays(int[,] array, int[,] array1)
{
    int[,] array2 = new int[array.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array2[i, j] += array[i, k] * array1[k, j];
            }
        }
    }
    return array2;
}
PrintArray(ProductOfArrays(array, array1));


