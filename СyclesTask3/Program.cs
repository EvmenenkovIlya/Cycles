// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
int a = Convert.ToInt32(Console.ReadLine());
int countOfNumbers = 0;
for (int i = 1; i < a; i++)
{
    if (i * i < a)
    {
        countOfNumbers++;
    }
    else
        break;
}
Console.WriteLine(countOfNumbers);

