/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/


int f(int a, int b)
{
    if(b==0)
        return 1;
    return f(a, b - 1) *a;
}


Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} будет равно " + f(a, b));
