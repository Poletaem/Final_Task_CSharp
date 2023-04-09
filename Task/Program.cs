//Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


Console.Write($"Введите количество элементов:    ");
int count = int.Parse(Console.ReadLine()!);
string[] Array = new string[count];

string[] MassString(string[] Array)
{
    Console.Write($"Введите  элементы:  ");

    for (int i = 0; i < count; i++)
    {
        Array[i] = Console.ReadLine()!;
    }

    return Array;
}
MassString(Array);


void Print(string[] Array)
{
    int size = Array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{Array[i]} ");

}
Console.WriteLine();
Console.WriteLine($"Ваши значения:    ");
Print(Array);



string[] NewArray = new string[Array.Length];

void ThreeSimbols(string[] Array)
{
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            NewArray[j] = Array[i];
            j++;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"Новые значения:    ");
ThreeSimbols(Array);
Print(NewArray);
