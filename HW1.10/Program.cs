Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

int s = 2;
int m = 1;
while (s > 1) {
     m *= 10;
     s--;
}
int t = (x % m) + (x / (m * 10)) * m;
Console.WriteLine(t);