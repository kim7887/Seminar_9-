﻿// Задача 65. Задайте значение M и N. Напишите программу, которая выдаёт все натуральные  числа от M до N.
Console.WriteLine("Введите начальное число M:");
int inputM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число N:");
int inputN =Convert.ToInt32(Console.ReadLine());

void Perechislenie(int LastNumber, int FirstNumber)
{
    if (LastNumber <= FirstNumber -1) return;
    Perechislenie(LastNumber - 1, FirstNumber);
    Console.Write(LastNumber + ",");
}
Perechislenie(inputN, inputM);