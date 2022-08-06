// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
int[,] MatrixProduct(int[,] arr_one, int[,] arr_two)
{
     int row_size = arr_one.GetLength(0);
     int column_size = arr_one.GetLength(1);
     int[,] matrix = new int[row_size, column_size];
        for (int i = 0; i < row_size; ++i)
            for (int j = 0; j < column_size; ++j)
                for (int k = 0; k < column_size; ++k)
                     matrix[i, k] += arr_one[i, j] * arr_two[j, k];
     return matrix;
}
Console.Write("number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 2, 6);
Print(arr_1);
int[,] arr_2 = MassNums(row, column, 2,6);
Print(arr_2);

int[,]matrix = MatrixProduct(arr_1, arr_2);
Print(matrix);