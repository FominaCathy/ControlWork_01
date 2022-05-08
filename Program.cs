// Задача:  написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив задан на старте выполнения алгоритма

// подсчет размера выходного массива и создание его
// заполнение нового массива -основная часть. блок-схема на нее
// вывод на экран 


string[] arrayIn = {"Rom", "London", "Dom", "hole", "caverne", "si"};

PrintArray(arrayIn);

int sizeArrOut = SazeNewArray (arrayIn); 
string[] arrayOut = new string[sizeArrOut];

FillArray (arrayIn, arrayOut);
PrintArray(arrayOut);

void PrintArray (string[] arr) // вывод массива на экран
{
    int i = 0;
    int size = arr.Length;
    Console.Write("[");
    for (i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine("]");
}

int SazeNewArray (string[] arr) // подсчет размера выходного массива
{   
    int i = 0;
    int count = 0;
    int size = arr.Length;
    for (i = 0; i < size; i++) 
        if (arr[i].Length < 4) count++;
    return count;

}

string[] FillArray (string[] arrayIn, string[] arrayOut) // заполнение нового массива 
{
    int arraySize = arrayIn.Length;
    int i = 0;
    int j = 0;

    while (i < arraySize)
    {
        if (arrayIn[i].Length < 4)
        {
            arrayOut[j] = arrayIn[i];
            j++;
        }
        i++;
    }
    return arrayOut;

}
