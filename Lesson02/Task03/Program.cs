// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
int dayNumber = 5;
if (1<= dayNumber & dayNumber <= 5)
{
    Console.WriteLine("Будний День");
}
if (6<= dayNumber & dayNumber <= 7)
{
    Console.WriteLine("Ура - Выходной");
}
if (dayNumber > 7)
{
    Console.WriteLine("Не корректное число");
}