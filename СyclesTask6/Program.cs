// Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи.
// В ряду фибоначчи каждое следующее число является суммой двух предыдущих.
// Первое и второе считаются равными 1.
int N = Convert.ToInt32(Console.ReadLine());
int first = 1;
int second = 1;
int tmp = 0;
if (N <= 2)
{
    Console.WriteLine(1);
}
else
{
    for (int i = 2; i < N; i++) 
    {
        tmp = first + second;
        first = second;
        second = tmp;
    }
    Console.WriteLine(tmp);
}



