void PrintArr(string[] arr) //функция для вывода массива на печать
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[\"{arr[i]}\", ");
        else Console.Write(i == arr.Length - 1 ? $"\"{arr[i]}\"]" : $"\"{arr[i]}\", ");
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

    string[] resultArr = new string[newSize];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            resultArr[count++] = array[i];
        }
    }
    return resultArr;
}

string[] array = { "Один", "Два", "Три", "Четыре", ":)" }; //исходный массив со строками

string[] result = StringFilter(array, 3);

PrintArr(array);
Console.Write(" -> ");
PrintArr(result);