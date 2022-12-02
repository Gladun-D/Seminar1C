// string[,] table = new string [2, 5];
// // Отчёт элементов идёт по индексам и первый элемент равен 
// // table [0, 0] table [0, 1] table [0, 2] table [0, 3] table [0, 4]
// // table [1, 0] table [1, 1] table [1, 2] table [1, 3] table [1, 4]
// table[1,2] = "слово";
// for (int row = 0; row < 2; row++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"--{table[row, columns]}--");
//     }
// }

int[,] matrix = new int[3,4];
void PrintArray(int[,] matr)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
            matr[i,j] = new Random().Next(1,10);
            }
        }    
}


// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// Рекурсия
int Factorial(int n)
{
    // 1! = 1 - рекурсия от 1 = 1
    // 0! = 1
    if(n==1) return 1;
    else return n * Factorial(n-1);
}
for(int i = 1; i < 40; i++)
{
// Console.WriteLine($"{i}!={Factorial(i)}");// 1 * 2 * 3 = 6
}
 
// Метод Фибоначчи - в которой первые два числа равны 0 и 1, а каждое последующее 
//число равно сумме двух предыдущих чисел: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for(int i = 1; i < 10; i++)
{
    // Console.WriteLine(Fibonacci(i));
    Console.WriteLine($"f{i} = {Fibonacci(i)}");
}