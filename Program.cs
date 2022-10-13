﻿/************************************************************************************************
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
**************************************************************************************************/

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A} в степени {B} = {GetPow(A, B)}");

int GetPow (int Num, int Pow){
    int count = 1;
    for(int i = 1; i <= Pow; i++){
        count = count * Num;
    }
    return count;
}
