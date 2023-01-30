Console.Clear();
Console.Write("Введите номер четверти (1-4) ");
int x = Convert.ToInt32(Console.ReadLine());

while (x<1 || x>4 )
{Console.Write("Вы ошиблись! Введите значение от 1 до 4 ");
 x = Convert.ToInt32(Console.ReadLine());
}
if (x==1)
Console.WriteLine("x>0, y>0");
else if (x==2)
Console.WriteLine("x<0, y>0");
else if (x==3)
Console.WriteLine("x<0, y<0");
else
Console.WriteLine("x>0, y<0");