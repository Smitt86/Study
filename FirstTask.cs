﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Ищем большее значение из двух чисел");
Console.WriteLine("Введите первое число");
int first = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе число");
int second = int.Parse (Console.ReadLine());

if (first > second)
{
    Console.WriteLine($"Большее значение = {first} Меньшее значение = {second}");
}   
else 
{
    Console.Write($"Большее значение = {second} Меньшее значение = {first}");   
}