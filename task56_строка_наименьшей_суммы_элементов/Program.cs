/*Задача 56/ Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[, ] TwoMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        //int x = Convert.ToInt32(Console.ReadLine());
        int x = new Random().Next(1, 100);
        matrix[i , j] = x;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    return matrix;
}

void ProMatrix(int[, ] matrix)
{
    Console.WriteLine();
    int minrow = 1000;
    int gmin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow = sumrow + matrix[i, j];
        }
        if (sumrow < minrow)
        {
            minrow = sumrow;
            gmin = i + 1;
        }
    }
    Console.WriteLine( " минимальная сумма " + gmin + " строки " +   minrow );

}

int[, ] matrix = new int[3, 3];
matrix = TwoMatrix(matrix);
ProMatrix(matrix);
