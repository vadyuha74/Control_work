// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа.

void OutputArray(string[] arr) //печать массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write("\"{0}\"", arr[i]);
        else Console.Write("\"{0}\", ", arr[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

string NumbersString(int n) // заполнение Латиницей случайной строки длиной n 
{
    Random rand = new Random();
    return (n > 0) ? $"{Convert.ToChar(rand.Next('a', 'z' + 1))}" + NumbersString(n - 1) : $"{Convert.ToChar(rand.Next('a', 'z' + 1))}";
}

void FillArrayRand(string[] strs) // заполнение массива  случайными строками длиной от 1 до 9
{
    for (int i = 0; i < strs.Length; i++)
    {
        int k = new Random().Next(1, 10);
        strs[i] = NumbersString(k);
    }
}

string[] SelectArrStr(string[] arr) // Из строчного массива делаем массив со строками меньше 4 символов
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            arr[j] = arr[i];
            j++;
        }
    }
    string[] array = new string[j];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

string[] arr = new string[20];
FillArrayRand(arr);
OutputArray(arr);
arr = SelectArrStr(arr);
Console.WriteLine("результат");
OutputArray(arr);