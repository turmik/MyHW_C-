/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3Console.Write("Введите число A: ");*/

int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите чиcло B: ");
int NumberB = int.Parse(Console.ReadLine());

if ( NumberA > NumberB )
Console.Write($"{NumberA} большее, {NumberB} меньшее");

else
Console.Write($"{NumberB} большее, {NumberA} меньшее");







