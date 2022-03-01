// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
int a = Convert.ToInt32(Console.ReadLine());
int countOfNumbers = 0;
while (countOfNumbers * countOfNumbers < a)
{
        countOfNumbers++;
}
Console.WriteLine(countOfNumbers);

