/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
новый будет выглядеть так:
1  4  7  2
5  81 2  9
8  4  2  4
*/

int[, ] CreateMatr(int n, int m)
{
    int[, ] matrix = new int[n, m];//заводим матрицу
    for (int i = 0; i < matrix.GetLength(0); i++)//количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//количество столбцов
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write(matrix[i, j] + " ");
            //matrix[i, j] = Convert.ToInt32(Console.Readline()); //с пользователем
            
        }
        Console.WriteLine();
    }
return matrix;//возвращаем в то место, откуда вызвали эту функцию
}
//процедура, отвечающая за вывод двумерного массива

void PrintMatr(int[, ] matrix)

{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 ==1)
             //if ((i+1) % 2 == 0 && (j+1) % 2 == 0) Если надо пройтись по четным позициям индекса и вывести квадраты этих чисел
                matrix[i,j] =  matrix[i,j] * matrix[i,j];

            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


PrintMatr(CreateMatr(3, 4));





