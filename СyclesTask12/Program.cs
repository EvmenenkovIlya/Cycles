// Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. 
// Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
bool flag = false;

while (a != 0)
{ 
    int tmp = a % 10;
    for (int i =b; i!=0; i /=10)
    {
        if (tmp == i % 10)
        {
            flag = true;
            Console.WriteLine("ДА");
            break;
        }
    }
    if (flag) break;
    a /= 10;
}
if (flag == false)
{
        Console.WriteLine("НЕТ");
}
