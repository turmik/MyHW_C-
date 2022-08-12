Console.Write("Введите число");
int a = int.Parse(Console.ReadLine());
int a1 = a % 1000;
int a2 = a1 / 100;


if (a < 100) 
   Console.WriteLine("Третьей цифры нет");

else 
    Console.WriteLine($"{a2}");



