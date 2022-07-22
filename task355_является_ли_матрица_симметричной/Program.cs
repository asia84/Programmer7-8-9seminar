int[, ] CreateArray(int m, int n)
{
    int [, ]matrix1 = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.Write(matrix1[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix1;
}

void CheckMatrix(int[,] matrix)
{
    bool flag = true;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] != matrix1[j, i] && i != j);
            {
                flag = false;
                break;
            }
        }
    }
    if(flag)
        Console.WriteLine("YES");
    else
        Console.WriteLine("No");
}



