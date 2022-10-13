/*Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
*/
Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];
ArrayRandomNumbers(numbers);

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100);
                Console.Write(array[i, j] + " \t");
            }   
            Console.WriteLine();
        }
}

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine($"Элемента с индексами [{n}, {m}] в массиве не существует");
}
else
{
    Console.WriteLine($"Значение элемента с индексами [{n}, {m}] равно {numbers[n-1,m-1]}");
}