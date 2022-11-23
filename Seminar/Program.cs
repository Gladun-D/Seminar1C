//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 д
static void Main(string[] args)
int n = int.Parse(1);
int m = int.Parse(8);
for (int i = n; i <= m; i++)
{
  if (i % 2 == 0)
  {
  Console.Write(i + " ");
  }
}