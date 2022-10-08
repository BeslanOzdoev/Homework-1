Console.Write("Введите число ");
double x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
double y = Convert.ToInt32(Console.ReadLine());
double numberA = x / y;

double numberB = numberA - Math.Round(numberA);

if (numberB==0)
{
Console.WriteLine("Число кратко заданному");
}
else
{
Console.Write("Число некратно, остаток = ");
Console.WriteLine(numberB);
}



