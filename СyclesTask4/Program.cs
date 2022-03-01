// Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
int a = Convert.ToInt32(Console.ReadLine());
int tmp = 0;
for (int i = a - 1; i != 0 ; i--)
{
    if (a % i == 0)
    {
        tmp = i;
        break;
    }
}
Console.WriteLine(tmp);