Console.Clear();
Console.Write("Введите пятизначное число ");
int x = Convert.ToInt32(Console.ReadLine());

while (x<10000 || x>99999 )
{Console.Write("Вы ошиблись! Введите пятизначное число ");
 x = Convert.ToInt32(Console.ReadLine());
}
if (x/10000 == x%10 && (x/1000)%10 == (x%100)/10)
Console.WriteLine("yes");

else
Console.WriteLine("no");