// Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B,
// которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int tmp;
int count = 0;
if (b < a) 
{
    tmp = b;
    b = a;
    a = tmp;
}
for (int i = a; i <= b; i++)
{
    if (i % 7 == 0)
    {
        count += i;
    }
}
Console.WriteLine(count);
