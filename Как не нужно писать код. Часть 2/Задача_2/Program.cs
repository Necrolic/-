// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}
void RowSmallAmount(int[,] arr)
{
     int row_size = arr.GetLength(0);
     int column_size = arr.GetLength(1);
     int sumLine = 1000;
     int tempSumLine;
     int minSumLine = 0;
     for (int i = 1; i < row_size; i++)
     {   
         tempSumLine= 0;
         for (int j = 0; j < column_size; j++)
         tempSumLine += arr[i, j];
         if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
     }
    Console.Write($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
}

Console.Write("number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 0, 10);
Print(arr_1);
RowSmallAmount(arr_1);

