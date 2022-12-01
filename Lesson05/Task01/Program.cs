//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateArray(int size, int min, int max) 
{
    int[] MiArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        MiArray[i] = new Random().Next(min, max);
    }
    return MiArray;
}

void PrintArray(int[] Array1)
{
    for (int i = 0; i < Array1.Length; i++)
    {
        Console.Write(Convert.ToString($"{Array1[i]}  "));
    }
}
int CountOfEven(int[] Array2)
{
    int count = 0;
    for (int i = 0; i < Array2.Length; i++)
    {
        if (Array2[i] % 2 == 0)
        {
            count = count +1;
        }
    }
    return count;
}
int [] myArray = new int [10];
myArray = CreateArray(10, 100, 999);
PrintArray(myArray);
Console.WriteLine("Чётные числа" + CountOfEven(myArray));