/*Задача 51: Задайте двумерный массив. 
Найдите сумму главной диагонали массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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
    int DiagonSum  = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j )
             //if ((i+1) % 2 == 0 && (j+1) % 2 == 0) Если надо пройтись по четным позициям индекса и вывести квадраты этих чисел
                DiagonSum = DiagonSum + matrix[i, j];
        }
        
    }
Console.WriteLine(DiagonSum);
}
//int n = Convert.ToInt32(Console.ReadLine());
//int m = Convert.ToInt32(Console.ReadLine());
//PrintMatr(CreateMatr(n, m));
PrintMatr(CreateMatr(4, 4));




