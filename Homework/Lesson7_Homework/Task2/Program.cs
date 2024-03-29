﻿// Задача 2.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// 
// Пример:
// m = 2, n = 3 -> A(m,n) = 29 
// 
// Ремарка: По таблице значений для функции Аккермана, n - столбцы, m - строки. (ВАЖНО !!!)
// Из-за этого правильный пример должен выглядеть так:
// n = 3, m = 2  -> A(n,m) = 29 
// n = 3, m = 11 -> A(n,m) = 16381 

int ack(int n, int m)                       // A(n,m)
{
    if (n == 0) return m + 1;               // m + 1, если (n = 0)

    if (n > 0 && m == 0)                    // A(n - 1, 1), если (n > 0) и (m = 0)
    {
        return ack(n - 1, 1);               
    }

    return ack(n - 1, ack(n, m - 1));       // A(n - 1, A(n, m - 1)), если (n > 0) и (m > 0)
}

Console.Write("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

int result = ack(n, m);
Console.Write($"n = {n}, m = {m} -> A(n,m) = {result}");


