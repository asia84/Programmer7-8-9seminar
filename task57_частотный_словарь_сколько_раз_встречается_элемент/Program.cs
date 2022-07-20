/*Задача 57/: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

int[, ] TwoMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        //int x = Convert.ToInt32(Console.ReadLine());
        int x = new Random().Next(1, 500);
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



 void AvgMatrix(int[, ] matrix)
{
Console.WriteLine();
int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
int k = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
array[k] = matrix[i, j];
k++;
}
}
for (int i = 0; i < array.Length; i++)
{
int count = 1;
for (int j = 0; j < array.Length; j++)
{
if(array[i] == array[j] && i != j)
count++;
}
Console.WriteLine(array[i] + " встречается " + count + " раз");
}

}
int[, ] matrix = new int[3, 3];
matrix = TwoMatrix(matrix);
AvgMatrix(matrix);