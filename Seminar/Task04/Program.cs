//Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.
Console.Write("Введите любое число эллементов массива: ");
int enterNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[enterNumber];
for (int i = 0; i < enterNumber; i++)
{
  array[i] = new Random().Next(enterNumber+1);
  Console.Write(array[i] + ", ");
}
Console.WriteLine();