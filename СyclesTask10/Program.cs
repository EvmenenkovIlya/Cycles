﻿// Пользователь вводит 1 число. Найти число, которое является зеркальным отображением
// последовательности цифр заданного числа, например, задано число 123, вывести 321.
int N = Convert.ToInt32(Console.ReadLine());
int tmp = 0;
while (N != 0)
{
    tmp = tmp * 10 + N % 10;
    N = N / 10;
}
Console.WriteLine(tmp);