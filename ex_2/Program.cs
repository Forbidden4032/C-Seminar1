Console.WriteLine("Введите первое число: ");
int int1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int int2 = int.Parse(Console.ReadLine());
if (int1 > int2)
Console.WriteLine($"Первое число {int1} больше второго числа {int2}");
else
Console.WriteLine($"Второе число {int2} больше первого числа {int1}");