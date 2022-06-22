/* Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите первое число ");
int NumA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int NumB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int NumC = int.Parse(Console.ReadLine());

int max = NumA;

if (NumB > max) max = NumB;
if (NumC > max) max = NumC;
Console.WriteLine($"Max = {max}");

