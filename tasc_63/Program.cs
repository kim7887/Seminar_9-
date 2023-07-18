﻿// Задача 63. Задайте значение N. Напишите программу, которая выдаёт все натуральные  числа от 1 до N.
Console.WriteLine("Введите целое  число N");
int number=Convert.ToInt32(Console.ReadLine());

void Perechislenie(int LastNumber)
{
    if (LastNumber <= 0) return;
    Perechislenie(LastNumber - 1);
    Console.Write(LastNumber + "");
}
Perechislenie(number);