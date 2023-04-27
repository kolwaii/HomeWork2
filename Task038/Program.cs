// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreateArrayRndDouble(int size,int min,int max)
{
    double[] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}

double MaxNumber(double[] arr)
{   
    double count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        double max = arr[i];
        max = count;

        if (arr[i] > max)                          
        {
        max = arr[i];
        count = max;
        }

        else arr[i]++;
    }
    return count;
}
double MinNumber(double[] arr)
{   
    double count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        double min = arr[i];
        min = count;

        if (arr[i] < min)                          
        {
        min = arr[i];
        count = min;
        }

        else arr[i]++;
    }
    return count;
}

double[] array = CreateArrayRndDouble(5, 1, 99);        //Я сильно запутался, не понял как написать метод на разницу между максимальным и минимальным
double diffMaxNumber = MaxNumber(array);                //И в методах max и min.
double diffMinNumber = MinNumber(array);
double result = diffMaxNumber - diffMinNumber;
double round = Math.Round(result, 1);
Console.WriteLine($"разница между минимальным и максимальным числом:{result }");
PrintArray(array);
