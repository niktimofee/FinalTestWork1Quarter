﻿string[] array1 = new string[5] {"hello", "world", ":)", "123", "-321"};
string[] array2 = new string[array1.Length];
SecondArrayWithIF(array1, array2);
PrintArray(array2);

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
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