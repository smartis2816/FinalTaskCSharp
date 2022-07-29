
string[] CreateStringArray(int size)
{
    string[] newArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element of the array: ");
        newArray[i] = Console.ReadLine();
    }

    return newArray;
}

void ShowStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int RandomInteger (int min, int max)
{
    Random rand = new Random();
    int size = rand.Next(min, max);

    return size;
}

