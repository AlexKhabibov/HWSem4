// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int sizeArray)
{
    int[] randomArray = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        randomArray[i] = new Random().Next(0, 9);
    }
    return randomArray;
}

void PrintArray(int[] arrayToPrint)
{
    Console.WriteLine("Your array is:");
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write(arrayToPrint[i] + " ");
}

int[] myArray = CreateArray(10);
PrintArray(myArray);