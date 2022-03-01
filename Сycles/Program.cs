//Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int tmp = a;
for (int i = 1; i < b; i++)
{
    a = tmp * a;
}
if (b == 0)
{ 
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(a);
}