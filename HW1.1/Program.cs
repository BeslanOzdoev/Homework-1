int numberA = 4;
int numberB = 16;

if (numberA < 0)
{
     Console.WriteLine($"Число {numberA} отрицательно, корня квадратного не имеет");
}
else
{
        if (numberB != Math.Sqrt(numberA))
        {
              Console.WriteLine($"Число {numberA} является квадратным корнем {numberB}");
        }
        else
        {
                  Console.WriteLine($"Число {numberA} не является квадратным корнем {numberB}");
        }
}
