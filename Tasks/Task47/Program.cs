﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] arrayRealNumbers = new double[n, m];
for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arrayRealNumbers[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            Console.Write(arrayRealNumbers[i, j] + " \t");
        }
        Console.WriteLine();
    }