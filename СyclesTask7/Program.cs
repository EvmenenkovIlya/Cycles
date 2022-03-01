// Пользователь вводит 2 числа.
// Найти их наибольший общий делитель используя алгоритм Евклида.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int nod;
int tmp;

if (b > a)
{
    tmp = b;
    b = a;
    a = tmp;
}

while (b != 0)
{
    tmp = b;
    b = a % b;
    a = tmp; 
}
Console.WriteLine(a);
