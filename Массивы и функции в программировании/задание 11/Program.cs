// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100,999);
    }
    return arr;
}

int Num(int[] arr)
{
 int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }        
    }
    return count;
}    
int[] arr_1 = MassNums(12);
Print(arr_1);
Console.WriteLine(Num(arr_1));

int[] arr_2 = MassNums(12);
Print(arr_2);
Console.WriteLine(Num(arr_2));