// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}
void Sum(int[] arr)
{
    int sum = 0;
    
    for (int i = 0; i < arr.Length;  i++)
    {
        if (i % 2 == 1)
        {
           sum = sum + arr[i];
        }
        
    }
  Console.WriteLine(sum);
}
int[] arr_1 = MassNums(4);
Print(arr_1);
Sum(arr_1);
int[] arr_2 = MassNums(4);
Print(arr_2);
Sum(arr_2);
