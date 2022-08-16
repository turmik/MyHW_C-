/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("ВВедите число A: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = int.Parse(Console.ReadLine());
Console.Write("Введите число C: ");
int NumberС = int.Parse(Console.ReadLine());
int max = NumberA;
if (NumberA < NumberB)  max = NumberB;

if (NumberС > max) max = NumberС;

Console.Write("max = ");
Console.WriteLine(max);


