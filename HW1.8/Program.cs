Console.Write("Введите трехзначное число ");
int numberA = int.Parse(Console.ReadLine());

int numberA_2 = numberA / 10 % 10;

Console.Write("Второй элемент числа ");
Console.WriteLine(numberA_2);
