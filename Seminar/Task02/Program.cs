// На вход подаётся не более 1000 чисел
//Из отрезка [0; 100]
//Найти количество вхождений каждого числа
//1 1 2 2 1 1 2 3 3 3 3 3 3 4 4 4 1 1 1 1 
//1 - 8 шт
//2 - 3 шт
//3 - 6 шт
//4 - 3 шт
// Наш метод не очень хороший
// метод, который создаёт массив
// int[] col = CreateArray(1000);
// Console.WriteLine(PrintGood(col));
// Fill(col, 0, 100);
// Console.WriteLine(PrintGood(col));

// Метод наполнения массива 

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

string PrintArray(int[] array)
{
  string result = "[ ";
  for(int i = 0; i < array.Length; i++)
  {
    result += ($"{array[i]} ");
  }
  return result + "]";
}

// Метод подсчёта колличества чисел
void CountMethod(int[] Array)
{
    
    for (int i = 0; i < 100; i++)
    {
        int count = 0;
        for (int j = 0; j < 1000; j++)
        {
            if (i == Array[j])
                count++;
        }
        Console.WriteLine($"{i} - {count} ");
        i++;
    }
}

// Клиентский код

int[] myArray = new int[1000];
FillArray(myArray, 0, 100);
Console.WriteLine(PrintArray(myArray));
CountMethod(myArray);


