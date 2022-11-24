// // Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numberlenght = number.Length;
int index = 2;
if (numberlenght >= index + 1)
{
    Console.WriteLine("{0}->{1}",number, number[index]);
}
else 
{
   Console.WriteLine("Третей цифры нет");
}