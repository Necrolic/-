// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
   
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}
void DiffMaxMin(double[] arr)
{
     double max = arr[0];
     double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
         if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.Write($"Max: {max}, min: {min}.");
   Console.WriteLine($"Difference: {max} - ({min}) = {Math.Round(max - min, 2)}");
}
double[] arr_1 = MassNums(4);
Print(arr_1);
DiffMaxMin(arr_1);

double[] arr_2 = MassNums(4);
Print(arr_2);
DiffMaxMin(arr_2);