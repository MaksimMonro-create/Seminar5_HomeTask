// НАПИСАТЬ ПРОГРАММУ КОПИРОВАНИЯ МАССИВА

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int[] CopyArray(int[] originArray)
{
    int[] copy = new int[originArray.Length];
    for (int i = 0; i < originArray.Length; i++)
    {
        copy[i] = originArray[i];
    }
    return copy;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " " );
    }
}

int size = 5;
int min = 1;
int max = 10;

int[] origin = GetArray(size, min, max);
Console.WriteLine("Исходный массив:");
PrintArray(origin);
Console.WriteLine();
Console.WriteLine("Копия массива:");
int[] copy = CopyArray(origin);
Console.WriteLine();
PrintArray(copy);

