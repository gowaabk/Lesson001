/* Задача 1:
Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 ->  max = 7, min = 5
a = -9 b = -3 -> max = -3, min = -9 */

Console.Write("Введите первое число ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNum = int.Parse(Console.ReadLine());

if (firstNum > secondNum) Console.WriteLine($" Max = {firstNum} ");
else
{
    if (firstNum < secondNum) Console.WriteLine($" Max = {secondNum}");
    else
    {
        Console.WriteLine(" Введены одинаковые числа.");
    }
}

