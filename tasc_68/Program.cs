﻿﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 9
// m = 2, n = 3 -> A(m,n) = 29

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int m = Prompt("Введите целое число M");
int n = Prompt("Введите целое число N");

int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return AckermanFunction(n - 1, 1);
    return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

Console.WriteLine(AckermanFunction(n, m));