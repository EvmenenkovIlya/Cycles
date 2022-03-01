//Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int tmp = 1;
while (b != 0)
{
    tmp = tmp * a;
    b--;
}
Console.WriteLine(tmp);