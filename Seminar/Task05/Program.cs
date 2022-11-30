// //Таблица умножения. 
// for(int i = 1; i <= 10; i++)
// {
//     for(int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// Сортировка массива 

int[] arr = {1, 5, 4, 6, 7, 8, 9, 2, 2, 10};
void PrintArray(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectSort(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
        int minNumber = i; 
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minNumber]) 
            {
                minNumber = j;
            }
        }
        int temporary= array[i];
        array[i] = array[minNumber];
        array[minNumber] = temporary;

    }
}
PrintArray(arr);
SelectSort(arr);

PrintArray(arr);
    
