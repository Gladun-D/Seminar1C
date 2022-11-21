// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int A = 0;
int B = 28;
int C = 7;
int max = A;
if (max > B ) max = A;
if (B > max ) max = B;
if (C > max ) max = C;
Console.Write ("max= ");
Console.WriteLine(max);
