﻿// Задача 4.
// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.
// Пример
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");
if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 100000)
{
    //  Находим количество разрядов числа.
    int i = 0;
    int localNumber = number;
    while (localNumber > 0)
    {
        localNumber /= 10;
        i++;
    }

    //  Инциализируем массив и выделяем ему память на основе разрядов введённого числа.
    int[] array = new int[i];

    i = 0;
    int j = array.Length;
    localNumber = number;
    Console.Write($"{number} => [");                // Красивая отрисовка массива. Начало.
    while (localNumber > 0)
    {
        array[j - i - 1] = localNumber % 10;        // Заполняем массив с последнего идекса, цифрой разряда единиц числа 'localNumber'.
        localNumber /= 10;
        i++;
    }

    for (i = 0; i < array.Length - 1; i++)          // Просматриваем массив до предпоследнего элемента.
    {
        Console.Write($"{array[i]} ");              // Вывод элементов массива до предпоследнего элемента.
    }
    Console.Write($"{array[array.Length - 1]}]");   // Красивая отрисовка массива. Конец. Вывод последнего элемента массива.
}
else
{
    Console.WriteLine("Некорретный ввод данных!");
}