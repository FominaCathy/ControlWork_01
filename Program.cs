// Задача:  написать программу, 
// которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа

// подсчет кол-ва элементов в заданном массиве длина которых меньше либо равна 3 символа
// заполнение нового массива -основная часть. блок-схема на нее
// вывод на экран 


string[] arrayIn = {"Rom", "London", "Dom", "hole", "caverne"};//new string[];
//string[] arrayOut = new string[];
int i = 0;
int j = 0;

PrintArray(arrayIn);


void PrintArray (string[] arr) // вывод массива на экран
{
    int i = 0;
    int size = arr.Length;
    for (i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");

}