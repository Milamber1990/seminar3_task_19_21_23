Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;
double result = 0;
//Console.Clear();
while (num2 <= num1)
{
    result = Math.Pow(num2,3);
    Console.Write($" |{result}| ");
    num2++;
}