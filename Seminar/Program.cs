//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 д
Console.WriteLine("Введите трехзначное число: ");
string input = Console.ReadLine();
int stringlen = 3;
int inputlen = input.Length;
    while(true)
    {
        if(inputlen == stringlen)
            Console.WriteLine("{0}->{1}",input, input[1]);
            break;
    }
    