﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(6 -> да; 7 -> да; 1 -> нет)

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n < 1 || n > 7)
    Console.WriteLine("Введите число дня недели от 1 до 7!!!");
else if (n == 6 || n ==7 )
    Console.WriteLine("Да");
else if (n > 0 || n < 6) 
    Console.WriteLine("Нет");

