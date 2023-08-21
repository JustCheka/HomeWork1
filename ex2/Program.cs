Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c) Console.WriteLine($"Самое большое число = {a}");
else if (b > a && b > c) Console.WriteLine($"Самое большое число = {b}");
else if (c > a && c > b) Console.WriteLine($"Самое большое число = {c}");