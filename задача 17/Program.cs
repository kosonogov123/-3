Console.Clear();
Console.Write("Введите Координату Х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату У: ");
double y = Convert.ToDouble(Console.ReadLine());
while (x==0 && y == 0)
{Console.Write("Вы ошиблись! Введите Координату Х: ");
 x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату У: ");
 y = Convert.ToDouble(Console.ReadLine());}
if (x>0 && y > 0)
Console.WriteLine("I");
else if (x<0 && y > 0)
Console.WriteLine("II");
else if (x<0 && y < 0)
Console.WriteLine("III");
else
Console.WriteLine("IV");