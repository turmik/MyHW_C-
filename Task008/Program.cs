Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

for ( ; num > 1 ; num = num - 1);
   {
       if (num % 2 == 0);
    Console.WriteLine($"{num}");
   }



