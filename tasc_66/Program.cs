﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int m = Prompt("Введите целое число M");
int n = Prompt("Введите целое число N");

int sumOfNumbers(int m, int mn)
{
    if (n == m) return n;
    return m + sumOfNumbers(m + 1, n);
}

Console.WriteLine($"Сумма чисел равна: {sumOfNumbers(m, n)}");