/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символам.*/

string[] array1 = new string[7] {"hello", "2", "world", ";-)", "123", "Russia", "computer science"};
string[] array2 = new string[array1.Length];

void SecondArrayCreate(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[index] = array1[i];
        index = index +1;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Вот наш изначальный массив: ");
PrintArray(array1);
SecondArrayCreate(array1, array2);
Console.WriteLine();
Console.WriteLine("После отбора элементов, меньше либо равных 3 символам, получаем такой массив: ");
PrintArray(array2);
