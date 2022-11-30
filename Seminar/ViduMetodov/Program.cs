// Методы
// Вид 1 - ничего не возвращают и ничего не принимают.
void Method1()
{
    Console.WriteLine("Автор: Дмитрий Михайлович");
}
// Вызов метода следующая строка(Пока её убрали, что бы вызывать следующие методы)
//Method1(); 

// Вид 2 - ничего не возвращают, но могут принимать какието аргументы(операторов)
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Вызов метода следующая строка(Пока её убрали, что бы вызывать следующие методы)
//Method2(msg: "Текст сообщения", count: 4);

//Вид 4 - Метод который что-то возвращает, но ничего не принимает.
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Вызов метода следующая строка(Пока её убрали, что бы вызывать следующие методы)
// Console.WriteLine(year);

// Вид 4 - Методы которые что-то принимают и что-то возвращают.
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Женя ты супер!\n");
Console.WriteLine(res);