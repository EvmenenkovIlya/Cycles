// Пользователь вводит целое положительное число, которое является кубом целого числа N.
// Найдите число N методом половинного деления.
int N = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = N;
int tmp = 0;
while (a * a * a != N && b * b * b != N)
{
    tmp = (a + b) / 2;
    if (tmp * tmp * tmp > N)
    {
        b = tmp;
    }
    else
    {
        a = tmp;
    }
}
Console.WriteLine(tmp);
