
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

string[] SelectStringsByLength (string[] array, int value)
{
    string[] SelectedArray = new string[array.Length];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i].Length <= value)
        {
            SelectedArray[j] = array[i];
            j++;
        }

    return SelectedArray;
}

int n = 3;
int min = 2;
int max = 7;

int size = RandomInteger(min, max);
string[] InputArray = CreateStringArray(size);
Console.WriteLine();
ShowStringArray(InputArray);
ShowStringArray(SelectStringsByLength(InputArray, n));
