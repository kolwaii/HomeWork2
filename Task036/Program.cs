// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int Input(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] CreateArrayRndInt(int size,int min,int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SumNumber(int[] arr)
{
   int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) 
        {
            count +=arr[i];
        }
        
    }
    return count;

}

int size = Input("Введите длину массива: ");
int[] array = CreateArrayRndInt(size, 1, 99);
int evenNumber = SumNumber(array);
Console.WriteLine($"сумма нечетных чисел:{evenNumber}");
PrintArray(array);