﻿Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i++){
    if (i % 2 == 0) Console.Write(i + " ");
}