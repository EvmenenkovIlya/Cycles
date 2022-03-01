//Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (N != 0)
{
    if ((N % 10) % 2 == 1)
    {
        count++;
    }
    N = N / 10;
}
Console.WriteLine(count);