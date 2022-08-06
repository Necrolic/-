// Напишите программу, которая будет создавать копию заданного 2-мерного массива с помощью поэлементного копирования.

void Print(int[,] matr)
{
    int row_size = matr.GetLength(0);
    int column_size = matr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
      
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] matr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            matr[i, j] = new Random().Next(from, to);
    return matr;
}

int[,] CopyMass(int[,] matr)
{
    int row = matr.GetLength(0);
    int column = matr.GetLength(1);
    int[,] new_matr = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
       {
            new_matr[i, j] = matr[i, j];
       }
    return new_matr;
}

int[,] matr_1 = MassNums(2, 6, 1, 11);
Print(matr_1);
int[,] new_matr_1 = CopyMass(matr_1);
Print(new_matr_1);

int[,] matr_2 = MassNums(2, 6, 1, 11);
Print(matr_2);
int[,] new_matr_2 = CopyMass(matr_2);
Print(new_matr_2);
