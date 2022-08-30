Console.WriteLine("Введите первое число: ");
int int1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int int2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int int3 = int.Parse(Console.ReadLine());
int max = int1;

if (max < int2) max = int2;
if (max < int3) max = int3;

Console.WriteLine($"Максимальное из трех чисел: {max}");


