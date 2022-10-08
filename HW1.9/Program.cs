int numberA = new Random().Next(10,90);
Console.Write ("Заданное число = ");
Console.WriteLine (numberA);

int a = numberA % 10;

int b = numberA / 10 % 10;

int max = a;

if (a > max) max = a;
if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine (max);
