/*Задача 58/: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

int[,] FirstArray(int m, int n)
{
    int[,] matrix1 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix1[i, j] = new Random().Next(1, 50);
            Console.Write(matrix1[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix1;
}
int[,] SecondArray(int m, int n)
{
    int[,] matrix2 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix2[i, j] = new Random().Next(1, 50);
            Console.Write(matrix2[i, j] + " \t");
        }
        Console.WriteLine();
    }
    return matrix2;
}

void CheckMatrix(int[,] matrix1, int[,] matrix2)
{
    Console.WriteLine();
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write(result[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


CheckMatrix(FirstArray(4, 4), SecondArray(4, 4));