// Пользователь вводит целое положительное  число (N).
// Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
int N = Convert.ToInt32(Console.ReadLine());
int even = 0;
int odd = 0;
for (int i = 0; i < N; i++) 
{
    int tmp = i;
    while (tmp > 0)
    {
        int tmpCycle = tmp % 10;
        if (tmpCycle % 2 == 0)
        {
            even += tmpCycle;
        }
        else
        {
            odd += tmpCycle;
        }
        tmp /= 10;
    }
    if (even > odd)
    {
        Console.WriteLine(i);
    }
    even = 0;
    odd = 0;
}

