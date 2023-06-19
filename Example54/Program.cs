/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using System;
using static System.Console;
Clear();

WriteLine("Введите число m: ");
int m = int.Parse(ReadLine());
WriteLine("Введите число n: ");
int n = int.Parse(ReadLine());
int[,] array = GetArray(m, n);
PrintArray(array);
BubleSort(array);
WriteLine();
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(0, 100);
            }
       }
    return result;
}
void BubleSort(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1) - 1; k++)
            {
            if (array1[i, k] < array1[i, k + 1])
            {
                int temp = array1[i, k + 1];
                array1[i, k + 1] = array1[i, k];
                array1[i, k] = temp;
            }
        }
    }
   }
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