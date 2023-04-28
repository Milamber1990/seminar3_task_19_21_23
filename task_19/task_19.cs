Console.WriteLine("Введите пятизначное число число");
int num = Convert.ToInt32(Console.ReadLine());

int num2 = (num / 1000)%10;

int num4 = (num / 10)%10;

if (num2 == num4)
Console.WriteLine("YES");
else
Console.WriteLine("NO");