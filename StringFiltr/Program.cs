void PrintArr(string[] arr) //функция для вывода массива на печать
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == "" && arr.Length == 1) Console.Write("[]");
        else
        {
            if (arr.Length == 1) Console.Write($"[\"{arr[i]}\"]");
            else if (i == 0) Console.Write($"[\"{arr[i]}\", ");
            else Console.Write(i == arr.Length - 1 ? $"\"{arr[i]}\"]" : $"\"{arr[i]}\", ");
        }
    }
}

string[] StringFilter(string[] array, int maxLength) //основная функция, возвращающая новый массив из исходного, со строками длиной maxLength и менее символов 
{
    int newSize = 0;
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            newSize++;
        }
    }

    if (newSize == 0)
    {
        string[] resultArray = { "" };
        return resultArray;
    }
    else
    {
        string[] resultArray = new string[newSize];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLength)
            {
                resultArray[count++] = array[i];
            }
        }
        return resultArray;
    }
}

string[] array = { "Один", "Два", "ф", "ывыв", ":-)" }; //исходный массив со строками

string[] result = StringFilter(array, 3);

PrintArr(array);
Console.Write(" -> ");
PrintArr(result);