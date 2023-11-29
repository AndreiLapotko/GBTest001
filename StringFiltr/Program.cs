void PrintArr(string[] arr) //функция для вывода массива на печать
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[\"{arr[i]}\", ");      
        else Console.Write(i == arr.Length-1 ? $"\"{arr[i]}\"]" : $"\"{arr[i]}\", ");
    }    
}

string[] StringFilter(string[] array) //основная функция, возвращающая новый массив из исходного, со строками длиной 3 и менее символов 
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

string[] array = { "Один", "Два", "Три", "Четыре", ":)" }; //исходный массив со строками

string[] result = StringFilter(array);

PrintArr(array);
Console.Write(" -> ");
PrintArr(result);