void PrintResultArr(string[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (i == 0) Console.Write($"[\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\", ");
    }
    Console.Write($"\"{arr[^1]}\"]");
}

string[] StringFilter(string[] array)
{
    int size = 0;
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            size++;
        }
    }

    string[] resultArr = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArr[count++] = array[i];
        }
    }
    return resultArr;
}

string[] array = { "Один", "Два", "Три", "Четыре", ":)" };

string[] result = StringFilter(array);

PrintResultArr(result);