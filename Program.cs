// Задача:  написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив задан на старте выполнения алгоритма

// подсчет размера выходного массива и создание его
// заполнение нового массива -основная часть. (блок-схема на нее)
// вывод на экран 


string PrintArray (string[] arr) // вывод массива на экран
{
    int i = 0;
    int size = arr.Length;
    string printArr = String.Empty;

    printArr = "[";
    for (i = 0; i < size; i++)
        printArr += $"\"{arr[i]}\", ";
    printArr += "]";

    return printArr;
}

int SazeNewArray (string[] arr) // подсчет размера выходного массива
{   
    int i = 0;
    int count = 0;
    int size = arr.Length;
    for (i = 0; i < size; i++) 
        if (arr[i].Length <= 3) count++;
    return count;

}

string[] FillArray (string[] arrayIn, string[] arrayOut) // заполнение нового массива (по блок -схеме)
{
    int arraySize = arrayIn.Length;
    int i = 0;
    int j = 0;

    while (i < arraySize)
    {
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[j] = arrayIn[i];
            j++;
        }
        i++;
    }
    return arrayOut;

}

string[] arrayInput = {"Rom", "cookies", "&*(00", "hole", "caverne", "si", "213"}; 

Console.WriteLine(PrintArray(arrayInput));

int sizeArrOut = SazeNewArray (arrayInput); 
string[] arrayOutput = new string[sizeArrOut];

arrayOutput = FillArray (arrayInput, arrayOutput);

Console.WriteLine(PrintArray(arrayOutput));