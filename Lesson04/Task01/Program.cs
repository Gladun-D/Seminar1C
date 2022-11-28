//  Напишите метод, который принимает на вход два числа (A и B)
 
//возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
int raisedNumber = A;
for (int index = 1; index < B; index++)
{
    raisedNumber = raisedNumber * A;
}
Console.WriteLine("A в степени B: " + raisedNumber);















