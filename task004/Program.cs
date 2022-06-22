/* Задача 4: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите целое положительное число ");
int NumN = int.Parse(Console.ReadLine());

if (NumN > 0)
{
    int count = 2;
    while (count <= NumN)
    {
        Console.Write($" {count} ");
        count = count + 2;
    }
}
else
{
    if (NumN <= 0) Console.WriteLine("Ввели не верное число. ");
}