string[,] table = new string [2, 5];
// Отчёт элементов идёт по индексам и первый элемент равен 
// table [0, 0] table [0, 1] table [0, 2] table [0, 3] table [0, 4]
// table [1, 0] table [1, 1] table [1, 2] table [1, 3] table [1, 4]
table[1,2] = "слово";
for (int row = 0; row < 2; row++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"--{table[row, columns]}--");
    }
}