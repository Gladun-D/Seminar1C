//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 д
Console.WriteLine("Введите трёхзначное число");
string number = Console.ReadLine();
int stringlenght = 3;
int numberlenght = number.Length;
while(true)
{
    if(numberlenght == stringlenght)
    Console.WriteLine("{0}->{1}",number, number[1]);
    break;
}







