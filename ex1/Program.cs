Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());

if (numA > numB){
    Console.WriteLine("Число А больше числа Б");
}
else if (numB > numA){
    Console.WriteLine("Число Б больше числа А");
}
else Console.WriteLine("Числа равны");