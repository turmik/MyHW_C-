int num = new Random().Next(100,1000);
int a1 = num / 10;
int a2 = a1 % 10;

Console.WriteLine($"{a2} является наибольшей цифрой числа {num}");


