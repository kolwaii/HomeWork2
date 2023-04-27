// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

int EvenNumber(int[] arr)
{
   int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
        {
            count++;
        }
        
    }
    return count;

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

int size = Input("Введите длину массива: ");
int[] array = CreateArrayRndInt(size, 100, 999);
int evenNumber = EvenNumber(array);
Console.WriteLine($"четных чисел:{evenNumber}");
PrintArray(array);

